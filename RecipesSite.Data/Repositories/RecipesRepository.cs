using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Data.Repositories
{
    public class RecipesRepository
    {
        public List<Recipes> GetAll()
        {
            List<Recipes> temp = new List<Recipes>();

            using (SqlConnection conn = new SqlConnection())
            {
                string query = $"SELECT * FROM Recipe";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipes recipes = new Recipes();

                    recipes.Title = (string)dr["Title"];
                    recipes.IsValid = (bool)dr["IsValid"];
                    recipes.Description = (string)dr["Description"];
                    
                    temp.Add(recipes);
                }
            }
            return temp;
        }

        public Recipes GetById(int id)
        {

        }

        public void Add(Recipes recipe)
        {

        }

        public void Update(Recipes recipe)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
