﻿using System;

namespace TriviaGame
{
    public class GameRunner
    {

        private static bool notAWinner;

        public static void Main(String[] args)
        {
            Game aGame = new Game();

            aGame.AddPlayer("Chet");
            aGame.AddPlayer("Pat");
            aGame.AddPlayer("Sue");

            Random rand = new Random(Int32.Parse(args[0]));

            do
            {

                aGame.NextPlayerRolls(rand.Next(5) + 1);

                if (rand.Next(9) == 7)
                {
                    notAWinner = aGame.IncorrectAnswer();
                }
                else
                {
                    notAWinner = aGame.CorrectAnswer();
                }



            } while (notAWinner);

        }
    }
}
