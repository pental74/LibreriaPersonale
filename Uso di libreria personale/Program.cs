using System;

// Using della libreria personale
using MiaLibreria;

namespace Uso_di_libreria_personale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vettore delle stringhe di prova
            string[] strings = { "Prova", "Marco", "Ciao" };
            int[] interi = { 1, 10, 2, 4, 6, 3, 7, 98, 9, 7, 5, 3 };
            char[] caratteri = { 'a', 'b', '2', 'r', 'g', 'F', '7'};

            // Richiamo della libreria personale, necessario inserire nome della classe 
            Utility.ProceduraDiProva("Ciao Marco");

            // Utilizzo di procedura di stampa specifiche per i diversi tipi di dati
            Utility.StampaVettoreStringhe(strings);
            Utility.StampaVettoreInteri(interi);

            // Utilizzo della procedura di stampa con lo stesso nome con argomenti di diversi tipo
            Utility.StampaVettore(interi);
            Utility.StampaVettore(strings);
            Utility.StampaVettore(caratteri);
        }
    }
}
