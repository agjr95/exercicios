﻿using System;
namespace calculadora
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Operacoes calc = new Operacoes();
      Console.Write("\n\n ---- Menu Calculadora ----\n\n");

      MostrarMenu.Mostrar();

      Console.Write("Tecle o número correspondente a ação desejada\n\n");
      int opcaoMenu = int.Parse(Console.ReadLine());
      Console.WriteLine($"\n\n ----Opção escolhida: {opcaoMenu} ----");

      while (opcaoMenu < 1 || opcaoMenu > 5)
      {
        Console.WriteLine($"\n\n --- ERROR: {opcaoMenu} não é uma opção válida ---\n\n\n\n");
        Console.Write("Tecle o número correspondente a ação desejada\n\n");
        MostrarMenu.Mostrar();

      }

      while (opcaoMenu != 5)
      {
        Console.WriteLine("\n\nDigite o primeiro número");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"\n\n////// Resultado : {calc.Calcular(opcaoMenu, num1, num2)} //////\n\n\n\n");

        MostrarMenu.Mostrar();

        Console.Write("Tecle o número correspondente a ação desejada\n\n");
        opcaoMenu = int.Parse(Console.ReadLine());
        Console.WriteLine($"\n\n ----Opção escolhida: {opcaoMenu} ----\n\n");

      }

      Console.WriteLine("\n\n\n\n----- Fim da operação -----\n\n\n\n");



    }
  }
}


