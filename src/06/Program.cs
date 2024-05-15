
int Numero, NumeroAntecessor, NumeroSucessor;
Console.WriteLine("Digite um numero inteiro: ");
Numero = Convert.ToInt32(Console.ReadLine());

NumeroAntecessor = Numero - 1;

NumeroSucessor = Numero + 1;

Console.WriteLine("O antecessor de " + Numero + " e " + NumeroAntecessor + " \nO sucessor do " + Numero + " e " + NumeroSucessor);

