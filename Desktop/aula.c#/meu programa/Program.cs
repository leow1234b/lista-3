

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite seu peso (em kg):");
        double peso = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite sua altura (em metros):");
        double altura = double.Parse(Console.ReadLine()!);

        double imc = peso / (altura * altura);

        Console.WriteLine("Olá, " + nome + "!");
        Console.WriteLine("Seu IMC é: " + imc);
    }
}
