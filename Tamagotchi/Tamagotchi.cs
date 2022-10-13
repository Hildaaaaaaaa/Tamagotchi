using System;

public class Tamagotchi
{
    public string name = "";
    //private
    private int hunger = 0;
    private int boredom = 0;
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
        int banan = generator.Next(0, words.Count);
        Console.WriteLine(words[banan]);
    }

    public void teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    public void tick()
    {
        hunger += 2;
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
        Console.WriteLine($"-----------------");
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
        Console.WriteLine($"-----------------");
    }

    private void ReduceBoredom()
    {
        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }

}
