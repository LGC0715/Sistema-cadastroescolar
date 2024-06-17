using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmSalas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Matematica", "MAT");
            dados.Rows.Add(2, "Português", "PORT");
            dados.Rows.Add(3, "Física", "FIS");

            dtGridSalas.DataSource = dados;
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidade d = new SalasEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNome.Text;
            

            dados.Rows.Add(d.Linha());
            LimparCampos();
        }
        private void LimparCampos()
        {
            numId.Value = 0;
            txtNome.Text = "";
             
        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = dtGridSalas.Rows[LinhaSelecionada];
            editar.Cells[0].Value = numId.Value;
            editar.Cells[1].Value = txtNome.Text;
            
        }
    }
}
