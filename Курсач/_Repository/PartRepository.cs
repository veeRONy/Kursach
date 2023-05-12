using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;

namespace Курсач._Repository
{
    public class PartRepository : BaseRepository, IPartRepository
    {
        public PartRepository(string connectionString)
        {
            this.connectionString = connectionString;
            
        }

        
        public void Add(ParticipantModel partModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = "INSERT INTO Participants ('participant_surname', 'participant_name', 'participant_email')" +
                    " values ('" +
                    partModel.Participant_surname + "' , '" + partModel.Participant_name + "' , '" +
                    partModel.Participant_email +   "')";
                //command.ExecuteNonQuery();
                command.ExecuteScalar();
                
            } 
        }

        public void AddReg(Conf_Part_Model confpartModel)
        {

                using (var connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO Conf_participant ('conf_id', 'participant_id', 'topic')" +
                        " values ('" +
                        confpartModel.Conf_id + "' , '" + confpartModel.Part_id + "' , '" +
                        confpartModel.Topic + "')";
                    //command.ExecuteNonQuery();
                    command.CommandText = @"INSERT INTO Conf_participant ('conf_id', 'participant_id', 'topic')" +
                        " values (@conf_id, @part_id, @topic)";
                    command.Parameters.Add("@conf_id", System.Data.DbType.Int32).Value = Convert.ToInt32(confpartModel.Conf_id);
                    command.Parameters.Add("@part_id", System.Data.DbType.Int32).Value = confpartModel.Part_id;
                    command.Parameters.Add("@topic", System.Data.DbType.String).Value = confpartModel.Topic;
                    command.ExecuteScalar();

                }


                var confModel = new ConfModel();
                confModel.Curr_num_of_participants = GetCurrNum(Convert.ToInt32(confpartModel.Conf_id));
                confModel.Curr_num_of_participants++;

                string query = $"UPDATE Conferences SET curr_num_of_participants=" + confModel.Curr_num_of_participants + " WHERE conf_id=" + confpartModel.Conf_id;
                using (var connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }  
            
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM Participants WHERE participant_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void DeleteReg(int part_id, int conf_id, string topic)
        {
            Console.WriteLine(conf_id);
            int count = 0;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"DELETE FROM Conf_participant WHERE ((conf_id=@conf_id AND participant_id=@part_id) AND topic=@topic)";
                command.Parameters.Add("@conf_id", System.Data.DbType.Int32).Value = conf_id;
                command.Parameters.Add("@part_id", System.Data.DbType.Int32).Value = part_id;
                command.Parameters.Add("@topic", System.Data.DbType.String).Value = topic;

                count=command.ExecuteNonQuery();
            }

            var confModel = new ConfModel();
            confModel.Curr_num_of_participants = GetCurrNum(conf_id);
            confModel.Curr_num_of_participants-=count;

            //string query = $"UPDATE Conferences SET curr_num_of_participants=" + confModel.Curr_num_of_participants + " WHERE conf_id=" + conf_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"UPDATE Conferences SET curr_num_of_participants=@curr WHERE conf_id=@conf_id";
                
                command.Parameters.Add("@conf_id", System.Data.DbType.Int32).Value = conf_id;
                command.Parameters.Add("@curr", System.Data.DbType.Int32).Value = confModel.Curr_num_of_participants;
                command.ExecuteNonQuery();
            }
        }

        private int GetCurrNum(int conf_id)
        {
            var confModel = new ConfModel();
            confModel.Conf_id = conf_id;
            string query = $"SELECT * FROM Conferences WHERE conf_id=" + confModel.Conf_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        confModel.Curr_num_of_participants = Convert.ToInt32(reader[5]);
                    }
                }
            }
            return confModel.Curr_num_of_participants;
        }

        public void Edit(ParticipantModel partModel)
        {
            string query = $"UPDATE Participants SET participant_surname='" + partModel.Participant_surname + "', " +
                "participant_name='" + partModel.Participant_name + "', " +
                "participant_email='" + partModel.Participant_email + "' " +               
                " WHERE participant_id=" + partModel.Participant_id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ParticipantModel> GetAll()
        {
            var partList = new List<ParticipantModel>();

            string query = $"SELECT * FROM Participants ORDER BY participant_id ASC";

            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();

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
            return partList;
        }

        public IEnumerable<Conf_Part_Model> GetAllConfPart()
        {
            var confpartList = new List<Conf_Part_Model>();

            string query = $"SELECT * FROM Conf_participant ORDER BY conf_id ASC";

            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var confpartModel = new Conf_Part_Model();
                        confpartModel.Conf_id = reader[0].ToString();
                        confpartModel.Part_id = Convert.ToInt32(reader[1]);
                        confpartModel.Topic = reader[2].ToString();

                        confpartList.Add(confpartModel);
                    }
                }
            }
            return confpartList;
        }

        public IEnumerable<ParticipantModel> GetByValue(string value)
        {
            var partList = new List<ParticipantModel>();
            int partID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;


            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM Participants WHERE participant_id=@id ORDER BY participant_id ASC";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = partID;

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
            return partList;
        }
    }
}
