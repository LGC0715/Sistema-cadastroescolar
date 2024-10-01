
namespace MapaSala.Formularios.editar
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
            this.editardisc = new System.Windows.Forms.Button();
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
            // editardisc
            // 
            this.editardisc.Location = new System.Drawing.Point(48, 239);
            this.editardisc.Name = "editardisc";
            this.editardisc.Size = new System.Drawing.Size(154, 23);
            this.editardisc.TabIndex = 5;
            this.editardisc.Text = "Editar";
            this.editardisc.UseVisualStyleBackColor = true;
            // 
            // frmEditarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editardisc);
            this.Controls.Add(this.chkativodisceditar);
            this.Controls.Add(this.txtsigladisceditar);
            this.Controls.Add(this.txtnomedisceditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditarDisciplina";
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
        private System.Windows.Forms.Button editardisc;
    }
}