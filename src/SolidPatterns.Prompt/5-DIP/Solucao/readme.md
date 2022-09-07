# Solução

Para realizar a inversão de dependência, neste projeto c# criei o **TestDIP** para simular um contâiner de injeção de depência, porém, o próprio framework nos disponibiliza uma solução para isso.

A utilização das interfaces, fazem com que não dependamos da classe concreta para realizar um instância, dessa forma, o próprio framework fica responsável por injetar todas as dependências que nosso
serviço possa vir a ter, como **IClienteRepository** e **IEmailService**, adicionado também o **Context** que está localizado no construtor da classe concreta **ClienteRepositoryDIContext**.

## Links úteis

 - [Injeção de dependência](https://www.macoratti.net/19/04/c_dioc1.htm)