using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("jairo@treeinova.com.br", cliente.Email.Endereco, "Bem vindo", "Parabéns seus cadastro foi efetuado com sucesso!");
            return "Cliente cadastrado com sucesso!";
        }
    }
}
