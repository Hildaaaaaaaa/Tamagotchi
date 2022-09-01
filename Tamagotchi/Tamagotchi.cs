using System;

public class Tamagotchi
{
    //private
    private string name = "xX_kawaiiNekoXx";
    private int hunger = 0;
    private int boredom;
    private bool isAlive;
    private List<string> words = new List<string>();

    private Random generator = new Random();

//public
    public void feed();
    public void Hi();
    public void teach();

}
