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
        private bool closeSentinel = false;
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmRecipes R;
        FrmAddIngredients I;
        FrmManageIngredients Mi;
        FrmManageComments Mc;
        FrmUsers U;

        #region Consultar

        private void gerirReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRecipes>().Count() == 0)
                R = new FrmRecipes();
            R.MdiParent = this;
            R.WindowState = FormWindowState.Maximized;
            R.Show();
            R.BringToFront();
        }

        private void adicionarIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAddIngredients>().Count() == 0)
                I = new FrmAddIngredients();
            I.MdiParent = this;
            I.WindowState = FormWindowState.Maximized;
            I.Show();
            I.BringToFront();
        }

        private void gerirIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmManageIngredients>().Count() == 0)
                Mi = new FrmManageIngredients();
            Mi.MdiParent = this;
            Mi.WindowState = FormWindowState.Maximized;
            Mi.Show();
            Mi.BringToFront();
        }
        private void gerirComentáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmManageComments>().Count() == 0)
                Mc = new FrmManageComments();
            Mc.MdiParent = this;
            Mc.WindowState = FormWindowState.Maximized;
            Mc.Show();
            Mc.BringToFront();
        }

        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUsers>().Count() == 0)
                U = new FrmUsers();
            U.MdiParent = this;
            U.WindowState = FormWindowState.Maximized;
            U.Show();
            U.BringToFront();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExitMessage())
            {
                closeSentinel = true;
                Application.Exit();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!closeSentinel)
            {
                if (ExitMessage())
                {
                    Dispose(true);
                    Application.Exit();
                }
                e.Cancel = true;
            }
        }
        private bool ExitMessage()
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                return true;
            return false;
        }
        #endregion
    }
}
