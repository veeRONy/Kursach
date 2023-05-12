using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;

namespace Курсач._Repository
{
    public class OrgRepository : BaseRepository, IOrgRepository
    {
        public OrgRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(OrgModel orgModel)
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

        public void Delete(int id)
        {
            string query = $"DELETE FROM Organizers WHERE org_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }

            var confList = new List<ConfModel>();
            query = $"SELECT * FROM Conferences WHERE conf_organizer_id="+id;
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

            foreach(var confModel in confList)
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

        public void Edit(OrgModel orgModel)
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

        public IEnumerable<OrgModel> GetAll()
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

        public IEnumerable<OrgModel> GetByValue(string value)
        {
            var orgList = new List<OrgModel>();
            int orgID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.CommandText = @"SELECT * FROM Organizers WHERE org_id=@id ORDER BY org_id ASC";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = orgID;

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
    }
}
