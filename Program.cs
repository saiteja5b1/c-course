using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }
        private static void StartGame(){
            System.Console.WriteLine("Starting the game...");
            AskForUserGame();
        }
        static void AskForUserGame(){
            System.Console.WriteLine("Asking user for name...");
        }
        private static void PlayGame(){
            System.Console.WriteLine("Playing the game...");
            DisplayMaskedWord();
            AskForLetter();
        }
        static void DisplayMaskedWord(){
            System.Console.WriteLine("Displaying Masked Word...");
        }
        static void AskForLetter(){
            System.Console.WriteLine("Asking for letter...");
        }
        private static void EndGame(){
            System.Console.WriteLine("Game over...");
        }
    }
}
