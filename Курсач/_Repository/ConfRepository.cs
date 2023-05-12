using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;
using Курсач.Views;
using Курсач.Presenters;
using Курсач._Repository;
using System.Configuration;
using System.Collections;
using System.Data.SQLite;


namespace Курсач._Repository
{
    public class ConfRepository : BaseRepository, IConfRepository
    {
        public ConfRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ConfModel confModel)
        {
            confModel.Curr_num_of_participants = 0;
            //string query = $"INSERT INTO Conferences('conf_topic', 'conf_organizer_id', 'conf_date', " +
            //        "'conf_time', 'conf_address', 'curr_num_of_participants', 'max_num_of_participants') values ('" +
            //        confModel.Conf_topic + "' , '" + confModel.Conf_organizer_id + "' , '" +
            //        confModel.Conf_date + "' , '" + confModel.Conf_time + "' , '" +
            //        confModel.Conf_address + "' , '" +
            //        confModel.Curr_num_of_participants + "' , '" +
            //        confModel.Max_num_of_participants + "')";

            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
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
            
        }

        

        public void Delete(int id)
        {
            //ring query = $"DELETE FROM Conferences WHERE conf_id="+id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"DELETE FROM Conferences WHERE conf_id=@id";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value=id;
                command.ExecuteNonQuery();
            }

            string query = $"DELETE FROM Conf_participant WHERE conf_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                
            }
        }

        public void Edit(ConfModel confModel)
        {
            string query = $"UPDATE Conferences SET conf_topic='" + confModel.Conf_topic + "', " +
                "conf_organizer_id=" + confModel.Conf_organizer_id + ", " +
                "conf_date='" + confModel.Conf_date + "', " +
                "conf_time='" + confModel.Conf_time + "', " +
                "conf_address='" + confModel.Conf_address + "', " +
                "max_num_of_participants=" + confModel.Max_num_of_participants + " WHERE conf_id=" + confModel.Conf_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        

        public IEnumerable<ConfModel> GetAll()
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

        public IEnumerable<ConfModel> GetByValue(string value)
        {
            var confList = new List<ConfModel>();
            int confID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM Conferences WHERE conf_id=@id ORDER BY conf_id DESC";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = confID;

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
                        confList.Add(confModel);
                    }
                }
            }
            return confList;
        }
    }
}
