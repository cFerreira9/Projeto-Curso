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

        public List<Recipes> GetRecipeCardDetails()
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetRecipeCardView",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes()
                    {
                        Id = (int)dr["Id"],
                        Picture = (Image)dr["image"],
                        Title = (string)dr["Title"],
                        Username = (string)dr["Username"],
                        Classification = (ClassificationEnum)dr["Classification"],
                        Difficulty = (DifficultyEnum)dr["Difficulty"]
                    };

                    temp.Add(recipes);
                }
            }

            return temp;
        }

        // Vai buscar as receitas quando se clica no "CARNES"

        public List<Recipes> GetRecipesByCategory(string category)
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAllRecipesByCategory",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Category", category);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes()
                    {
                        Id = (int)dr["Id"],
                        Picture = (Image)dr["image"],
                        Title = (string)dr["Title"],
                        Description = (string)dr["Description"]
                    };

                    temp.Add(recipes);
                }
            }

            return temp;
        }

        public List<Recipes> GetAllFavouriteRecipesList(int id)
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spFavouriteRecipes",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes
                    {
                        Id = (int)dr["Id"],
                        Picture = (Image)dr["image"],
                        Title = (string)dr["Title"],
                        Username = (string)dr["Username"],
                        Classification = (ClassificationEnum)dr["Classification"],
                        Difficulty = (DifficultyEnum)dr["Difficulty"]
                    };

                    temp.Add(recipes);
                }
            }
            return temp;
        }

        public List<Recipes> GetAllOwnedRecipesList(int id)
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spFavouriteRecipes",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes
                    {
                        Id = (int)dr["Id"],
                        Picture = (Image)dr["image"],
                        Title = (string)dr["Title"],
                        Username = (string)dr["Username"],
                        Classification = (ClassificationEnum)dr["Classification"],
                        Difficulty = (DifficultyEnum)dr["Difficulty"]
                    };

                    temp.Add(recipes);
                }
            }
            return temp;
        }

        public void Add(Recipes recipe)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAddRecipe",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("image", recipe.Picture);
                cmd.Parameters.AddWithValue("Title", recipe.Title);
                cmd.Parameters.AddWithValue("UserId", recipe.UserId);
                cmd.Parameters.AddWithValue("Duration", recipe.Duration);
                cmd.Parameters.AddWithValue("Classification", recipe.Classification);
                cmd.Parameters.AddWithValue("Difficulty", recipe.Difficulty);
                cmd.Parameters.AddWithValue("Description", recipe.Description);

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
                    throw new Exception("Não foi possível criar uma receita.");
                }
            }
        }

        public void Update(Recipes recipe)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateRecipe",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", recipe.Id);
                cmd.Parameters.AddWithValue("image", recipe.Picture);
                cmd.Parameters.AddWithValue("Title", recipe.Title);
                cmd.Parameters.AddWithValue("Duration", recipe.Duration);
                cmd.Parameters.AddWithValue("Classification", recipe.Classification);
                cmd.Parameters.AddWithValue("Difficulty", recipe.Difficulty);
                cmd.Parameters.AddWithValue("Description", recipe.Description);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar a receita.");
                }
            }
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

                cmd.Parameters.AddWithValue("@Id", id);

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
