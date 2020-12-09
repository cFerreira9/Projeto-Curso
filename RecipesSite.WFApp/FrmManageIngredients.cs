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
    public partial class FrmManageIngredients : Form
    {
        IngredientsService _serv;
        private Ingredients ingredient = new Ingredients();
        private bool _add;

        public FrmManageIngredients(bool add)
        {
            InitializeComponent();
            _serv = new IngredientsService();
            _add = add;
        }

        private void FrmManageIngredients_Load(object sender, EventArgs e)
        {
            FillGridIngredients();
        }

        #region Buttons

        private void FillGridIngredients()
        {
            DataTable dt = Convert_Lists.ConvertTo<Ingredients>(_serv.GetAll());
            gridIngredients.DataSource = dt;
            gridIngredients.Columns["Id"].Visible = false;
            gridIngredients.Columns["Quantity"].Visible = false;
            gridIngredients.Columns["Name"].HeaderText = "Nome";
            gridIngredients.Columns["IsValid"].HeaderText = "Valido";
            gridIngredients.Columns["Quantity"].HeaderText = "Quantidade";
        }

        private void btn_UpdateIngredient_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende atualizar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int id;
                int.TryParse(gridIngredients.CurrentRow.Cells["Id"].Value.ToString(), out id);
                bool valid;
                bool.TryParse(gridIngredients.CurrentRow.Cells["IsValid"].Value.ToString(), out valid);

                ingredient.Name = textBox1.Text;
                ingredient.Id = id;
                ingredient.IsValid = valid;

                if (_add)
                {
                    _serv.UpdateByAdmin(ingredient);
                    MessageBox.Show("Atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBox1.Text = "";

                FillGridIngredients();
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende validar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int id;
                int.TryParse(gridIngredients.CurrentRow.Cells["Id"].Value.ToString(), out id);
                string name = gridIngredients.CurrentRow.Cells["Name"].Value.ToString();
                bool valid;
                bool.TryParse(gridIngredients.CurrentRow.Cells["IsValid"].Value.ToString(), out valid);

                ingredient.Id = id;
                ingredient.Name = name;
                ingredient.IsValid = !valid;

                if (_add)
                {
                    _serv.UpdateByAdmin(ingredient);
                    MessageBox.Show("Validado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FillGridIngredients();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende remover?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (_add)
                {
                    int id;
                    int.TryParse(gridIngredients.CurrentRow.Cells["Id"].Value.ToString(), out id);
                    _serv.Remove(id);
                    MessageBox.Show("Removido com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FillGridIngredients();
            }
        }

        #endregion

        #region Utility

        private void FrmManageIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende sair dos ingredientes?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

    }
}
