int numero;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

bool numeron = numero < 0;

if (numeron)
{
    Console.WriteLine($"{numero} é negativo!");
}

