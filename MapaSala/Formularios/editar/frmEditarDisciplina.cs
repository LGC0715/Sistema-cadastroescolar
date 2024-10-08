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

namespace MapaSala.Formularios.Editar
{
    public partial class frmEditarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public frmEditarDisciplina(int DisciplinaId)
        {
            InitializeComponent();

            string query = "select Id, Nome, Sigla, Ativo " +
                "from Disciplinas where Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", DisciplinaId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    numId.Text = Leitura[0].ToString();
                    txtnomedisceditar.Text = Leitura[1].ToString();
                    txtsigladisceditar.Text = Leitura[2].ToString();
                    chkativodisceditar.Checked = Convert.ToBoolean(Leitura[3]);

                }
            }
            Conexao.Close();

        }

        private void btn_Salvar_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click_1(object sender, EventArgs e)
        {

        }

        private void numId_Click(object sender, EventArgs e)
        {

        }
    }
}