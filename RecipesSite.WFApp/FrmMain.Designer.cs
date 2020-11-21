namespace RecipesSite.WFApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarIngredienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirComentáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizadoresToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUtilizadoresToolStripMenuItem});
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            // 
            // gerirUtilizadoresToolStripMenuItem
            // 
            this.gerirUtilizadoresToolStripMenuItem.Name = "gerirUtilizadoresToolStripMenuItem";
            this.gerirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerirUtilizadoresToolStripMenuItem.Text = "Gerir Utilizadores";
            this.gerirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.gerirUtilizadoresToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirReceitasToolStripMenuItem,
            this.adicionarIngredienteToolStripMenuItem,
            this.gerirIngredientesToolStripMenuItem,
            this.gerirComentáriosToolStripMenuItem});
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.receitasToolStripMenuItem.Text = "Receitas";
            // 
            // gerirReceitasToolStripMenuItem
            // 
            this.gerirReceitasToolStripMenuItem.Name = "gerirReceitasToolStripMenuItem";
            this.gerirReceitasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gerirReceitasToolStripMenuItem.Text = "Gerir Receitas";
            this.gerirReceitasToolStripMenuItem.Click += new System.EventHandler(this.gerirReceitasToolStripMenuItem_Click);
            // 
            // adicionarIngredienteToolStripMenuItem
            // 
            this.adicionarIngredienteToolStripMenuItem.Name = "adicionarIngredienteToolStripMenuItem";
            this.adicionarIngredienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.adicionarIngredienteToolStripMenuItem.Text = "Adicionar Ingrediente";
            this.adicionarIngredienteToolStripMenuItem.Click += new System.EventHandler(this.adicionarIngredienteToolStripMenuItem_Click);
            // 
            // gerirIngredientesToolStripMenuItem
            // 
            this.gerirIngredientesToolStripMenuItem.Name = "gerirIngredientesToolStripMenuItem";
            this.gerirIngredientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gerirIngredientesToolStripMenuItem.Text = "Gerir Ingredientes";
            this.gerirIngredientesToolStripMenuItem.Click += new System.EventHandler(this.gerirIngredientesToolStripMenuItem_Click);
            // 
            // gerirComentáriosToolStripMenuItem
            // 
            this.gerirComentáriosToolStripMenuItem.Name = "gerirComentáriosToolStripMenuItem";
            this.gerirComentáriosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gerirComentáriosToolStripMenuItem.Text = "Gerir Comentários";
            this.gerirComentáriosToolStripMenuItem.Click += new System.EventHandler(this.gerirComentáriosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1083, 817);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarIngredienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirIngredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirComentáriosToolStripMenuItem;
    }
}

