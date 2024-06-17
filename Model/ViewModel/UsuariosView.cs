using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class UsuariosView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ativo(bool ativo)
        {
            if (ativo)
            {
                return "Ativado";
            }
            else
            {
                return "Desativado";
            }
        }

    }
}
