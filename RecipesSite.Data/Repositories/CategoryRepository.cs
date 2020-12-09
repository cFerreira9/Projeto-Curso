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
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            List<Category> temp = new List<Category>();

            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAllCategories",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category
                    {
                        Name = (string)dr["Name"]
                    };

                    temp.Add(category);
                }
            }
            return temp;
        }

        public Category GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetCategoryByID",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        Id = (int)dr["Id"],
                        Name = (string)dr["Name"]
                    };
                    return category;
                }
            }
            throw new Exception("Não existe nenhuma categoria com o ID: " + id);
        }

        public List<Category> GetCategoriesByRecipeID(int id)
        {
            List<Category> temp = new List<Category>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAllRecipesCategories",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        Id = (int)dr["Id"],
                        Name = (string)dr["Name"]
                    };

                    temp.Add(category);
                }
            }
            return temp;
        }

        public void Add(Category category)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAddCategory",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Name", category.Name);

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
                    throw new Exception("Não foi possível criar uma categoria.");
                }
            }
        }

        public void Update(Category category)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateCategory",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Name", category.Name);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar a categoria.");
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
                    CommandText = "spDeleteCategory",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhuma categoria com este ID: " + id);
                }
            }
        }
    }
}
