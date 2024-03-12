//int [] x = new int [] {10,22,35,104,2,7};

/*System.Console.WriteLine("_______________________________________________________");

foreach (int i in x)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine("_______________________________________________________");


for (int i = 0; i < x.Length; i++)
{
    System.Console.WriteLine(x[i]);
}

System.Console.WriteLine("_______________________________________________________");


Array.Sort(x);

foreach (int i in x)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine("_______________________________________________________");*/

System.Console.WriteLine("Quantas tentativas queres para adivinhares o numero em que estou a pensar? \nLembra-te quantas mais, mais tens de escrever!!!");
int tentativas =  int.Parse(System.Console.ReadLine());

int [] game = new int [tentativas]; 

while (!game.Contains(7))
{

    for (int i = 0; i < game.Length; i++)
    {
    System.Console.WriteLine("introduz um numero inteiro. \n if youn dare!");
    game[i] = int.Parse(System.Console.ReadLine());
    }


    if (game.Contains(7))
    {
        System.Console.WriteLine("Boa pioutoooo!");
    }
    else
    {
        System.Console.WriteLine("Acho que vais ter de meter mais tentativas seu ganda burro!\nVamos lá outra vez");
    }
    System.Console.ReadLine();

}