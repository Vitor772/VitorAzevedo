using System;

class Calculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo à Calculadora!");
        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma operação: +, -, *, /");
        char operacao = Console.ReadLine()[0];

        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Erro: Divisão por zero.");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}
