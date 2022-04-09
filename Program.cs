int idadeUsuario;

//Espacamento
Console.WriteLine();

//Solicita e armazena a idade do usuário
Console.Write("Insira sua idade, em anos: ");
idadeUsuario = Convert.ToInt32(Console.ReadLine());

//Espacamento
Console.WriteLine();

//Testando para idade
if (idadeUsuario < 18)
{
    //Mensagem de erro, em vermelho, com som
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep();

    Console.WriteLine("Você não pode doar sangue.");
}
else if (idadeUsuario > 67)
{
    //Mensagem de erro, em vermelho, com som
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep();

    Console.WriteLine("Você não pode doar sangue.");
}
else
{
    //Mensagem de sucesso em verde
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Você pode doar sangue.");
}

//Resetando cores
Console.ResetColor();

//Espacamento
Console.WriteLine();