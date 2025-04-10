using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPonto.Entidades
{
    public class Registro
    {
        public DateOnly Data { get; set; }
        public TimeOnly Entrada { get; set; }
        public TimeOnly Almoco { get; set; }
        public TimeOnly Retorno { get; set; }
        public TimeOnly Saida { get; set; }
        public TimeOnly Manha { get; set; }
        public TimeOnly Tarde { get; set; }
        public TimeOnly TotalDia { get; set; }
    }
}
