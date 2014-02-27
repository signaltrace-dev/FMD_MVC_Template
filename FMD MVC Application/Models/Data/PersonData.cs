using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using FMD.Data.Oracle;

namespace $safeprojectname$.Models.Data
{
    public class PersonData : BaseData
    {
        public PersonData() : base() { }

        public Person GetPerson(string userId) {
            Person p = new Person();

            OracleCommand command = UserDB.connection.CreateCommand();
            command.CommandText = "SELECT first_name, last_name, myid, home_department, email, campus_phone " +
                "FROM dev.uga_employees " +
                "WHERE can = :userId";
            command.Parameters.Add(":userId", userId);

            command.Connection.Open();

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                p.Dept = reader["home_department"].ToString();
                p.Email = reader["email"].ToString();
                p.FirstName = reader["first_name"].ToString();
                p.ID = userId;
                p.LastName = reader["last_name"].ToString();
                p.Phone = reader["campus_phone"].ToString();
                p.Username = reader["myid"].ToString();
            }

            command.Connection.Close();

            return p;
        }
    }
}