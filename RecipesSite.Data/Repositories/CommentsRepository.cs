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
        public Comments GetCommentByUserID(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spUserComments",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Comments comments = new Comments()
                    {
                        Id = (int)dr["ID"],
                        RecipeId = (int)dr["RecipeId"],
                        Username = (string)dr["Username"],
                        Text = (string)dr["Text"],
                        CreationDate = (DateTime)dr["Date"]
                    };
                    return comments;
                }
            }
            throw new Exception("Não existe nenhum comentário com o user ID: " + id);
        }

        public void Add(Comments comments)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAddComment",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("UserId", comments.UserId);
                cmd.Parameters.AddWithValue("RecipeId", comments.RecipeId);
                cmd.Parameters.AddWithValue("Text", comments.Text);

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
                    throw new Exception("Não foi possível criar um comentário.");
                }
            }
        }

        public void Update(Comments comments)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateComment",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Id", comments.Id);
                cmd.Parameters.AddWithValue("@Text", comments.Text);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar o comentário.");
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spDeleteComment",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum comentário com este ID: " + id);
                }
            }
        }
    }
}
