
namespace MapaSala.Formularios
{
    partial class frmCursoDisciplinacs
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
            this.Disciplinas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtcursodisciplina = new System.Windows.Forms.DataGridView();
            this.cbperiodos = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Periodos = new System.Windows.Forms.Label();
            this.cbDisciplinas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtcursodisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // Disciplinas
            // 
            this.Disciplinas.AutoSize = true;
            this.Disciplinas.Location = new System.Drawing.Point(25, 36);
            this.Disciplinas.Name = "Disciplinas";
            this.Disciplinas.Size = new System.Drawing.Size(57, 13);
            this.Disciplinas.TabIndex = 2;
            this.Disciplinas.Text = "Disciplinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "Desenvolvimento de Sistemas(integrado)",
            "Desenvolvimento de Sistemas(noturno)"});
            this.cbxCursos.Location = new System.Drawing.Point(207, 63);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(121, 21);
            this.cbxCursos.TabIndex = 4;
            this.cbxCursos.SelectedIndexChanged += new System.EventHandler(this.cbxCursos_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(574, 63);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtcursodisciplina
            // 
            this.dtcursodisciplina.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtcursodisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcursodisciplina.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtcursodisciplina.Location = new System.Drawing.Point(28, 159);
            this.dtcursodisciplina.Name = "dtcursodisciplina";
            this.dtcursodisciplina.Size = new System.Drawing.Size(739, 363);
            this.dtcursodisciplina.TabIndex = 6;
            this.dtcursodisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbperiodos
            // 
            this.cbperiodos.FormattingEnabled = true;
            this.cbperiodos.Items.AddRange(new object[] {
            "1º ano",
            "2º ano",
            "3º ano"});
            this.cbperiodos.Location = new System.Drawing.Point(390, 63);
            this.cbperiodos.Name = "cbperiodos";
            this.cbperiodos.Size = new System.Drawing.Size(121, 21);
            this.cbperiodos.TabIndex = 7;
            this.cbperiodos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Periodos
            // 
            this.Periodos.AutoSize = true;
            this.Periodos.Location = new System.Drawing.Point(387, 38);
            this.Periodos.Name = "Periodos";
            this.Periodos.Size = new System.Drawing.Size(48, 13);
            this.Periodos.TabIndex = 8;
            this.Periodos.Text = "Periodos";
            this.Periodos.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbDisciplinas
            // 
            this.cbDisciplinas.FormattingEnabled = true;
            this.cbDisciplinas.Items.AddRange(new object[] {
            "Programação web",
            "Banco de dados",
            "Analise e projeto de sistemas",
            "Design Digital",
            "Tecnicas de programação e algoritmo"});
            this.cbDisciplinas.Location = new System.Drawing.Point(28, 63);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.cbDisciplinas.TabIndex = 9;
            this.cbDisciplinas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(28, 133);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(304, 20);
            this.txtpesquisa.TabIndex = 13;
            // 
            // frmCursoDisciplinacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.cbDisciplinas);
            this.Controls.Add(this.Periodos);
            this.Controls.Add(this.cbperiodos);
            this.Controls.Add(this.dtcursodisciplina);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disciplinas);
            this.Name = "frmCursoDisciplinacs";
            this.Text = "frmCursoDisciplinacs";
            ((System.ComponentModel.ISupportInitialize)(this.dtcursodisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Disciplinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dtcursodisciplina;
        private System.Windows.Forms.ComboBox cbperiodos;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Periodos;
        private System.Windows.Forms.ComboBox cbDisciplinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesquisa;
    }
}