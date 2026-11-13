using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			var ages = new Dictionary<string, int>();
			ages.Add("Bartek", 30);
            ages.Add("Anna", 25);

			if (ages.TryGetValue("Anna", out int age))
			{
				Console.WriteLine(age);  // 25
			}

			foreach (var pair in ages)
			{
				Console.WriteLine($"{pair.Key}: {pair.Value}");
			}

			// Interaktywne pobranie oceny dla Bartka (1-6)
			Console.Write("Podaj ocenę dla Bartka (1-6): ");
			if (int.TryParse(Console.ReadLine(), out int ocena))
			{
				switch (ocena)
				{
					case 1:
						Console.WriteLine("Egzamin niezaliczony");
						break;
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
						Console.WriteLine("Egzamin zaliczony!");
						break;
					default:
						Console.WriteLine("Nie ma takiej oceny");
						break;
				}
			}
			else
			{
                Console.WriteLine("Wprowadzono nieprawidłowe dane.");
			}
uusing System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			var ages = new Dictionary<string, int>();
			ages.Add("Bartek", 30);
			ages.Add("Anna", 25);

			if (ages.TryGetValue("Anna", out int age))
			{
				Console.WriteLine(age);  // 25
			}

			foreach (var pair in ages)
			{
				Console.WriteLine($"{pair.Key}: {pair.Value}");
			}

			// Interaktywne pobranie oceny dla Bartka (1-6)
			Console.Write("Podaj ocenę dla Bartka (1-6): ");
			if (int.TryParse(Console.ReadLine(), out int ocena))
			{
				switch (ocena)
				{
					case 1:
						Console.WriteLine("Egzamin niezaliczony");
						break;
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
						Console.WriteLine("Egzamin zaliczony!");
						break;
					default:
						Console.WriteLine("Nie ma takiej oceny");
						break;
				}
			}
			else
			{
				Console.WriteLine("Wprowadzono nieprawidłowe dane.");
			}

			/*
			Option Strict Explicit On
			On
			Option 
			''' <summary>
			''' Główny moduł aplikacji konsolowej.
			''' Zawiera punkt wejścia <see cref="Main"/>.
			''' </summary>
			Module Program

				''' <summary>
				''' Punkt wejścia aplikacji konsolowej.
				''' Wypisuje komunikat powitalny na standardowe wyjście konsoli.
				''' </summary>
				''' <param name="args">Tablica argumentów przekazanych z wiersza poleceń.</param>
				''' <remarks>
				''' Usunięto duplikaty i niepowiązane fragmenty kodu (C/C++ oraz powtórzenia).
				''' Zachowano jedną, poprawną definicję modułu i metody Main.
				''' </remarks>
				Sub Main(ByVal args As String())
					' Wyświetlenie komunikatu powitalnego na konsoli.
					Console.WriteLine("Hello World!")
				End Sub

			End Module
			*/
		}
	}
      }  ing System;
          using System.Collections.Generic;
         using System.Runtime.InteropServices;

namespace ConsoleApp2
{
	internal class program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			var ages = new Dictionary<string, int>();
			ages.Add("Bartek", 30);
			ages.Add("Anna", 25);

			if (ages.TryGetValue("Anna", out int age))
			{
				Console.WriteLine(age);  // 25
			}

			foreach (var pair in ages)
			{
				Console.WriteLine($"{pair.Key}: {pair.Value}");
			}

			// Interaktywne pobranie oceny dla Bartka (1-6)
			Console.Write("Podaj ocenę dla Bartka (1-6): ");
			if (int.TryParse(Console.ReadLine(), out int ocena))
			{
				switch (ocena)
				{
					case 1:
						Console.WriteLine("Egzamin niezaliczony");
						break;
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
						Console.WriteLine("Egzamin zaliczony!");
						break;
					default:
						Console.WriteLine("Nie ma takiej oceny");
						break;
				}
			}
			else
			{
				Console.WriteLine("Wprowadzono nieprawidłowe dane.");
			}
			/*
Option Strict Explicit On
On
Option 
''' <summary>
''' Główny moduł aplikacji konsolowej.
''' Zawiera punkt wejścia <see cref="Main"/>.
''' </summary>
Module Program

	''' <summary>
	''' Punkt wejścia aplikacji konsolowej.
	''' Wypisuje komunikat powitalny na standardowe wyjście konsoli.
	''' </summary>
	''' <param name="args">Tablica argumentów przekazanych z wiersza poleceń.</param>
	''' <remarks>
	''' Usunięto duplikaty i niepowiązane fragmenty kodu (C/C++ oraz powtórzenia).
	''' Zachowano jedną, poprawną definicję modułu i metody Main.
	''' </remarks>
	Sub Main(ByVal args As String())
		' Wyświetlenie komunikatu powitalnego na konsoli.
		Console.WriteLine("Hello World!")
	End Sub

End Module
			*/
		}

	}
}