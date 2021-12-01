using System;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string player1move = ""; //insert player 1 selection here
            string player2move = ""; //insert player 2 selection here
            string result = p.rps(player1move.ToLower(), player2move.ToLower());
            System.Console.WriteLine(result);
        }

        public string rps(string a, string b)
        {
            if((a == "rock" && b == "rock") || (a == "paper" && b == "paper") || (a == "scissors" && b == "scissors"))
            {
                return "TIE";
            }
            
            else if((a == "rock" && b == "scissors") || (a == "paper" && b == "rock") || (a == "scissors" && b == "paper"))
            {
                return "Player 1 wins";
            }

            else if((b == "rock" && a == "scissors") || (b == "paper" && a == "rock") || (b == "scissors" && a == "paper"))
            {
                return "Player 2 wins";
            }

            else
            {
                return "invalid input";
            }
        }
    }
}