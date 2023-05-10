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
                    "'org_company', 'conf_id') values ('" +
                    orgModel.Org_surname + "' , '" + orgModel.Org_name + "' , '" +
                    orgModel.Org_email + "' , '" + orgModel.Org_company + "' , '" + orgModel.Conf_id + "')";
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
        }

        public void Edit(OrgModel orgModel)
        {
            string query = $"UPDATE Organizers SET org_surname='" + orgModel.Org_surname + "', " +
                "org_name='" + orgModel.Org_name + "', " +
                "org_email='" + orgModel.Org_email + "', " +
                "org_company='" + orgModel.Org_company + "', " + "conf_id=" + orgModel.Conf_id +
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
                        orgModel.Conf_id = Convert.ToInt32(reader[5]);
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
                command.Connection = connection;
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
                        orgModel.Conf_id = Convert.ToInt32(reader[5]);
                        orgList.Add(orgModel);
                    }
                }
            }
            return orgList;
        }
    }
}
