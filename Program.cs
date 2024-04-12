using System.Diagnostics.Tracing;
using System.Reflection;

Console.Clear();

int numero;

Console.WriteLine("Digite um número: ");
numero =Convert.ToInt32(Console.ReadLine());

if(numero >= 0) //se o número for maior ou igual a zero
{ //faça isso
    Console.ForegroundColor = ConsoleColor.Green;  // somente se positivo ou zero
}

else // executar um ou outro

if(numero <= -1) //se o número for menor ou igual a -1
{ // faça isso
    Console.ForegroundColor = ConsoleColor.Red;    // somente se negativo
}


Console.WriteLine($"O número digitado é {numero}.");

Console.ResetColor();