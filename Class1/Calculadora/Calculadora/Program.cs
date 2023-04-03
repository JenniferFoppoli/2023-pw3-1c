// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


using Clase1.Logica;

Console.WriteLine("Ingrese 2 numeros: ");

Console.WriteLine("Número 1: ");
string nro1 = Console.ReadLine();

Console.WriteLine("Número 2: ");
string nro2 = Console.ReadLine();

//Console.WriteLine("La suma de estos numeros da como resultado=" + (int.Parse(nro1) + int.Parse(nro2)));


//String interpolation $"Texto {variable}"
Console.WriteLine(value: $"La suma de estos nros es:{Calculadora.Sumar(nro1,nro2)}");