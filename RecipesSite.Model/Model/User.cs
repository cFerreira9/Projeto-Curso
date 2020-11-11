using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Model.Model
{
    public class User
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsBlocked { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
