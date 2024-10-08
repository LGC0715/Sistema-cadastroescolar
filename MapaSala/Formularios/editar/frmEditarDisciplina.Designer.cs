
namespace MapaSala.Formularios.Editar
{
    partial class frmEditarDisciplina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomedisceditar = new System.Windows.Forms.TextBox();
            this.txtsigladisceditar = new System.Windows.Forms.TextBox();
            this.chkativodisceditar = new System.Windows.Forms.CheckBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.numId = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigla";
            // 
            // txtnomedisceditar
            // 
            this.txtnomedisceditar.Location = new System.Drawing.Point(48, 80);
            this.txtnomedisceditar.Name = "txtnomedisceditar";
            this.txtnomedisceditar.Size = new System.Drawing.Size(154, 20);
            this.txtnomedisceditar.TabIndex = 2;
            // 
            // txtsigladisceditar
            // 
            this.txtsigladisceditar.Location = new System.Drawing.Point(48, 142);
            this.txtsigladisceditar.Name = "txtsigladisceditar";
            this.txtsigladisceditar.Size = new System.Drawing.Size(154, 20);
            this.txtsigladisceditar.TabIndex = 3;
            // 
            // chkativodisceditar
            // 
            this.chkativodisceditar.AutoSize = true;
            this.chkativodisceditar.Location = new System.Drawing.Point(48, 196);
            this.chkativodisceditar.Name = "chkativodisceditar";
            this.chkativodisceditar.Size = new System.Drawing.Size(50, 17);
            this.chkativodisceditar.TabIndex = 4;
            this.chkativodisceditar.Text = "Ativo";
            this.chkativodisceditar.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(48, 239);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(80, 23);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click_1);
            // 
            // numId
            // 
            this.numId.AutoSize = true;
            this.numId.Location = new System.Drawing.Point(45, 34);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(35, 13);
            this.numId.TabIndex = 6;
            this.numId.Text = "label3";
            this.numId.Click += new System.EventHandler(this.numId_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(134, 239);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(80, 23);
            this.btn_Excluir.TabIndex = 7;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click_1);
            // 
            // frmEditarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 306);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.chkativodisceditar);
            this.Controls.Add(this.txtsigladisceditar);
            this.Controls.Add(this.txtnomedisceditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomedisceditar;
        private System.Windows.Forms.TextBox txtsigladisceditar;
        private System.Windows.Forms.CheckBox chkativodisceditar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label numId;
        private System.Windows.Forms.Button btn_Excluir;
    }
}