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
    public partial class Default : System.Web.UI.Page
    {
        private RecipesService _serv;


        protected void Page_Load(object sender, EventArgs e)
        {
            _serv = new RecipesService();

            RecipesCardContainer.Controls.Add(new LiteralControl()) ;

            //for (int i = 1; i <= 3; i++)
            //{
            //    var card = FindControl("card" + i);
            //    if (card != null)
            //    {
            //        card =
            //    }
            //}
        }


    }
}