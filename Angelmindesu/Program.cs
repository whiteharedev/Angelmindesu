float point = 0.00f;
float multiplier = 0.01f;

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
Console.ReadKey(true);

point = 0;

while (multiplier < 1)
{
    Console.WriteLine("SIKE! Vuelves a empezar (sumas " +  " por punto ahora)");
    while (point < 100)
    {
        Console.ReadKey(true);
        point += 1 + multiplier;
        Console.WriteLine("Tienes " + point.ToString("F2") + " puntos");
        if (Math.Abs(point - 69.69f) < 0.01f)
        {
            Console.WriteLine(@" /$$   /$$ /$$                    
| $$$ | $$|__/                    
| $$$$| $$ /$$  /$$$$$$$  /$$$$$$ 
| $$ $$ $$| $$ /$$_____/ /$$__  $$
| $$  $$$$| $$| $$      | $$$$$$$$
| $$\  $$$| $$| $$      | $$_____/
| $$ \  $$| $$|  $$$$$$$|  $$$$$$$f
|__/  \__/|__/ \_______/ \_______/");
        }
    }
    point = 0;
    multiplier = multiplier * 2;
}


Console.WriteLine("Ahora si. Presiona cualquier tecla frikiton");
Console.ReadKey(true);