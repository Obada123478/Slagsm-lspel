int Figher1Hp = 100;
int Fighter2Hp = 100;



Console.WriteLine("Välkommen till striden");
Console.ReadLine();

Console.WriteLine("Vad ska spelare 1 heta?");
string Fighter1Name = Console.ReadLine();
if (Fighter1Name == "")
{
    Fighter1Name = "Obada";
}
Console.WriteLine("Nu du ska heta Obada");
Console.ReadLine();


Console.WriteLine("Vad ska spelare 2 heta?");
String Fighter2Name = Console.ReadLine();
if (Fighter2Name == "")
{
    Fighter2Name = "Lukas";
}

Console.WriteLine("Nu ska spelare 2 heta Lukas");
Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Då ska {Fighter1Name} möta {Fighter2Name}!");
Console.WriteLine("Tryck på valfri knapp!");
Console.ReadKey();


while (Figher1Hp > 0 && Fighter2Hp > 0)
{

    Console.Clear();

    Console.WriteLine("En ny runda");
    Console.WriteLine($"{Fighter1Name}: {Figher1Hp} HP");
    Console.WriteLine($"{Fighter2Name}: {Fighter2Hp} HP");
    Console.WriteLine();
    {



        Console.WriteLine("1 snabb attack:");
        Console.WriteLine("2  tung attack ");
        Console.WriteLine("3 normal attack");
        Console.WriteLine("Ditt val:");

        string Attack = Console.ReadLine();

        int Fighter1Damage = 0;

        if (Attack == "1")

        {

            Fighter1Damage = Random.Shared.Next(5, 16);
            Console.WriteLine($"{Fighter1Name} använder snabb attack!");
        }
        else if (Attack == "2")
        {
            Fighter1Damage = Random.Shared.Next(10, 21);
            Console.WriteLine($"{Fighter1Name} använder tung attack! använder normal attack!");
        }
        else if (Attack == "3")
        {
            Fighter1Damage = Random.Shared.Next(15, 31);
            Console.WriteLine($"{Fighter1Name}  använder normal attack!");
        }
        else
        {
            Console.WriteLine("Fel val! Du gjorde ingen skada.");
        }

        Fighter2Hp -= Fighter1Damage;
        Fighter2Hp = Math.Max(0, Fighter2Hp);

        Console.WriteLine($"{Fighter1Name} gör {Fighter1Damage} skada på {Fighter2Name}");

        if (Fighter2Hp > 0)
        {
            int LukasAttack = Random.Shared.Next(1, 4);
            int LukasDamage = 0;

            if (LukasAttack == 1)
            {
                LukasDamage = Random.Shared.Next(5, 16);
                Console.WriteLine($"{Fighter2Name} använder snabb attack!");
            }
          else if (LukasAttack == 2)
            {
                LukasDamage = Random.Shared.Next(8, 18);
                Console.WriteLine($"{Fighter2Name} använder normal attack!");
            }
            else if (LukasAttack == 3)
            {
                LukasDamage = Random.Shared.Next(15, 31);
                Console.WriteLine($"{Fighter2Name} använder tung attack!");
            }
            Figher1Hp -= LukasDamage;
            Figher1Hp = Math.Max(0, Figher1Hp);

            Console.WriteLine($"{Fighter2Name} gör {LukasDamage} skada på {Fighter1Name}");
        }

        Console.WriteLine();
        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
        Console.ReadKey();
    }
}

Console.Clear();

Console.WriteLine("Striden tog slut!");
Console.WriteLine();

if (Figher1Hp == 0 && Fighter2Hp == 0)
{
    Console.WriteLine("OAVGJORT");
}
else if (Figher1Hp == 0)
{
    Console.WriteLine($"{Fighter2Name} vann striden!");
}
else
{
    Console.WriteLine($"{Fighter1Name} vann striden!");
}

Console.WriteLine();
Console.WriteLine("Tryck på valfri knapp för att avsluta!");
Console.ReadKey();
