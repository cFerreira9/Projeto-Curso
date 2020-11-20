using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Data.Repositories
{
    public class AccountRepository
    {
        public List<Account> GetAll()
        {
            List<Account> temp = new List<Account>();

            using(SqlConnection conn = new SqlConnection())
            {
                string query = "SELECT * FROM Account";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Account account = new Account();

                    account.Username = (string)dr["Username"];
                    account.Password = (string)dr["Password"];
                    account.Email = (string)dr["Email"];

                    temp.Add(account);
                }
                conn.Close();
            }
            return temp;
        }

        public Account GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Account WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Account account = new Account()
                    {
                        Id = (int)dr["Id"],
                        Username = (string)dr["Username"],
                        Password = (string)dr["Password"],
                        Email = (string)dr["Email"]
                    };
                    return account;
                }
                conn.Close();
            }
            throw new Exception("Não existe nenhuma conta com o ID:" + id);
        }

        public void Add(Account account)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"INSERT INTO Account" +
                    $"VALUES (@accountUsername, @accountPassword, @accountEmail);";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter usernameParam = new SqlParameter();
                usernameParam.ParameterName = "@accountUsername";
                usernameParam.Value = account.Username;
                usernameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter passwordParam = new SqlParameter();
                passwordParam.ParameterName = "@accountPassword";
                passwordParam.Value = account.Password;
                passwordParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter emailParam = new SqlParameter();
                emailParam.ParameterName = "@accountEmail";
                emailParam.Value = account.Email;
                emailParam.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(usernameParam);
                cmd.Parameters.Add(passwordParam);
                cmd.Parameters.Add(emailParam);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível criar conta.");
                }
            }
        }

        public void Update(Account account)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"UPDATE Account" +
                    $"SET Username = @accountUsername, Password = @accountPassword, Email = @accountEmail";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@accountUsername", account.Username);
                cmd.Parameters.AddWithValue("@accountPassword", account.Password);
                cmd.Parameters.AddWithValue("@accountEmail", account.Email);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar os dados da conta");
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"DELETE FROM Account WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhuma conta com o ID:" + id);
                }
            }
        }
    }
}
