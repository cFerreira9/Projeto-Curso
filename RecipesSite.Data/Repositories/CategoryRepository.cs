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
                string query = $"SELECT * FROM Categories";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category();

                    category.CategoryName = (string)dr["Name"];

                    temp.Add(category);
                }
            }
            return temp;
        }

        public Category GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Categories WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        Id = (int)dr["Id"],
                        CategoryName = (string)dr["Name"]
                    };
                    return category;
                }
            }
            throw new Exception("Não existe nenhuma categoria com o ID: " + id);
        }

        public void Add(Category category)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"INSERT INTO Categories" +
                    $"VALUES (@categoriesName)";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@categoriesName";
                nameParam.Value = category.CategoryName;
                nameParam.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(nameParam);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível adicionar a categoria.");
                }
            }
        }

        public void Update(Category category)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"UPDATE Categories" +
                    $"SET Name = @categoriesName";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@categoriesName", category.CategoryName);

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
                string query = $"DELETE FROM Categories WHERE Id = {id}";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum comentário com o ID: " + id);
                }
            }
        }
    }
}
