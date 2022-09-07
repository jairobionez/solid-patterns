using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoContaEnum tipoConta)
        {
            if (tipoConta == TipoContaEnum.Corrente)
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoContaEnum.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
