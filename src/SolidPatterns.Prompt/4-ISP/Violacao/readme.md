## Violações

Em um cenário fictício para criação de programa de e commerce, verificamos que as classes **CadastroProduto** e **CadastroCliente** herdam a mesma **interface** que possui mesmos métodos, porém metódo **EnviarEmail()** não corresponde para a classe **CadastroProduto**, pois produto não tem e-mail! essa forma, estamos violando o Interface Segregation Principle — E o LSP também!