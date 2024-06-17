using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class SalasEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroComputadores { get; set; }
        public int NumeroCadeiras { get; set; }
        public bool IsLab { get; set; }
        public bool Disponivel { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, Nome, NumeroCadeiras, NumeroComputadores, IsLab, Disponivel };
        }
    }
}
