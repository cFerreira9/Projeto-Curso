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

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAll",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = (int)dr["Id"],
                        Username = (string)dr["Username"],
                        Email = (string)dr["Email"],
                        IsActive = (bool)dr["IsActive"],
                        IsBlocked = (bool)dr["IsBlocked"]
                    };
                    temp.Add(user);
                }
            }
            return temp;
        }

        public User GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetUserByID",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = (int)dr["Id"],
                        Username = (string)dr["Username"],
                        Email = (string)dr["Email"],
                        IsActive = (bool)dr["IsActive"],
                        IsBlocked = (bool)dr["IsBlocked"]
                    };
                    return user;
                }
            }
            throw new Exception("Não existe nenhum user com o ID: " + id);
        }

        public User GetUserByRecipeID(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetRecipeUser",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = (int)dr["Id"],
                        Username = (string)dr["Username"]
                    };
                    return user;
                }
            }
            throw new Exception("Não existe nenhuma receita com o ID: " + id);
        }

        public void Add(User user)
        {

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
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
                cmd.Parameters.AddWithValue("@MembershipUsername", user.MemberShipUsername);

                SqlParameter outParam = new SqlParameter
                {
                    ParameterName = "@Id",
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

        public void UpdateByAdmin(User user)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateUser",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar os dados do user.");
                }
            }
        }

        public void UpdateByClient(User user)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateUserClient",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar os seus dados.");
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spDeleteUser",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("ID", id);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum user com este ID: " + id);
                }
            }
        }

        public List<User> BlockedUsers()
        {
            List<User> temp = new List<User>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spBlockedUsers",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User
                    {
                        Id = (int)dr["Id"],
                        Username = (string)dr["Username"],
                        Email = (string)dr["Email"],
                        IsActive = (bool)dr["IsActive"],
                        IsBlocked = (bool)dr["IsBlocked"]
                    };

                    temp.Add(user);
                }
            }
            return temp;
        }

        public void BlockUnBlockUser(int id, bool block)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spBlockUnblockUser",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@IsBlocked", block);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar os dados do user.");
                }
            }
        }
    }
}