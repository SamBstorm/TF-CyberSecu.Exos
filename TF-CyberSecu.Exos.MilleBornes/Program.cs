using System;
using System.Collections.Generic;
using System.Linq;

namespace TF_CyberSecu.Exos.MilleBornes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINPLAYER = 3;
            const int MAXPLAYER = 4;
            const int MAXSCORE = 1000;
            const int MINSCORE = 0;
            const int BONUS = 150;
            const int MALUS = 100;

            Dictionary<string, int> playerScores = new Dictionary<string, int>();

            int nbPlayer;
            do
            {
                do
                {
                    Console.WriteLine($"Veuillez indiquer le nombre de joueurs : (compris entre {MINPLAYER} et {MAXPLAYER})");
                } while (!int.TryParse(Console.ReadLine(), out nbPlayer));
            } while (nbPlayer < MINPLAYER || nbPlayer > MAXPLAYER);

            for (int i = 0; i < nbPlayer; i++)
            {
                string playerName;
                do
                {
                    Console.WriteLine($"Veuillez indiquer le nom du joueur numéro {i+1} :");
                    playerName = Console.ReadLine();
                } while (playerScores.ContainsKey(playerName));
                playerScores.Add(playerName, 0);
            }

            string winnerName = null;
            int playerIndex = 0;
            do
            {
                string currentPlayer = playerScores.Keys.ToArray()[playerIndex % nbPlayer];
                string playerChoice;
                do
                {
                    Console.WriteLine($"A {currentPlayer} de jouer, vous êtes à {playerScores[currentPlayer]}KM :\n\t1. Avancer de {BONUS}KM.\n\t2. Infliger un malus de {MALUS}KM.");
                    playerChoice = Console.ReadLine();
                } while (playerChoice != "1" && playerChoice != "2");
                switch (playerChoice)
                {
                    case "1":
                        playerScores[currentPlayer] += BONUS;
                        if (playerScores[currentPlayer] >= MAXSCORE) winnerName = currentPlayer;
                        break;
                    default:
                        string opponentName;
                        do
                        {
                            Console.WriteLine($"Sur quel joueur infliger le malus de {MALUS}?");
                            opponentName = Console.ReadLine();
                        } while (!playerScores.ContainsKey(opponentName));
                        playerScores[opponentName] -= MALUS;
                        if (playerScores[opponentName] < MINSCORE) playerScores[opponentName] = MINSCORE;
                        //playerScores[opponentName] = (playerScores[opponentName] - MALUS < MINSCORE) ? MINSCORE : playerScores[opponentName] - MALUS;
                        break;
                }
                playerIndex++;
            } while (winnerName == null);
            Console.WriteLine($"Bravo {winnerName} vous avez atteint les {MAXSCORE} bornes!");
        }
    }
}
