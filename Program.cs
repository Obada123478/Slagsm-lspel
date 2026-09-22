int ObadaHp = 100;
int LukasHp = 100;

string Obada = "Obada";
string Lukas = "Lukas";

while (ObadaHp > 0 && LukasHp > 0)
{
    Console.WriteLine("En ny runda");
    Console.WriteLine($"{Obada}: {ObadaHp}  {Lukas}: {LukasHp}\n");

    int ObadaDamage = Random.Shared.Next(20);
    LukasHp -= ObadaDamage;
    LukasHp = Math.Max(0, LukasHp);

    Console.WriteLine($"{Obada} gör {ObadaDamage} skada på {Lukas}");

    int LukasDamage = Random.Shared.Next(20);
    ObadaHp -= LukasDamage;
    ObadaHp = Math.Max(0, ObadaHp);
    Console.WriteLine($"{Lukas} gör {LukasDamage} skada på {Obada}");

    Console.WriteLine("Du får trycka på valfri knapp nu för att fortsätta.");
    Console.ReadKey();
}

Console.WriteLine("\n STriden tog sitt slut!");

if (ObadaHp == 0 && LukasHp == 0)
{
    Console.WriteLine("OAVGJORT");
}
else if (ObadaHp == 0)
{
    Console.WriteLine($"{Lukas} vann striden!");
}
else
{
    Console.WriteLine($"{Obada} vann striden!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();