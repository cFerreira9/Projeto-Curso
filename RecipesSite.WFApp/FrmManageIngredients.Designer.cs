namespace RecipesSite.WFApp
{
    partial class FrmManageIngredients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddIngredient = new System.Windows.Forms.Button();
            this.gridIngredients = new System.Windows.Forms.DataGridView();
            this.btn_remove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_validate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "-------- Gerir Ingredientes --------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_AddIngredient
            // 
            this.btn_AddIngredient.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_AddIngredient.Location = new System.Drawing.Point(12, 418);
            this.btn_AddIngredient.Name = "btn_AddIngredient";
            this.btn_AddIngredient.Size = new System.Drawing.Size(175, 75);
            this.btn_AddIngredient.TabIndex = 10;
            this.btn_AddIngredient.Text = "Atualizar";
            this.btn_AddIngredient.UseVisualStyleBackColor = true;
            this.btn_AddIngredient.Click += new System.EventHandler(this.btn_UpdateIngredient_Click);
            // 
            // gridIngredients
            // 
            this.gridIngredients.AllowUserToAddRows = false;
            this.gridIngredients.AllowUserToDeleteRows = false;
            this.gridIngredients.AllowUserToResizeColumns = false;
            this.gridIngredients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIngredients.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridIngredients.Location = new System.Drawing.Point(12, 55);
            this.gridIngredients.Name = "gridIngredients";
            this.gridIngredients.ReadOnly = true;
            this.gridIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIngredients.Size = new System.Drawing.Size(776, 274);
            this.gridIngredients.TabIndex = 11;
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_remove.Location = new System.Drawing.Point(613, 418);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(175, 75);
            this.btn_remove.TabIndex = 12;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 13;
            // 
            // btn_validate
            // 
            this.btn_validate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_validate.Location = new System.Drawing.Point(298, 418);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(175, 75);
            this.btn_validate.TabIndex = 14;
            this.btn_validate.Text = "Validar";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // FrmManageIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.gridIngredients);
            this.Controls.Add(this.btn_AddIngredient);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Ingredientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManageIngredients_FormClosing);
            this.Load += new System.EventHandler(this.FrmManageIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddIngredient;
        private System.Windows.Forms.DataGridView gridIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_validate;
    }
}