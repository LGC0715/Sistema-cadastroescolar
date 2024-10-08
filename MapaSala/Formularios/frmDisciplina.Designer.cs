
namespace MapaSala.Formularios
{
    partial class frmDisciplina
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
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd_disc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.AllowUserToAddRows = false;
            this.dtGridDisciplina.AllowUserToDeleteRows = false;
            this.dtGridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridDisciplina.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(15, 100);
            this.dtGridDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.ReadOnly = true;
            this.dtGridDisciplina.RowHeadersWidth = 51;
            this.dtGridDisciplina.Size = new System.Drawing.Size(770, 400);
            this.dtGridDisciplina.TabIndex = 7;
            this.dtGridDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellClick);
            this.dtGridDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellContentClick);
            this.dtGridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellDoubleClick);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(475, 49);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(297, 20);
            this.txtpesquisa.TabIndex = 13;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pesquisar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnadd_disc
            // 
            this.btnadd_disc.Location = new System.Drawing.Point(29, 46);
            this.btnadd_disc.Name = "btnadd_disc";
            this.btnadd_disc.Size = new System.Drawing.Size(168, 23);
            this.btnadd_disc.TabIndex = 15;
            this.btnadd_disc.Text = "Cadastrar Disciplina";
            this.btnadd_disc.UseVisualStyleBackColor = true;
            this.btnadd_disc.Click += new System.EventHandler(this.btnadd_disc_Click);
            // 
            // frmDisciplina
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.btnadd_disc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.dtGridDisciplina);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd_disc;
    }
}