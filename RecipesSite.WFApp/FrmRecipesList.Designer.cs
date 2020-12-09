namespace RecipesSite.WFApp
{
    partial class FrmRecipesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridRecipes = new System.Windows.Forms.DataGridView();
            this.btn_Recipes = new System.Windows.Forms.Button();
            this.btn_InvalidRecipes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1122, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "-------- Lista de Receitas --------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridRecipes
            // 
            this.gridRecipes.AllowUserToAddRows = false;
            this.gridRecipes.AllowUserToDeleteRows = false;
            this.gridRecipes.AllowUserToResizeColumns = false;
            this.gridRecipes.AllowUserToResizeRows = false;
            this.gridRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRecipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridRecipes.Location = new System.Drawing.Point(12, 53);
            this.gridRecipes.Name = "gridRecipes";
            this.gridRecipes.ReadOnly = true;
            this.gridRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRecipes.Size = new System.Drawing.Size(845, 616);
            this.gridRecipes.TabIndex = 8;
            this.gridRecipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRecipes_CellDoubleClick);
            // 
            // btn_Recipes
            // 
            this.btn_Recipes.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recipes.Location = new System.Drawing.Point(898, 175);
            this.btn_Recipes.Name = "btn_Recipes";
            this.btn_Recipes.Size = new System.Drawing.Size(200, 100);
            this.btn_Recipes.TabIndex = 9;
            this.btn_Recipes.Text = "Receitas";
            this.btn_Recipes.UseVisualStyleBackColor = true;
            this.btn_Recipes.Click += new System.EventHandler(this.btn_Recipes_Click);
            // 
            // btn_InvalidRecipes
            // 
            this.btn_InvalidRecipes.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InvalidRecipes.Location = new System.Drawing.Point(898, 459);
            this.btn_InvalidRecipes.Name = "btn_InvalidRecipes";
            this.btn_InvalidRecipes.Size = new System.Drawing.Size(200, 100);
            this.btn_InvalidRecipes.TabIndex = 10;
            this.btn_InvalidRecipes.Text = "Receitas\r\nInvalidas";
            this.btn_InvalidRecipes.UseVisualStyleBackColor = true;
            this.btn_InvalidRecipes.Click += new System.EventHandler(this.btn_InvalidRecipes_Click);
            // 
            // FrmRecipesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 681);
            this.Controls.Add(this.btn_InvalidRecipes);
            this.Controls.Add(this.btn_Recipes);
            this.Controls.Add(this.gridRecipes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmRecipesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRecipesList_FormClosing);
            this.Load += new System.EventHandler(this.FrmRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridRecipes;
        private System.Windows.Forms.Button btn_Recipes;
        private System.Windows.Forms.Button btn_InvalidRecipes;
    }
}