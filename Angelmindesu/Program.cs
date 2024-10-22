var point = 0;

Console.WriteLine("Hola galero, tienes que llegar a 100 puntos");
while (point < 100)
{
    Console.ReadKey(true);
    point++;
    Console.WriteLine("Tienes " + point + " puntos");
    if (point == 69)
    {
        Console.WriteLine("Nice");
    }
}

Console.WriteLine("Has ganado friki. Presiona cualquier tecla para morir");
Console.ReadKey();