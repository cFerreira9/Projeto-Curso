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
    public class IngredientsRepository
    {
        public List<Ingredients> GetAll()
        {
            List<Ingredients> temp = new List<Ingredients>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAllIngredients",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredients ingredients = new Ingredients
                    {
                        Id = (int)dr["Id"],
                        Name = (string)dr["Name"],
                        IsValid = (bool)dr["IsValid"]
                    };

                    temp.Add(ingredients);
                }
            }
            return temp;
        }

        public List<Ingredients> GetAllPendingIngredients()
        {
            List<Ingredients> temp = new List<Ingredients>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spInvalidIngredients",
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredients ingredients = new Ingredients
                    {
                        Name = (string)dr["Name"],
                        IsValid = (bool)dr["IsValid"]
                    };

                    temp.Add(ingredients);
                }
            }

            return temp;
        }

        public List<Ingredients> GetIngredientsByRecipesID(int id)
        {
            List<Ingredients> temp = new List<Ingredients>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spGetAllRecipesIngredients",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("Id", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredients ingredients = new Ingredients()
                    {
                        Id = (int)dr["Id"],
                        Name = (string)dr["Name"],
                        Quantity = (string)dr["IngredientQtn"],
                        IsValid = (bool)dr["IsValid"]
                    };

                    temp.Add(ingredients);
                }
            }

            return temp;
        }

        public void AddByAdmin(Ingredients ingredients)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAddIngredientByAdmin",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Name", ingredients.Name);

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
                    throw new Exception("Não foi possível criar um ingrediente.");
                }
            }
        }

        public void AddByClient(Ingredients ingredients, int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "spAddIngredientByClient",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Name", ingredients.Name);
                cmd.Parameters.AddWithValue("@IngredientQtn", ingredients.Quantity);

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
                    throw new Exception("Não foi possível criar o ingrediente com o ID:" + id);
                }
            }
        }

        public void UpdateByAdmin(Ingredients ingredients)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateIngredient",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ID", ingredients.Id);
                cmd.Parameters.AddWithValue("@Name", ingredients.Name);
                cmd.Parameters.AddWithValue("@IsValid", ingredients.IsValid);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar o ingrediente.");
                }
            }
        }

        public void UpdateByClient(Ingredients ingredients)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CS))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "spUpdateIngredient",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@IngredientQtn", ingredients.Quantity);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não foi possível atualizar o ingrediente.");
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
                    CommandText = "spDeleteIngredient",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int affectedrow = cmd.ExecuteNonQuery();

                if (affectedrow == 0)
                {
                    throw new Exception("Não existe nenhum ingrediente com este ID: " + id);
                }
            }
        }
    }
}
