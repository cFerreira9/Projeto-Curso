using RecipesSite.Model.Model;
using RecipesSite.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecipeSite.Site
{
    public partial class Register : Page
    {
        private UserService _serv;

        protected void Page_Load(object sender, EventArgs e)
        {
            _serv = new UserService();
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = CreateUserWizard1.UserName,
                Password = CreateUserWizard1.Password,
                Email = CreateUserWizard1.Email
            };

            _serv.Add(user, CreateUserWizard1.UserName);
        }
    }
}