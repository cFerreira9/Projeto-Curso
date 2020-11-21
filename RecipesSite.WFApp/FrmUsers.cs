using RecipesSite.Model.Model;
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
    public partial class FrmUsers : Form
    {
        private UserService _serv;

        public FrmUsers()
        {
            InitializeComponent();

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(spGetAll.CurrentRow.Cells["ID"].Value.ToString(), out id);
                _serv.Remove(id);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            FillGrid();
        }


        private void FillGrid()
        {
            spGetAll.DataSource = _serv.GetAll();
            VisualAspectGrid();
        }

        private void VisualAspectGrid()
        {
            if (spGetAll.Rows.Count > 0)
            {
                spGetAll.Columns["ID"].Visible = false;
                spGetAll.Columns["Username"].Width = 190;
                spGetAll.Columns["Username"].HeaderText = "Utilizador";
                spGetAll.Columns["IsActive"].Width = 190;
                spGetAll.Columns["IsActive"].HeaderText = "Ativo Status";
                spGetAll.Columns["IsBlocked"].Width = 190;
                spGetAll.Columns["IsBlocked"].HeaderText = "Bloqueio Status";
            }
        }
    }
}
