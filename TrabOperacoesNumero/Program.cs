float n1 = 0, n2 = 0, n3 = 0, n4 = 0, operacao = 0;
string tipo = "", tipostr = "";

Console.WriteLine("Escolha o tipo de operação\n 1 - Adição\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão");
tipo = (Console.ReadLine()); // tipo = string para "aceitar" o null

// Obriga o usuário a escolher uma opção válida
while ((tipo != "1") && (tipo != "2") && (tipo != "3") && (tipo != "4"))
{
    Console.WriteLine("Por favor, escolha uma opção válida.");
    tipo = (Console.ReadLine());
}

// Entrada de dados
Console.WriteLine("Informe o primeiro numero");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro numero");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o quarto numero");
n4 = float.Parse(Console.ReadLine());

// Tratativa div por zero
if ((tipo == "4") && ((n2 == 0) || (n3 == 0) || (n4 == 0)))
{
    Console.WriteLine("Nao é possivel dividir por zero.");
}
else
{
    // Tipos de operações
    if (tipo == "1")
    {
        operacao = (n1 + n2 + n3 + n4);
        tipostr = "Adição";
    } else if (tipo == "2")
    {
        operacao = (n1 - n2 - n3 - n4);
        tipostr = "Subtração";
    } else if (tipo == "3")
    {
        operacao = (n1 * n2 * n3 * n4);
        tipostr = "Multiplicação";
    } else if (tipo == "4")
    {
        operacao = (n1 / n2 / n3 / n4);
        tipostr = "Divisão";
    }

    // Resultado final
    Console.WriteLine("Você escolheu o tipo de operação: " + tipostr + "\n" +
                      "Para os numeros: " + n1 + ", " + n2 + ", " + n3 + ", " + n4 + "\n" +
                      "O cálculo da operação é: " + operacao);
}
Console.ReadKey();
