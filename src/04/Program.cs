
int []Numero; Numero = new int[3];

Console.WriteLine("digite um número inteiro");
Numero[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro numero inteiro: ");
Numero[1] = Convert.ToInt32(Console.ReadLine());

Numero[2] = Numero[0] + Numero[1];
Console.WriteLine("A somatoria dos números inteiros digitados foi igual a, " + Numero[2] + ".");


