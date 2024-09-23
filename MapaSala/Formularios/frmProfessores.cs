using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmProfessores : Form
    {
       
        ProfessoresDAO dao = new ProfessoresDAO();
        int LinhaSelecionada;
        public frmProfessores()
        {
            InitializeComponent();
                     

            dtGridProfessores.DataSource = dao.ObterProfessores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade p = new ProfessoresEntidade();
            p.Id = Convert.ToInt32(numId.Value);
            p.Apelido = txtApelido.Text;
            p.Nome = txtNomeCompleto.Text;

            // dados.Rows.Add(p.Linha());
            dao.Inserir(p);
            dtGridProfessores.DataSource = dao.ObterProfessores();
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtApelido.Text = "";
            txtNomeCompleto.Text = "";
            numId.Value = 0;
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           
                DataGridViewRow editar = dtGridProfessores.Rows[LinhaSelecionada];
                editar.Cells[0].Value = numId.Value;
                editar.Cells[1].Value = txtNomeCompleto.Text;
                editar.Cells[2].Value = txtApelido.Text;
            
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            dtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
            LimparCampos();
        }

        private void dtGridProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value);
            txtNomeCompleto.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridProfessores.DataSource = dao.Pesquisar(txtpesquisa.Text);
        }
    }
    }

