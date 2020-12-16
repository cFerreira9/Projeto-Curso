using RecipesSite.Data.Repositories;
using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    public class RecipesService
    {
        private RecipesRepository _repo;
        private UserService _Userv;
        private IngredientsService _Ingserv;
        private CategoryService _Catserv;

        public RecipesService()
        {
            _repo = new RecipesRepository();
            _Userv = new UserService();
            _Ingserv = new IngredientsService();
            _Catserv = new CategoryService();
        }

        public List<Recipes> GetAllRecipesList()
        {
            return _repo.GetAllRecipesList();
        }

        public List<Recipes> GetAllInvalidRecipesList()
        {
            return _repo.GetAllInvalidRecipesList();
        }

        public Recipes GetRecipeDetailsById(int id)
        {
            Recipes recipe = _repo.GetRecipeDetailsById(id);
            User user = _Userv.GetUserByRecipeID(id);
            List<Category> categoriesList = _Catserv.GetCategoriesByRecipeID(id);
            List<Ingredients> ingredientsList = _Ingserv.GetIngredientsByRecipesID(id);

            recipe.Username = user.Username;
            recipe.Categories = categoriesList;
            recipe.IngredientsList = ingredientsList;

            return recipe;
        }

        public List<Recipes> GetRecipeCardDetails()
        {
            return _repo.GetRecipeCardDetails();
        }

        public List<Recipes> GetRecipesByCategory(string category)
        {
           return _repo.GetRecipesByCategory(category);
        }

        public List<Recipes> GetAllFavouriteRecipesList(int id)
        {
            return _repo.GetAllFavouriteRecipesList(id);
        }

        public List<Recipes> GetAllOwnedRecipesList(int id)
        {
            return _repo.GetAllOwnedRecipesList(id);
        }

        public void Add(Recipes recipe)
        {
            _repo.Add(recipe);
        }

        public void Update(Recipes recipe)
        {
            _repo.Update(recipe);
        }

        public void UpdateValidStatus(int id, bool valid)
        {
            _repo.UpdateValidStatus(id, valid);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
