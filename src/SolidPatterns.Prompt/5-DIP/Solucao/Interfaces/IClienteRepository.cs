using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.DIP.Solucao.Interfaces
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }
}
