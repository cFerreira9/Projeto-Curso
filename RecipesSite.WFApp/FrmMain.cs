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
    public partial class FrmMain : Form
    {
        private FrmUsers users;
        private FrmRecipesList recipesList;
        private FrmManageIngredients manageIngredients;
        private FrmAddIngredients addIngredients;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region Buttons

        private void gerirReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recipesList == null)
            {
                recipesList = new FrmRecipesList();
                recipesList.MdiParent = this;
                recipesList.Dock = DockStyle.Fill;
                recipesList.FormClosed += RecipesList_FormClosed;
                recipesList.Show();
            }
            else
            {
                recipesList.Activate();
            }
        }

        private void RecipesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            recipesList = null;
        }

        private void adicionarIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addIngredients == null)
            {
                addIngredients = new FrmAddIngredients(true);
                addIngredients.MdiParent = this;
                addIngredients.FormClosed += AddIngredients_FormClosed;
                addIngredients.Show();
            }
            else
            {
                addIngredients.Activate();
            }
        }

        private void AddIngredients_FormClosed(object sender, FormClosedEventArgs e)
        {
            addIngredients = null;
        }

        private void gerirIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageIngredients == null)
            {
                manageIngredients = new FrmManageIngredients(true);
                manageIngredients.MdiParent = this;
                manageIngredients.FormClosed += ManageIngredients_FormClosed;
                manageIngredients.Show();
            }
            else
            {
                manageIngredients.Activate();
            }
        }

        private void ManageIngredients_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageIngredients = null;
        }

        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (users == null)
            {
                users = new FrmUsers();
                users.MdiParent = this;
                users.Dock = DockStyle.Fill;
                users.FormClosed += Users_FormClosed;
                users.Show();
            }
            else
            {
                users.Activate();
            }
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExitMessage())
            {
                Application.ExitThread();
            }
        }

        #endregion

        #region Utility

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitMessage())
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private bool ExitMessage()
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                return true;
            return false;
        }

        #endregion

    }
}
