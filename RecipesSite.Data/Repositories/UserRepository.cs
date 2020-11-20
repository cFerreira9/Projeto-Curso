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

        public List<User> GetAll()
        {
            List<User> temp = new List<User>();

            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Users";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User();

                    user.IsActive = (bool)dr["IsActive"];
                    user.IsAdmin = (bool)dr["IsAdmin"];
                    user.IsBlocked = (bool)dr["IsBlocked"];

                    temp.Add(user);
                }
                conn.Close();
            }
            return temp;
        }

        public User GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Users WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = (int)dr["Id"],
                        IsActive = (bool)dr["IsActive"],
                        IsAdmin = (bool)dr["IsAdmin"],
                        IsBlocked = (bool)dr["IsBlocked"]
                    };
                    return user;
                }
                conn.Close();
            }
            throw new Exception("Não existe nenhum user com o ID: " + id);
        }

        public void Add(User user)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"INSERT INTO Users" +
                    $"VALUES (@usersIsActive, @usersIsAdmin, @usersIsBlocked);";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter isactiveParam = new SqlParameter();
                isactiveParam.ParameterName = "@usersIsActive";
                isactiveParam.Value = user.IsActive;            // é um true/false ou assim? que por sua vez são os valores default
                isactiveParam.SqlDbType = SqlDbType.Bit;

                SqlParameter isadminParam = new SqlParameter();
                isadminParam.ParameterName = "@usersIsAdmin";
                isadminParam.Value = user.IsAdmin;
                isadminParam.SqlDbType = SqlDbType.Bit;

                SqlParameter isblockedParam = new SqlParameter();
                isblockedParam.ParameterName = "@usersIsBlocked";
                isblockedParam.Value = user.IsBlocked;
                isblockedParam.SqlDbType = SqlDbType.Bit;

                cmd.Parameters.Add(isactiveParam);
                cmd.Parameters.Add(isadminParam);
                cmd.Parameters.Add(isblockedParam);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível criar um user.");
                }
            }
        }

        public void Update(User user)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"UPDATE Users" +
                    $"SET IsActive = @usersIsActive, IsAdmin = @usersIsAdmin, IsBlocked = @usersIsBlocked";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@usersIsActive", user.IsActive);
                cmd.Parameters.AddWithValue("@usersIsAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@usersIsBlocked", user.IsBlocked);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar os dados do user");
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"DELETE FROM Users WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum user com este ID:" + id);
                }
            }
        }
    }
}