
# Solução

Para aplicar o príncipio aberto fechado, criei uma classe abstrata no qual possui algumas informações base dado elas uma método abstrato chamado **Debitar**. 
Com essa modificação, foram criadas outras duas classes, uma para **conta de corrente** e outra para **conta poupança** onde ambas herdam a classe abstrata **DebitarConta**.

Com isso, conseguimos enxugar a classe **DebitoConta** e fazer com que ela não precise conhecer o comportamento das diversas contas. Ou seja, vamos FECHAR as classes DebitoContaCorrente e DebitoPoupança para mudanças e caso outras regras surjam para serem utilizadas na classe DebitoConta.

## Links útils

 - [Abstract Classes](https://www.macoratti.net/12/06/c_caip1.htm)