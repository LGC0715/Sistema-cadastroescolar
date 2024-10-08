using MapaSala.DAO;
using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MapaSala.Formularios.cadastrar
{
    public partial class frmCadastrarDisciplina : Form
    {
        DisciplinaDAO dao = new DisciplinaDAO();
        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public frmCadastrarDisciplina()
        {
            InitializeComponent();
        }

        private void frmCadastrarDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;
            d.Ativo = chkativo.Checked;

            string query = "insert into Disciplinas (nome,sigla,ativo) values (@nome,@sigla,@ativo)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkativo.Checked));

            int resposta = comando.ExecuteNonQuery();




            if (resposta == 1)
            {
                MessageBox.Show("Disciplina adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtNomeDisciplina.Text = "";
            txtSigla.Text = "";
        }
    }
}
