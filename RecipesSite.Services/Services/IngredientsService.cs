using RecipesSite.Data.Repositories;
using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    public class IngredientsService
    {
        private IngredientsRepository _repo;

        public IngredientsService()
        {
            _repo = new IngredientsRepository();
        }

        public List<Ingredients> GetAll()
        {
            return _repo.GetAll();
        }

        public List<Ingredients> GetAllPendingIngredients()
        {
            return _repo.GetAllPendingIngredients();
        }

        public List<Ingredients> GetIngredientsByRecipesID(int id)
        {
            return _repo.GetIngredientsByRecipesID(id);
        }

        public void AddByAdmin(Ingredients ingredient)
        {
            _repo.AddByAdmin(ingredient);
        }

        public void AddByClient(Ingredients ingredient, int id)
        {
            _repo.AddByClient(ingredient, id);
        }

        public void UpdateByAdmin(Ingredients ingredient)
        {
            _repo.UpdateByAdmin(ingredient);
        }

        public void UpadteByClient(Ingredients ingredients)
        {
            _repo.UpdateByClient(ingredients);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
