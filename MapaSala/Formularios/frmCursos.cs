using MapaSala.DAO;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmCursos : Form
    {
        CursoDAO dao = new CursoDAO();
        int LinhaSelecionada;
        public frmCursos()
        {

            InitializeComponent();


            dtGridCursos.DataSource = dao.ObterCurso();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtturno.Text = "";
            numId.Value = 0;
            chkativo.Checked = false;
        }

        private void chkIsLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cursoEntidades curso = new cursoEntidades();
            curso.Id = Convert.ToInt32(numId.Value);
            curso.Nome = txtNome.Text;
            curso.Turno = txtturno.Text;
            curso.Ativo = chkativo.Checked;

            dao.Inserir(curso);
            dtGridCursos.DataSource = dao.ObterCurso();
            LimparCampos();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);
            LimparCampos();
        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToUInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value);
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtturno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkativo.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridCursos.Rows[LinhaSelecionada];
            a.Cells[0].Value = numId.Value;
            a.Cells[1].Value = txtNome.Text;
            a.Cells[2].Value = txtturno.Text;
            a.Cells[3].Value = chkativo.Checked;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridCursos.DataSource = dao.Pesquisar(txtpesquisa.Text);
        }
    }
}
