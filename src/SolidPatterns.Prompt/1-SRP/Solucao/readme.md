
# Solução

Note que vários novos arquivos foram gerados, nos quais cada um terão suas responsabilidades. Lembrando que são apenas exemplos, a solução não está perfeita pois depende dos outros princípios para que ela consiga ser aplicada de forma perfeita.

Para solução da conexão, foi utilizado o **repository pattern**, onde será centralizado o acesso aos dados da aplicação.

Para algumas validações da própria classe de **CLIENTE**, foram criados alguns objetos complexos para **CNPJ** e **EMAIL**, dessa forma centralizando a validação especifica de cada e dando a possibilidade de reutilização dos mesmos.

Foi criado dois **serviços**, uma específico para o **envio de e-mail** e outro para **orquestrar o fluxo de criação do cliente** onde o mesmo e responsável por fazer a chamada do repositório, do serviço de e-mail e demais validações que a entidade possui.

## Links útils

 - [Repository Pattern & Unit of Work](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
 - [Objetos de valor](https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects)
 - [Services Layer](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/validating-with-a-service-layer-cs)
 - [Modelos anêmicos e ricos](https://dev.to/wsantosdev/design-modelos-anemicos-e-modelos-ricos-4k8f)

