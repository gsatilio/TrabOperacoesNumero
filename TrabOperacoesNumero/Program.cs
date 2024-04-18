//string nome;
float n1, n2, opadd, opsub, opmult, opdiv;

Console.WriteLine("Informe o primeiro numero");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero");
n2 = float.Parse(Console.ReadLine());

if (n2 == 0)
{
    Console.WriteLine("Nao eh possivel dividir por zero.");
}
else
{
    opadd = (n1 + n2);
    opsub = (n1 - n2);
    opmult = (n1 * n2);
    opdiv = (n1 / n2);

    Console.WriteLine("Os numeros informados foram: \n" +
                       n1 + " e " + n2 +
                       "\nOperacao Adicao: " + opadd +
                       "\nOperacao Subtracao: " + opsub +
                       "\nOperacao Multiplicacao: " + opmult +
                       "\nOperacao Divisao: " + opdiv);

}
Console.ReadKey();

