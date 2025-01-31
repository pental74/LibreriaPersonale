using System;
// Libreria che contiene tutte funzioni e procedure che posso andare da utilizzare
namespace MiaLibreria
{
    public class Utility
    {
        // Stampa di prova
        public static void ProceduraDiProva (string Saluto)
        {
            Console.WriteLine (Saluto);
        }

        // Stampa di un vettore di stringhe
        public static void StampaVettoreStringhe (string[] vettore_stringhe)
        {
            Console.WriteLine($"\n\nStampa vettore specifica per {nameof(vettore_stringhe)}\n");
            for (int i = 0; i < vettore_stringhe.Length; i++)
            {
                // nameof(vettore_stringhe) = stampa il nome della variabile
                Console.WriteLine($"{nameof(vettore_stringhe)}[{i}] = {vettore_stringhe[i]}");
            }
        }


        // Stampa di un vettore di interi
        public static void StampaVettoreInteri(int[] vettore_interi)
        {
            Console.WriteLine($"\n\nStampa vettore specifica per {nameof(vettore_interi)}\n");
            for (int i = 0; i < vettore_interi.Length; i++)
            {
                // nameof(vettore_stringhe) = stampa il nome della variabile
                Console.WriteLine($"{nameof(vettore_interi)}[{i}] = {vettore_interi[i]}");
            }
        }

        #region Procedure di stampa generica utilizzabili con parametri di diverso tipo
        public static void StampaVettore(int[] vettore_interi)
        {
            Console.WriteLine($"\n\nStampa vettore generica - {nameof(vettore_interi)}\n");
            for (int i = 0; i < vettore_interi.Length; i++)
            {
                // nameof(vettore_stringhe) = stampa il nome della variabile
                Console.WriteLine($"{nameof(vettore_interi)}[{i}] = {vettore_interi[i]}");
            }
        }

        public static void StampaVettore(string[] vettore_stringhe)
        {
            Console.WriteLine($"\n\nStampa vettore generica - {nameof(vettore_stringhe)}\n");
            for (int i = 0; i < vettore_stringhe.Length; i++)
            {
                // nameof(vettore_stringhe) = stampa il nome della variabile
                Console.WriteLine($"{nameof(vettore_stringhe)}[{i}] = {vettore_stringhe[i]}");
            }
        }

        public static void StampaVettore(char[] vettore_caratteri)
        {
            Console.WriteLine($"\n\nStampa vettore generica - {nameof(vettore_caratteri)}\n");
            for (int i = 0; i < vettore_caratteri.Length; i++)
            {
                // nameof(vettore_stringhe) = stampa il nome della variabile
                Console.WriteLine($"{nameof(vettore_caratteri)}[{i}] = {vettore_caratteri[i]}");
            }
        }
        #endregion
    }
}
