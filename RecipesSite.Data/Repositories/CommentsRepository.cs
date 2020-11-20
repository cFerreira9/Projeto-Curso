using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Data.Repositories
{
    public class CommentsRepository
    {
        public List<Comments> GetAll()
        {
            List<Comments> temp = new List<Comments>();

            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Comments";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Comments comments = new Comments();

                    comments.Text = (string)dr["Text"];
                    comments.CreationDate = (DateTime)dr["Date"];

                    temp.Add(comments);
                }
                conn.Close();
            }
            return temp;
        }

        public Comments GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Comments WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Comments comments = new Comments()
                    {
                        Id = (int)dr["Id"],
                        Text = (string)dr["Text"],
                        CreationDate = (DateTime)dr["Date"],
                    };
                    return comments;
                }
                conn.Close();
            }
            throw new Exception("Não existe nenhum comentário com o ID:" + id);
        }

        public void Add(Comments comments)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"INSERT INTO Comments" +
                    $"VALUES (@commentsText, @commentsDate)";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter textParam = new SqlParameter();
                textParam.ParameterName = "@commentsText";
                textParam.Value = comments.Text;
                textParam.SqlDbType = SqlDbType.Text;

                SqlParameter dateParam = new SqlParameter();
                dateParam.ParameterName = "@commentsDate";
                dateParam.Value = comments.CreationDate;
                dateParam.SqlDbType = SqlDbType.DateTime;

                cmd.Parameters.Add(textParam);
                cmd.Parameters.Add(dateParam);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível criar um comentário.");
                }
            }
        }

        public void Update(Comments comments)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"UPDATE Comments" +
                    $"SET Text = @commentsText";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@commentsText", comments.Text);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar o comentário");
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"DELETE FROM Comments WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                conn.Close();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum comentário com o ID:" + id);
                }
            }
        }
    }
}
