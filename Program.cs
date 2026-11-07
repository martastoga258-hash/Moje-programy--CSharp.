using System;
using System.IO;

namespace ConsoleApp32_Algorytmy_Zadania
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            string tekst = "Zorro lubi C#";
            int klucz = 3;

            Console.WriteLine("--- KROKI 1-4: Szyfrowanie ---");

            foreach (char znak in tekst)
            {
                if (char.IsLetter(znak))
                {
                    int baza = char.IsUpper(znak) ? 65 : 97;
                    int pozycja = znak - baza;
                    int nowaPozycja = (pozycja + klucz) % 26;
                    char nowyZnak = (char)(baza + nowaPozycja);

                    Console.WriteLine($"{znak} -> {nowyZnak}");
                }
            }

            Console.WriteLine("--- KROK 5: Adresowanie wskaźnikowe ---");
            char[] tablicaBazowa = "ABCDEFGHIJKLMNOPQRSTU".ToCharArray();
            int przesuniecie = 5;
            string nazwaPliku = "wynik.txt";

            fixed (char* wskaznikNaBaze = tablicaBazowa)
            {
                void* baza = wskaznikNaBaze;
                char* wynikWskaznik = (char*)baza + przesuniecie;
                char zapisanyZnak = *wynikWskaznik;

                File.WriteAllText(nazwaPliku, zapisanyZnak.ToString());

                Console.WriteLine($"[Krok 5] Znak pod nowym adresem: {*wynikWskaznik}");
                Console.WriteLine($"[Krok 6] Znak '{zapisanyZnak}' został zapisany do pliku: {Path.GetFullPath(nazwaPliku)}");
            }
        }
    }
}
