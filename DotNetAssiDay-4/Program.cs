using SnakeLadderSim;
Players play = new Players();
Console.WriteLine("Welcome in Snake & Ladder Simulator.");
int player1 = play.gamePlay(1);
int player2 = play.gamePlay(2);
if (player1 < player2)
{
    Console.WriteLine("Player 1 is a Winner.");
}
else if (player1 > player2)
{
    Console.WriteLine("Player 2 is a Winner.");
}
else
{
    Console.WriteLine("Its a tie between Player 1 and 2.");
}
