using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;
using Курсач.Views;
using Курсач._Repository;
using System.Configuration;
using System.Collections;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Курсач._Repository
{
    public class Repository : IRepository
    {
        protected string connectionString;
        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //------------------------------------------------------------------------\\
        // -----------------------------Конференции-------------------------------\\
        //------------------------------------------------------------------------\\

        public void AddConf(ConfModel confModel)
        {
            confModel.Curr_num_of_participants = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"INSERT INTO Conferences('conf_topic', 'conf_organizer_id', 'conf_date'," +
                        "'conf_time', 'conf_address', 'curr_num_of_participants', 'max_num_of_participants') values (" +
                        "@conf_topic, @conf_organizer_id, @conf_date, @conf_time, @conf_address, @curr_num_of_participants, " +
                        "@max_num_of_participants)";
                    command.Parameters.Add("@conf_topic", System.Data.DbType.String).Value = confModel.Conf_topic;
                    command.Parameters.Add("@conf_organizer_id", System.Data.DbType.Int32).Value = confModel.Conf_organizer_id;
                    command.Parameters.Add("@conf_date", System.Data.DbType.String).Value = confModel.Conf_date;
                    command.Parameters.Add("@conf_time", System.Data.DbType.String).Value = confModel.Conf_time;
                    command.Parameters.Add("@conf_address", System.Data.DbType.String).Value = confModel.Conf_address;
                    command.Parameters.Add("@curr_num_of_participants", System.Data.DbType.Int32).Value = confModel.Curr_num_of_participants;
                    command.Parameters.Add("@max_num_of_participants", System.Data.DbType.Int32).Value = confModel.Max_num_of_participants;
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }                       
        }       

        public void DeleteConf(int id)
        {
            string query = $"DELETE FROM Conferences WHERE conf_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }            
            query = $"DELETE FROM Conf_participant WHERE conf_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }           
        }

        public void EditConf(ConfModel confModel)
        {
            string query = $"UPDATE Conferences SET conf_topic='" + confModel.Conf_topic + "', " +
                "conf_organizer_id=" + confModel.Conf_organizer_id + ", " +
                "conf_date='" + confModel.Conf_date + "', " +
                "conf_time='" + confModel.Conf_time + "', " +
                "conf_address='" + confModel.Conf_address + "', " +
                "max_num_of_participants=" + confModel.Max_num_of_participants + " WHERE conf_id=" + confModel.Conf_id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }           
        }

        public IEnumerable<ConfModel> GetAllConfs()
        {
            var confList = new List<ConfModel>();
            string query = $"SELECT * FROM Conferences ORDER BY conf_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var confModel = new ConfModel();
                        confModel.Conf_id = Convert.ToInt32(reader[0]);
                        confModel.Conf_topic = reader[1].ToString();
                        confModel.Conf_date = reader[2].ToString();
                        confModel.Conf_time = reader[3].ToString();
                        confModel.Conf_address = reader[4].ToString();
                        confModel.Curr_num_of_participants = Convert.ToInt32(reader[5]);
                        confModel.Max_num_of_participants = Convert.ToInt32(reader[6]);
                        confModel.Conf_organizer_id = reader[7].ToString();
                        confList.Add(confModel);
                    }
                }
            }
            return confList;
        }

        public IEnumerable<ConfModel> GetByValueConfs(string value)
        {
            var confList = new List<ConfModel>();
            int confID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string topic = value;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"SELECT * FROM Conferences WHERE 
                                           (conf_id=@id  OR conf_topic like @topic) ORDER BY conf_id DESC";
                    command.Parameters.Add("@id", System.Data.DbType.Int32).Value = confID;
                    command.Parameters.AddWithValue("@topic", "%" + topic + "%");
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var confModel = new ConfModel();
                            confModel.Conf_id = Convert.ToInt32(reader[0]);
                            confModel.Conf_topic = reader[1].ToString();
                            confModel.Conf_date = reader[2].ToString();
                            confModel.Conf_time = reader[3].ToString();
                            confModel.Conf_address = reader[4].ToString();
                            confModel.Curr_num_of_participants = Convert.ToInt32(reader[5]);
                            confModel.Max_num_of_participants = Convert.ToInt32(reader[6]);
                            confModel.Conf_organizer_id = reader[7].ToString();
                            confList.Add(confModel);
                        }
                    }
                }
            }
            return confList;
        }

        public IEnumerable<OrgModel> GetAllOrganizers()
        {
            var orgList = new List<OrgModel>();
            string query = $"SELECT * FROM Organizers ORDER BY org_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orgModel = new OrgModel();
                        orgModel.Org_id = Convert.ToInt32(reader[0]);
                        orgList.Add(orgModel);
                    }
                }
            }
            return orgList;
        }

        public IEnumerable<ConfModel> GetAllConfsForCB()
        {
            var confList = new List<ConfModel>();
            string query = $"SELECT * FROM Conferences ORDER BY conf_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var confModel = new ConfModel();
                        confModel.Conf_id = Convert.ToInt32(reader[0]);
                        confList.Add(confModel);
                    }
                }
            }
            return confList;
        }


        //-------------------------------------------------------------------------//
        // -----------------------------Организаторы-------------------------------//
        //-------------------------------------------------------------------------//

        public void AddOrg(OrgModel orgModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = "INSERT INTO Organizers ('org_surname', 'org_name', 'org_email'," +
                    "'org_company') values ('" +
                    orgModel.Org_surname + "' , '" + orgModel.Org_name + "' , '" +
                    orgModel.Org_email + "' , '" + orgModel.Org_company + "')";
                command.ExecuteNonQuery();
            }
        }

        public void DeleteOrg(int id)
        {
            string query = $"DELETE FROM Organizers WHERE org_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            var confList = new List<ConfModel>();
            query = $"SELECT * FROM Conferences WHERE conf_organizer_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var confModel = new ConfModel();
                        confModel.Conf_id = Convert.ToInt32(reader[0]);
                        confModel.Conf_topic = reader[1].ToString();
                        confModel.Conf_date = reader[2].ToString();
                        confModel.Conf_time = reader[3].ToString();
                        confModel.Conf_address = reader[4].ToString();
                        confModel.Curr_num_of_participants = Convert.ToInt32(reader[5]);
                        confModel.Max_num_of_participants = Convert.ToInt32(reader[6]);
                        confModel.Conf_organizer_id = reader[7].ToString();
                        confList.Add(confModel);
                    }
                }
            }
            query = $"DELETE FROM Conferences WHERE conf_organizer_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            foreach (var confModel in confList)
            {
                query = $"DELETE FROM Conf_participant WHERE conf_id=" + confModel.Conf_id;
                using (var connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditOrg(OrgModel orgModel)
        {
            string query = $"UPDATE Organizers SET org_surname='" + orgModel.Org_surname + "', " +
                "org_name='" + orgModel.Org_name + "', " +
                "org_email='" + orgModel.Org_email + "', " +
                "org_company='" + orgModel.Org_company + "', " +
                " WHERE org_id=" + orgModel.Org_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<OrgModel> GetAllOrgs()
        {
            var orgList = new List<OrgModel>();
            string query = $"SELECT * FROM Organizers ORDER BY org_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orgModel = new OrgModel();
                        orgModel.Org_id = Convert.ToInt32(reader[0]);
                        orgModel.Org_surname = reader[1].ToString();
                        orgModel.Org_name = reader[2].ToString();
                        orgModel.Org_company = reader[3].ToString();
                        orgModel.Org_email = reader[4].ToString();
                        orgList.Add(orgModel);
                    }
                }
            }
            return orgList;
        }

        public IEnumerable<OrgModel> GetByValueOrgs(string value)
        {
            var orgList = new List<OrgModel>();
            int orgID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string orgSurname = value;
            string orgName = value;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM Organizers WHERE
                                        (org_id=@id OR (org_surname like @surname
                                         OR org_name like @name)) ORDER BY org_id ASC";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = orgID;
                command.Parameters.AddWithValue("@surname", "%" + orgSurname + "%");
                command.Parameters.AddWithValue("@name", "%" + orgName + "%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orgModel = new OrgModel();
                        orgModel.Org_id = Convert.ToInt32(reader[0]);
                        orgModel.Org_surname = reader[1].ToString();
                        orgModel.Org_name = reader[2].ToString();
                        orgModel.Org_company = reader[3].ToString();
                        orgModel.Org_email = reader[4].ToString();
                        orgList.Add(orgModel);
                    }
                }
            }
            return orgList;
        }


        //----------------------------------------------------------------------//
        // -----------------------------Участники-------------------------------//
        //----------------------------------------------------------------------//

        public void AddPart(ParticipantModel partModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Participants ('participant_surname', 'participant_name', 'participant_email')" +
                        " values ('" +
                        partModel.Participant_surname + "' , '" + partModel.Participant_name + "' , '" +
                        partModel.Participant_email + "')";
                    command.ExecuteScalar();
                }
                connection.Close();
            }
        }

        public void AddReg(ConfPartModel confpartModel)
        {
            int max = GetMaxNum(Convert.ToInt32(confpartModel.Conf_id));
            int curr = GetCurrNum(Convert.ToInt32(confpartModel.Conf_id));
            if (curr < max)
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"INSERT INTO Conf_participant ('conf_id', 'participant_id', 'topic', 'notificated')" +
                        " values (@conf_id, @part_id, @topic, 'false')";
                        command.Parameters.Add("@conf_id", System.Data.DbType.Int32).Value = Convert.ToInt32(confpartModel.Conf_id);
                        command.Parameters.Add("@part_id", System.Data.DbType.Int32).Value = confpartModel.Part_id;
                        command.Parameters.Add("@topic", System.Data.DbType.String).Value = confpartModel.Topic;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                var confModel = new ConfModel();
                confModel.Curr_num_of_participants = curr;
                confModel.Curr_num_of_participants++;
                string query = $"UPDATE Conferences SET curr_num_of_participants=" + confModel.Curr_num_of_participants + " WHERE conf_id=" + confpartModel.Conf_id;
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            else throw new Exception("Мест на конференцию больше нет!");
        }

        public void DeletePart(int id)
        {
            string query = $"DELETE FROM Participants WHERE participant_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            var confpartList = new List<string>();
            query = $"SELECT conf_id FROM Conf_participant WHERE participant_id="+id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var partModel = new ConfPartModel();
                        partModel.Conf_id = reader[0].ToString();
                        confpartList.Add(partModel.Conf_id);
                    }
                }
            }
            foreach(var conf_id in confpartList)
            {
                var confModel = new ConfModel();
                confModel.Curr_num_of_participants = GetCurrNum(Convert.ToInt32(conf_id));
                confModel.Curr_num_of_participants--;
                query = $"UPDATE Conferences SET curr_num_of_participants=" + confModel.Curr_num_of_participants + " WHERE conf_id=" + conf_id;
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            query = $"DELETE FROM Conf_participant WHERE participant_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteReg(int part_id, int conf_id, string topic)
        {
            int count = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"DELETE FROM Conf_participant WHERE ((conf_id=@conf_id AND participant_id=@part_id) AND topic=@topic)";
                    command.Parameters.Add("@conf_id", System.Data.DbType.Int32).Value = conf_id;
                    command.Parameters.Add("@part_id", System.Data.DbType.Int32).Value = part_id;
                    command.Parameters.Add("@topic", System.Data.DbType.String).Value = topic;
                    count = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            var confModel = new ConfModel();
            confModel.Curr_num_of_participants = GetCurrNum(conf_id);
            confModel.Curr_num_of_participants -= count;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"UPDATE Conferences SET curr_num_of_participants=@curr WHERE conf_id=@conf_id";
                    command.Parameters.Add("@conf_id", System.Data.DbType.Int32).Value = conf_id;
                    command.Parameters.Add("@curr", System.Data.DbType.Int32).Value = confModel.Curr_num_of_participants;
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private int GetCurrNum(int conf_id)
        {
            int count = 0;
            string query = $"SELECT curr_num_of_participants FROM Conferences WHERE conf_id=" + conf_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }
                }
                connection.Close();
            }
            return count;
        }
        private int GetMaxNum(int conf_id)
        {
            int count = 0;
            string query = $"SELECT max_num_of_participants FROM Conferences WHERE conf_id=" + conf_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }
                }
                connection.Close();
            }
            return count;
        }
        public void EditPart(ParticipantModel partModel)
        {
            string query = $"UPDATE Participants SET participant_surname='" + partModel.Participant_surname + "', " +
                "participant_name='" + partModel.Participant_name + "', " +
                "participant_email='" + partModel.Participant_email + "' " +
                " WHERE participant_id=" + partModel.Participant_id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<ParticipantModel> GetAllParts()
        {
            var partList = new List<ParticipantModel>();
            string query = $"SELECT * FROM Participants ORDER BY participant_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var partModel = new ParticipantModel();
                            partModel.Participant_id = Convert.ToInt32(reader[0]);
                            partModel.Participant_surname = reader[1].ToString();
                            partModel.Participant_name = reader[2].ToString();
                            partModel.Participant_email = reader[3].ToString();
                            partList.Add(partModel);
                        }
                    }
                }
                connection.Close();
            }
            return partList;
        }

        public IEnumerable<ConfPartModel> GetAllConfPart()
        {
            var confpartList = new List<ConfPartModel>();
            string query = $"SELECT * FROM Conf_participant ORDER BY conf_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var confpartModel = new ConfPartModel();
                        confpartModel.Conf_id = reader[0].ToString();
                        confpartModel.Part_id = Convert.ToInt32(reader[1]);
                        confpartModel.Topic = reader[2].ToString();
                        confpartModel.Notificated = reader[3].ToString();
                        confpartList.Add(confpartModel);
                    }
                }
                connection.Close();
            }
            return confpartList;
        }

        public IEnumerable<ParticipantModel> GetByValueParts(string value)
        {
            var partList = new List<ParticipantModel>();
            int partID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string partSurname = value;
            string partName = value;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText =  @"SELECT * FROM Participants WHERE (participant_id=@id 
                                        OR (participant_surname like @surname 
                                        OR participant_name like @name)) ORDER BY participant_id ASC";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = partID;
                command.Parameters.AddWithValue("@surname", "%" + partSurname + "%");
                command.Parameters.AddWithValue("@name", "%" + partName + "%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var partModel = new ParticipantModel();
                        partModel.Participant_id = Convert.ToInt32(reader[0]);
                        partModel.Participant_surname = reader[1].ToString();
                        partModel.Participant_name = reader[2].ToString();
                        partModel.Participant_email = reader[3].ToString();
                        
                        partList.Add(partModel);
                    }
                }
                connection.Close();
            }
            return partList;
        }
    }
}