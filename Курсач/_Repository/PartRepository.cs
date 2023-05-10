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
                command.CommandText = "INSERT INTO Participants ('participant_surname', 'participant_name', 'participant_email'," +
                    "'topic', 'conf_id') values ('" +
                    partModel.Participant_surname + "' , '" + partModel.Participant_name + "' , '" +
                    partModel.Participant_email + "' , '" + partModel.Topic + "' , '" + partModel.Conf_id+ "')";
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

        public void Edit(ParticipantModel partModel)
        {
            string query = $"UPDATE Participants SET participant_surname='" + partModel.Participant_surname + "', " +
                "participant_name='" + partModel.Participant_name + "', " +
                "participant_email='" + partModel.Participant_email + "', " +
                "topic='" + partModel.Topic + "', " + "conf_id=" + partModel.Conf_id +
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
                        partModel.Topic = reader[4].ToString();
                        partModel.Conf_id = Convert.ToInt32(reader[5]);
                        partList.Add(partModel);
                    }
                }
            }
            return partList;
        }

        public IEnumerable<ParticipantModel> GetByValue(string value)
        {
            var partList = new List<ParticipantModel>();
            int partID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            //string query = $"SELECT * FROM Participants ORDER BY participant_id ASC";

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
                        partModel.Topic = reader[4].ToString();
                        partModel.Conf_id = Convert.ToInt32(reader[5]);
                        partList.Add(partModel);
                    }
                }
            }
            return partList;
        }
    }
}
