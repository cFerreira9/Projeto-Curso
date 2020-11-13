using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Model.Model
{
    public class Comments
    {
        public int Id { get; set; }

        public Recipes Recipe { get; set; }

        public User Username { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
