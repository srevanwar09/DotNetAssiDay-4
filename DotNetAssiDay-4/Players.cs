using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{
    internal class Player
    {
        const int LADDER = 1;
        const int SNAKE = 2;
        const int WINNING_POINT = 100;
        public void gamePlay()
        {
            int tempPosition, diceCount = 0, position = 0;
            while (position < WINNING_POINT)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                int rolldie = random.Next(1, 7);
                diceCount++;
                switch (option)
                {
                    case LADDER:
                        tempPosition = position + rolldie;
                        if (tempPosition > 100)
                        {
                            position += 0;
                        }
                        else
                        {
                            position = tempPosition;
                        }
                        break;
                    case SNAKE:
                        tempPosition = position - rolldie;
                        if (tempPosition <= 0)
                        {
                            position = 0;
                        }
                        else
                        {
                            position = tempPosition;
                        }
                        break;
                    default:
                        position += 0;
                        break;
                }
                Console.WriteLine("Player 1 position is " + position);
            }
            Console.WriteLine("The " + diceCount + " times the dice was played to win the game.");
        }
    }
}