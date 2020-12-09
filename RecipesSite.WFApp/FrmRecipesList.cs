using RecipesSite.Model.Model;
using RecipesSite.Model.Model.Utility;
using RecipesSite.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesSite.WFApp
{
    public partial class FrmRecipesList : Form
    {
        private RecipesService _serv;

        public FrmRecipesList()
        {
            InitializeComponent();
            _serv = new RecipesService();
        }

        private void FrmRecipes_Load(object sender, EventArgs e)
        {
            FillGridRecipes();
        }

        #region Buttons

        private void btn_Recipes_Click(object sender, EventArgs e)
        {
            FillGridRecipes();
        }

        private void btn_InvalidRecipes_Click(object sender, EventArgs e)
        {
            FillGridInvalidRecipes();
        }

        private void gridRecipes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmRecipes recipe = new FrmRecipes(Convert.ToInt32(gridRecipes.CurrentRow.Cells["Id"].Value), Convert.ToBoolean(gridRecipes.CurrentRow.Cells["IsValid"].Value));
            recipe.Show();
            recipe.BringToFront();
        }

        #endregion

        #region Utility

        private void FillGridInvalidRecipes()
        {
            DataTable dt = Convert_Lists.ConvertTo<Recipes>(_serv.GetAllInvalidRecipesList());
            gridRecipes.DataSource = dt;
            gridRecipes.Columns["IsValid"].HeaderText = "Válida";
            gridRecipes.Columns["Title"].HeaderText = "Título";
            gridRecipes.Columns["Username"].HeaderText = "Usuário";
            gridRecipes.Columns["Id"].Visible = false;
            gridRecipes.Columns["UserId"].Visible = false;
            gridRecipes.Columns["Classification"].Visible = false;
            gridRecipes.Columns["Description"].Visible = false;
            gridRecipes.Columns["Difficulty"].Visible = false;
            gridRecipes.Columns["Duration"].Visible = false;
        }

        private void FillGridRecipes()
        {
            DataTable dt = Convert_Lists.ConvertTo<Recipes>(_serv.GetAllRecipesList());
            gridRecipes.DataSource = dt;
            gridRecipes.Columns["IsValid"].HeaderText = "Válida";
            gridRecipes.Columns["Title"].HeaderText = "Título";
            gridRecipes.Columns["Username"].HeaderText = "Usuário";
            gridRecipes.Columns["Id"].Visible = false;
            gridRecipes.Columns["UserId"].Visible = false;
            gridRecipes.Columns["Classification"].Visible = false;
            gridRecipes.Columns["Description"].Visible = false;
            gridRecipes.Columns["Difficulty"].Visible = false;
            gridRecipes.Columns["Duration"].Visible = false;

        }

        private void FrmRecipesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende sair da lista de receitas?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
