using System;

public class Tamagotchi
{
    //private
    private string name = "xX_kawaiiNekoXx";
    private int hunger = 9;
    private int boredom;
    private bool isAlive = true;
    private List<string> words = new List<string>();

    private Random generator = new Random();

    private int hp;

    public Tamagotchi()
    {
        hp = generator.Next(10, 20);
    }

    //public

    public void feed()
    {
        hunger--;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }



    public void Hi()
    {

    }

    public void teach(string word)
    {
        words.Add(word);
    }

    public void tick()
    {
        hunger++;
        if (hunger > 10)
        {
            isAlive = false;
        }
        boredom++;
        if (boredom > 10)
        {
            isAlive = false;
        }


    }

    //Printar ut tamagochins stats
    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        if (isAlive == true)
        {
            Console.WriteLine("Den lever! :D");
        }
        else
        {
            Console.WriteLine("Den dog ):");
        }
    }

}
