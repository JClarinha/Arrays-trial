int [] x = new int [] {10,22,35,104,2,7};

System.Console.WriteLine("_______________________________________________________");

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

System.Console.WriteLine("_______________________________________________________");


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


//____________________________________________________________________________________________________________________________________________

int [,] z = 
{
{1,2,3,4,5},
{6,7,8,9,10},
{11,12,13,14,15},
{16,17,18,19,20},
{21,22,23,24,25}
};

int rowLength = z.GetLength(0);
int colLength = z.GetLength(1);

for (int i = 0; i < rowLength; i++)
{
    for (int j = 0; j < colLength; j++)
    {
        System.Console.Write(z[i,j]);
        Console.Write("\t");
    }
    Console.Write("\n\n");
}



int [][] y = new int [][]
{
    new int [] {1,2,3,4,5},
    new int [] {6,7,8,9,10},
    new int [] {11,12,13,14,15},
    new int [] {16,17,18,19,20},
    new int [] {21,22,23,24,25}

};

Console.WriteLine("\n\n");
Console.Beep();



for (int i = 0; i < y.Length; i++)
{
    for (int j = 0; j < y.Length; j++)
    {
        System.Console.Write(y[i][j]);
        Console.Write("\t");
    }
    Console.Write("\n\n");
}
