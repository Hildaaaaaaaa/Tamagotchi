// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Tamagotchi tama = new Tamagotchi();

Console.WriteLine("Vad vill du döpa din tamagotchi?");
tama.name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(tama.name + "! Fint namn (:");
tama.PrintStats();
Console.ReadLine();
Console.WriteLine("Vad vill du göra?");
Console.WriteLine("1, Mata " + tama.name);
Console.WriteLine("2, Lära den ett ord");

string val = "";
while (val != "1" && val != "2")
{
    val = Console.ReadLine();
}

if (val == "1")
{
    tama.feed();
    tama.PrintStats();
    tama.tick();
}
else
{
    //tama.teach();
}

Console.ReadLine();
