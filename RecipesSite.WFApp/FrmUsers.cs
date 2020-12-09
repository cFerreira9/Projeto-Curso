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
    public partial class FrmUsers : Form
    {
        private UserService _serv;
        private bool _add;

        public FrmUsers()
        {
            InitializeComponent();
            _serv = new UserService();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            FillGridUsers();
        }

        #region Buttons

        private void btn_Users_Click(object sender, EventArgs e)
        {
            FillGridUsers();
        }

        private void btn_BlockedUsers_Click(object sender, EventArgs e)
        {
            FillGridBlockedUsers();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(gridUsers.CurrentRow.Cells["Id"].Value.ToString(), out id);
            _serv.BlockUnblockUser(id, true);
            MessageBox.Show("O utilizador foi bloqueado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGridUsers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende remover?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (_add)
                {
                    int id;
                    int.TryParse(gridUsers.CurrentRow.Cells["Id"].Value.ToString(), out id);
                    _serv.Remove(id);
                    MessageBox.Show("Removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FillGridUsers();
            }
        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(gridUsers.CurrentRow.Cells["Id"].Value.ToString(), out id);
            _serv.BlockUnblockUser(id, false);
            MessageBox.Show("O utilizador foi desbloqueado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGridBlockedUsers();
        }

        #endregion

        #region Utility
        private void FillGridBlockedUsers()
        {
            DataTable dt = Convert_Lists.ConvertTo<User>(_serv.BlockedUsers());
            gridUsers.DataSource = dt;
        }

        private void FillGridUsers()
        {
            DataTable dt = Convert_Lists.ConvertTo<User>(_serv.GetAll());
            gridUsers.DataSource = dt;
            gridUsers.Columns["Password"].Visible = false;
            gridUsers.Columns["Id"].Visible = false;
            gridUsers.Columns["Username"].HeaderText = "Usuário";
            gridUsers.Columns["IsActive"].HeaderText = "Ativo";
            gridUsers.Columns["IsBlocked"].HeaderText = "Bloqueado";
        }

        private void FrmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza que pretende sair dos utilizadores?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
