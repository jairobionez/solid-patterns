using SolidPatterns.Prompt.DIP.Solucao;
using SolidPatterns.Prompt.DIP.Solucao.Interfaces;

namespace SolidPatterns.Prompt.DIP.Solucao
{
    public  class ClienteRepositoryDIContext : IClienteRepository
    {
        private readonly Context _context;

        public ClienteRepositoryDIContext(Context context)
        {
            _context = context;
        }

        public void AdicionarCliente(Cliente cliente)
        {

            // Usar outra forma de ir até o BD

        }
    }
}
