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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spGetAll";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User();

                    user.Username = (string)dr["Username"];
                    user.Account.Email = (string)dr["Email"];
                    user.IsActive = (bool)dr["IsActive"];
                    user.IsBlocked = (bool)dr["IsBlocked"];

                    temp.Add(user);
                }
            }
            return temp;
        }

        public User GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spGetUserByID";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = (int)dr["Id"],
                        Username = (string)dr["Username"],
                        IsActive = (bool)dr["IsActive"],
                        IsBlocked = (bool)dr["IsBlocked"]
                    };
                    return user;
                }
            }
            throw new Exception("Não existe nenhum user com o ID: " + id);
        }

        public void Add(User user)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAddUser",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                SqlParameter outParam = new SqlParameter
                {
                    ParameterName = "@usersIsBlocked",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outParam);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

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
                    $"SET IsActive = @usersIsActive, IsBlocked = @usersIsBlocked";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@usersIsActive", user.IsActive);
                cmd.Parameters.AddWithValue("@usersIsBlocked", user.IsBlocked);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar os dados do user.");
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

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum user com este ID: " + id);
                }
            }
        }
    }
}