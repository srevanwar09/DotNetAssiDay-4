const int LADDER = 1;
const int SNAKE = 2;
const int WINNING_POINT = 100;
Console.WriteLine("Welcome in Snake & Ladder Simulator.");
int position = 0;
int tempPosition;
Console.WriteLine("Player 1 position is " + position);
for (int i = 0; position <= WINNING_POINT; i++)
{
    Random random = new Random();
    int option = random.Next(0, 3);
    int rolldie = random.Next(1, 7);
    switch (option)
    {
        case LADDER:
            position += rolldie;
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

