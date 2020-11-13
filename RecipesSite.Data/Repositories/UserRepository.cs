using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Data.Repositories
{
    public class UserRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
        private static int _colUserId = 0;
        private static int _colUserUsername = 1;
        private static int _colUserPassword = 2;
        private static int _colUserEmail = 3;

        public List<User> GetAll()
        {
            List<User> temp = new List<User>();

            using (SqlConnection conn = new SqlConnection())
            {
                string query = "SELECT * FROM Users";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User();

                    user.Id = dr.GetInt32(_colUserId);
                    user.Username = dr.GetString(_colUserUsername);
                    user.Password = dr.GetString(_colUserPassword);
                    user.Email = dr.GetString(_colUserEmail);

                    temp.Add(user);
                }
            }

            return temp;
        }

        public User GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                string query = $"SELECT * FROM User WHERE UserId = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = dr.GetInt32(_colUserId),
                        Username = dr.GetString(_colUserUsername),
                        Password = dr.GetString(_colUserPassword),
                        Email = dr.GetString(_colUserEmail)
                    };

                    return user;
                }
            }

            throw new Exception("Não existe nenhum user com o ID: " + id);
        }

        public void Add(User user)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                string query = $"INSERT INTO Users " +
                               $"VALUES (@userUsername, @userPassword, @userEmail);" +
                               $"SELECT cast(Scope_Identity() as int);";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter usernameParam = new SqlParameter();
                usernameParam.ParameterName = "@userUsername";
                usernameParam.Value = user.Username;
                usernameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter passwordParam = new SqlParameter();
                passwordParam.ParameterName = "@userPassword";
                passwordParam.Value = user.Password;
                passwordParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter emailParam = new SqlParameter();
                emailParam.ParameterName = "@userEmail";
                emailParam.Value = user.Email;
                emailParam.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(usernameParam);
                cmd.Parameters.Add(passwordParam);
                cmd.Parameters.Add(emailParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                user.Id = id;
            }
        }

        public void Update(User User)
        {

        }

        public void Remove(int id)
        {

        }
    }
}