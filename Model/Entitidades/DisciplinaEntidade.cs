using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class DisciplinaEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Sigla };
        }
    }
}
