// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hallo, Schaakbord!");
Console.ReadLine();
Console.Write("geef de hoogte van het bord ");
int Hoogte = Convert.ToInt32(Console.ReadLine());
Console.Write("Geef de breedte van het bord ");
int Breedte = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("schaakbord word " + Hoogte + " hoog en " + Breedte + " breed");


for (int h = 0; h < Hoogte; h++)
{
    for (int b = 0; b < Breedte; b++)
    {
        if ((b % 2 == 0) ^ (h % 2 == 0))
            Console.Write("Z ");
        else
            Console.Write("W ");
    }

    Console.WriteLine();
}


Console.ReadLine();