var numberString= string.Empty;
do
{
    Console.Write("Ingresa un número entero o 'S' para salir: ");
    numberString = Console.ReadLine()!.ToLower();
    var numberInt = 0;
    if(numberString == "s")
    {
        break;
    }

    if(int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es impar");
        }
    }
    else
    {
        Console.WriteLine($"{numberString} no es un número entero valido");
    }
} while (numberString != "s");
Console.WriteLine("Fin del programa");
