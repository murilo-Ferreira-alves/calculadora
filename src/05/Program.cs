int []Nota; Nota = new int[2];
int Resultado;

Console.WriteLine("digite a primeira nota:");
Nota[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite a segunda nota: ");
Nota[1] = Convert.ToInt32(Console.ReadLine());

Resultado = Nota[0] + Nota[1];

Console.WriteLine("A média entre " + Nota[0] + " e " + Nota[1] + " e igual a " + Resultado/2 + ".");














