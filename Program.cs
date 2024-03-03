using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {   
            double salario, imposto, aumento, resultado, resultado2;
            string nome;

            Console.WriteLine("digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu salario: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o imposto : ");
            imposto = double.Parse(Console.ReadLine());

            resultado = salarioLiquidox(salario, imposto);

            Console.WriteLine($"Trabalhador de nome : {nome}");
            Console.WriteLine($"Salario liquido de: {resultado}");
            string separador = new string('=', 50);
            Console.WriteLine(separador);

            Console.WriteLine("digite o aumento: ");
            aumento = double.Parse(Console.ReadLine());
            resultado2 = aumentoSalario(salario, aumento);
            Console.WriteLine($"seu aumento foi de: {resultado2}R$");
        }

        public static double salarioLiquidox(double Salario, double imposto)
        {
            double impostoDesconto = (Salario * imposto) / 100;
            double salarioLiquido = Salario - impostoDesconto;
            return salarioLiquido;
        }

        public static double aumentoSalario(double Salario, double aumento)
        {
            double resultado = (Salario * aumento) / 100;
            return resultado;

        }
    }
}