using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Data.Repositories
{
    public class RecipesRepository
    {
        public List<Recipes> GetAllRecipesList()
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAllRecipesList",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes
                    {
                        Id = (int)dr["Id"],
                        IsValid = (bool)dr["IsValid"],
                        Title = (string)dr["Title"],
                        UserId = (int)dr["UserId"],
                        Username = (string)dr["Username"]
                    };

                    temp.Add(recipes);
                }
            }
            return temp;
        }

        public List<Recipes> GetAllInvalidRecipesList()
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetInvalidRecipesList",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes
                    {
                        Id = (int)dr["Id"],
                        IsValid = (bool)dr["IsValid"],
                        Title = (string)dr["Title"],
                        UserId = (int)dr["UserId"],
                        Username = (string)dr["Username"]
                    };

                    temp.Add(recipes);
                }
            }
            return temp;
        }

        public Recipes GetRecipeDetailsById(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAllRecipeDetails",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes()
                    {
                        Id = (int)dr["Id"],
                        Title = (string)dr["Title"],
                        Classification = (ClassificationEnum)dr["Classification"],
                        Difficulty = (DifficultyEnum)dr["Difficulty"],
                        Duration = (TimeSpan)dr["Duration"],
                        Description = (string)dr["Description"]
                    };

                    return recipes;
                }
            }

            throw new Exception("Não existe nenhuma receita com o ID: " + id);
        }

        public Recipes GetRecipeCardDetails(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetRecipeCardView",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes()
                    {
                        Id = (int)dr["Id"],
                        Picture = (Image)dr["image"],
                        Classification = (ClassificationEnum)dr["Classification"],
                        Difficulty = (DifficultyEnum)dr["Difficulty"]
                    };

                    return recipes;
                }
            }

            throw new Exception("Não existe nenhuma receita com o ID: " + id);
        }

        public void Add(Recipes recipe)
        {
            
        }

        public void Update(Recipes recipe)
        {
            
        }

        public void UpdateValidStatus(int id, bool valid)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spValidateRecipe",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Valid", valid);

                conn.Open();
                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível validar a receita.");
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
                    CommandText = "spDeleteRecipe",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhuma receita com o ID: " + id);
                }
            }
        }

    }
}
