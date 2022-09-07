using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.DIP.Violacao
{
    public class Cpf
    {
        public string Documento { get; set; }

        public bool Validar()
        {
            return Documento.Length != 11;
        }
    }
}
