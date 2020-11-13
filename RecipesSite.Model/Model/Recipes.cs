using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Model.Model
{
    public class Recipes
    {
        public int Id { get; set; }

        public bool IsValid { set; get; }

        public string Title { set; get; }

        public User Username { set; get; }

        public ClassificationEnum Classification { get; set; }

        public List<Ingredients> IngredientsList { get; set; }

        public string Description { get; set; }

        public List<Category> Category { get; set; }

        public DifficultyEnum Difficulty { get; set; }

        public TimeSpan Duration { get; set; }

        public List<Comments> Commentaries { get; set; }
    }
}
