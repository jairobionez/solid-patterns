using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura)
            : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
