class Programs
{
    static void main(String[] Args)
    {
        int position = 0;
        Console.WriteLine("welcome in Snake & Ladder Simulator.");
        Random random = new Random();
        int rolldie = random.Next(1, 7);
        Console.WriteLine("Player 1 position is " + position);
        Console.WriteLine("Roll Die value: " + rolldie);


    }
}