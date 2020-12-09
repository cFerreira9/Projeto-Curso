using RecipesSite.Model.Model;
using RecipesSite.Model.Model.Utility;
using RecipesSite.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesSite.WFApp
{
    public partial class FrmRecipes : Form
    {
        RecipesService _serv = new RecipesService();
        bool _isValid;
        int _id;

        public FrmRecipes(int id, bool valid)
        {
            InitializeComponent();
            _serv = new RecipesService();
            _id = id;
            _isValid = valid;
        }

        private void FrmRecipes_Load(object sender, EventArgs e)
        {
            RecipesDetails();
        }

        #region Buttons

        private void btn_validate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende validar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                _serv.UpdateValidStatus(_id, !_isValid);
                MessageBox.Show("Validado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }

        #endregion

        #region Utility

        private void RecipesDetails()
        {
            Recipes recipe = _serv.GetRecipeDetailsById(_id);
            if (recipe.Id == _id)
            {
                lbl_title_result.Text = recipe.Title;
                lbl_user_result.Text = recipe.Username;
                lbl_ingredients_result.Text = ConvertObjListToStringByName(recipe.IngredientsList);
                lbl_category_result.Text = ConvertObjListToStringByName(recipe.Categories);
                lbl_classification_result.Text = recipe.Classification.ToString();
                lbl_difficulty_result.Text = recipe.Difficulty.ToString();
                lbl_duration_result.Text = recipe.Duration.ToString();
                lbl_description_result.Text = recipe.Description;
            }
        }

        private string ConvertObjListToStringByName<T>(List<T> objList)
        {
            string result = "";

            foreach (var item in objList)
            {
                Type t = item.GetType();
                PropertyInfo prop = t.GetProperty("Name");

                if (objList.Count == 1)
                {
                    result += prop.GetValue(item, null);
                }
                else
                {
                    result += prop.GetValue(item, null) + ", ";
                }
            }
            return result;
        }

        #endregion

    }
}
