﻿using System;

namespace acfour_Jhon_Osorio
{
	public class acfour_Jhon_Osorio
	{
		const string requestQuantityNumbers = "Ingresa la cantidad de numeros naturales que quieres guardar";

		public static void Main()
		{
			Console.WriteLine(requestQuantityNumbers);
			int[] userNumberList = new int[int.Parse(Console.ReadLine())];
			AddNumbersInList(userNumberList);
			OrdenateListBurble(userNumberList);
			ReadArrayList(userNumberList);

		}

		public static void AddNumbersInList(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write("Ingrese un número: ");
				string input = Console.ReadLine();

				int numberNaturalUser;
				if (int.TryParse(input, out numberNaturalUser) && numberNaturalUser > 0)
				{
					numbers[i] = numberNaturalUser;
				}
				else
				{
					Console.WriteLine("Entrada no válida, tiene que ser un numero natural. Intente nuevamente.");
					i--;
				}
			}
		}
		public static void ReadArrayList(int[] numbers)
		{
			for (int i = 0;i < numbers.Length;i++)
			{
				Console.Write(numbers[i]+ " " );
			}
		}
		public static void OrdenateListBurble(int[] numbers)
		{
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				for (int j = 0; j < numbers.Length - 1 - i; j++)
				{
					if (numbers[j] < numbers[j + 1]) 
					{
						int temp = numbers[j];
						numbers[j] = numbers[j + 1];
						numbers[j + 1] = temp;
					}
				}
			}
		}
	}	
}