using RecipesSite.Model;
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
    public partial class FrmAddIngredients : Form
    {
        private IngredientsService _serv;
        private Ingredients ingredient = new Ingredients();
        private bool _add;

        public FrmAddIngredients(bool add)
        {
            InitializeComponent();
            _serv = new IngredientsService();
            _add = add;
        }

        private void FrmAddIngredients_Load(object sender, EventArgs e)
        {
            FillGridIngredients();
        }

        #region Buttons

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende inserir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ingredient.Name = textBox1.Text;

                if (_add)
                {
                    _serv.AddByAdmin(ingredient);
                    MessageBox.Show("Inserido com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBox1.Text = "";

                FillGridIngredients();
            }
        }

        #endregion

        #region Utility

        private void FillGridIngredients()
        {
            DataTable dt = Convert_Lists.ConvertTo<Ingredients>(_serv.GetAll());
            gridIngredients.DataSource = dt;
            gridIngredients.Columns["Id"].Visible = false;
            gridIngredients.Columns["Name"].HeaderText = "Nome";
            gridIngredients.Columns["IsValid"].HeaderText = "Valido";
            gridIngredients.Columns["Quantity"].Visible = false;
        }



        #endregion

        private void FrmAddIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende sair dos ingredientes?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
