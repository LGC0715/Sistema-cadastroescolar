
namespace MapaSala.Formularios
{
    partial class frmUsuarios
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgridUsuarios1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar1 = new System.Windows.Forms.TextBox();
            this.btnNovo1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUsuarios1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgridUsuarios1
            // 
            this.dtgridUsuarios1.AllowUserToAddRows = false;
            this.dtgridUsuarios1.AllowUserToDeleteRows = false;
            this.dtgridUsuarios1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridUsuarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridUsuarios1.Location = new System.Drawing.Point(22, 74);
            this.dtgridUsuarios1.Name = "dtgridUsuarios1";
            this.dtgridUsuarios1.ReadOnly = true;
            this.dtgridUsuarios1.Size = new System.Drawing.Size(756, 364);
            this.dtgridUsuarios1.TabIndex = 3;
            this.dtgridUsuarios1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridUsuarios1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPesquisar1);
            this.groupBox1.Controls.Add(this.btnNovo1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar1
            // 
            this.txtPesquisar1.Location = new System.Drawing.Point(186, 19);
            this.txtPesquisar1.Name = "txtPesquisar1";
            this.txtPesquisar1.Size = new System.Drawing.Size(478, 20);
            this.txtPesquisar1.TabIndex = 1;
            this.txtPesquisar1.TextChanged += new System.EventHandler(this.txtPesquisar1_TextChanged_1);
            // 
            // btnNovo1
            // 
            this.btnNovo1.Location = new System.Drawing.Point(6, 19);
            this.btnNovo1.Name = "btnNovo1";
            this.btnNovo1.Size = new System.Drawing.Size(107, 23);
            this.btnNovo1.TabIndex = 0;
            this.btnNovo1.Text = "Novo Usuário";
            this.btnNovo1.UseVisualStyleBackColor = true;
            this.btnNovo1.Click += new System.EventHandler(this.btnNovo1_Click_1);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgridUsuarios1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUsuarios1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgridUsuarios1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar1;
        private System.Windows.Forms.Button btnNovo1;
    }
}