string opcao = "", nome = "";
decimal saldo = 0, chequeEspecial = 0;
bool isContaCriada = false;

const string TITULO = "---- MongaBank - Seu dinheiro rende mais! ----\n";

const string MENU = @"Selecione uma opção abaixo:

0 - Abrir Conta Corrente
1 - Saldo
2 - Saque
3 - Depósito
4 - Encerrar conta e sair

Opção: ";



while (true)
{
    Console.Clear();
    
    Console.WriteLine(TITULO);   
    Console.Write(MENU);

    opcao = Console.ReadLine()!.Trim().Substring(0,1);

    Console.WriteLine($"Opção informada: {opcao}");

    if (opcao == "0")
    {
        Console.Clear();
        Console.WriteLine(TITULO); 
        Console.Write("Nome: ");
        nome = Console.ReadLine()!;

        Console.Write("Depósito Inicial: ");
        saldo = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Cheque especial: ");
        chequeEspecial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"\nBem vindo, {nome}.");
        Console.WriteLine($"Seu saldo é de {saldo:C2}");
        Console.WriteLine($"Seu limite de cheque especial é de {chequeEspecial:C2}\n");

        isContaCriada = true;
    }
    else if (!isContaCriada)
    {
        Console.WriteLine("A abertura da conta é obrigatória!!");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey(true);
        continue;
    }
    else if (opcao == "1")
    {
        
    }
    else if (opcao == "2")
    {
        
    }
    else if (opcao == "3")
    {
        
    }
    else if (opcao == "4")
    {
        break;
    }
    else
    {
        
    }

}
