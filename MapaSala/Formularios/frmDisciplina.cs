using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using MapaSala.Formularios.cadastrar;
using MapaSala.Formularios.editar;
using MapaSala.Formularios.Editar;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();
        int LinhaSelecionada;
        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterDisciplina();

            dtGridDisciplina.DataSource = dados;
        }


        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // LinhaSelecionada = e.RowIndex;
           // txtNomeDisciplina.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString();
           // txtSigla.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
           // numId.Value = Convert.ToInt32(dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value);
            //chkativo.Checked = Convert.ToBoolean(dtGridDisciplina.Rows[LinhaSelecionada].Cells[3].Value);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridDisciplina.DataSource = dao.Pesquisar(txtpesquisa.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);

               frmEditarDisciplina editar = new frmEditarDisciplina(id);

                // Inscreve-se no evento
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal

            }
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {

            dtGridDisciplina.DataSource = dao.ObterDisciplina();
        }

        private void btnadd_disc_Click(object sender, EventArgs e)
        {

            frmCadastrarDisciplina d = new frmCadastrarDisciplina();
            d.FormClosed += Fechou_Editar_FormClosed;
            d.ShowDialog();
        }
    }
}
