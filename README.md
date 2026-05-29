# ContaCorrente

Simule a operação de uma Conta Corrente, no banco MongaBank.
O valor do cheque especial será informado pelo usuário.

> O valor mínimo deverá respeitar o cheque especial.

```
---- MongaBank - Seu dinheiro rende mais! ----

Selecione uma opção abaixo:

0 - Abrir Conta Corrente
1 - Saldo
2 - Saque
3 - Depósito
4 - Encerrar conta e sair

Opção: __
```

Opção 0
```
---- MongaBank - Seu dinheiro rende mais! ----

Nome: Zé das Couves
Depósito inicial: 0
Limite de cheque especial: 100

```
Opção 1
```
---- MongaBank - Seu dinheiro rende mais! ----

Seu saldo é de: R$ 0,00
Limite de cheque especial: R$ 100,00

```

Opção 2 - Limite insuficiente
```
---- MongaBank - Seu dinheiro rende mais! ----

Cliente: Zé das Couves. 
Informe um valor para saque: 300

-> Seu limite atual não permite esta operação!
```
Opção 2 - Com limite e sem uso do cheque especial
```
---- MongaBank - Seu dinheiro rende mais! ----

Cliente: Zé das Couves. 
Informe um valor para saque: 50

-> Seu saldo é de R$ 50,00

```
Opção 2 - Com limite e com uso do cheque especial
```
---- MongaBank - Seu dinheiro rende mais! ----

Cliente: Zé das Couves. 
Informe um valor para saque: 150

-> Você está utilizando seu cheque especial
-> Seu saldo é de -R$ 100,00
```

Opção 3
```
---- MongaBank - Seu dinheiro rende mais! ----

Cliente: Zé das Couves. 
Informe um valor para depósito: 100

-> Seu saldo atual é de R$ 100
```

Opção 4
```
---- MongaBank - Seu dinheiro rende mais! ----

Obrigado por utilizar nossos serviços

Valor a receber: R$ 100,00

```