using System.Linq.Expressions;

string Name,NomeMes ="a";
int Mes = -2, Condicao = -1;
decimal SalarioFuncionario;

Console.WriteLine("Digite o nome do funcionario: ");
Name = Console.ReadLine();

while (Condicao < 1 )
{
    Console.WriteLine("Digite o mês numeral do qual se refere-se o dia de hoje :");

    Mes = Convert.ToInt16(Console.ReadLine());
    if (Mes > 0 && Mes < 13)
    {
        Condicao = 2;
    }
}

switch (Mes)
{
    case 1:
        NomeMes = "Janeiro";
        break;
    case 2:
        Console.WriteLine("fevereiro");
        break;
    case 3:
        Console.WriteLine("março");
        break;
    case 4:
        Console.WriteLine("abril");
        break;
    case 5:
        Console.WriteLine("maio");
        break;
    case 6:
        Console.WriteLine("junho");
        break;
    case 7:
        Console.WriteLine("julho");
        break;
    case 8:
        Console.WriteLine("agosto");
        break;
    case 9:
        Console.WriteLine("setembro");
        break;
    case 10:
        Console.WriteLine("outubro");
        break;
    case 11:
        Console.WriteLine("novembro ");
        break;
    case 12:
        Console.WriteLine("dezembro");
        break;
}

Console.WriteLine("Digite o salario do(a) funcionario, " + Name + ":");
SalarioFuncionario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("O funcionario(a) "+ Name+ " tem um salario de r$"+ SalarioFuncionario+" no mês de "+ NomeMes);