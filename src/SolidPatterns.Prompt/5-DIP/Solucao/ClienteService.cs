using SolidPatterns.Prompt.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailService;

        public ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailService = emailService;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }

    public class TesteDip
    {
        public TesteDip()
        {
            var cliService = new ClienteService(new ClienteRepositoryDIContext(new Context()), new EmailService());
        }
    }
}
