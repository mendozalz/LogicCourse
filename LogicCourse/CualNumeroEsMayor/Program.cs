do
{
    Console.WriteLine("Ingresa 3 números ENTEROS para determinar cual número es mayor");
    Console.WriteLine("Ingresa el primer número ENTERO");
    var n1 = Console.ReadLine();
    Console.WriteLine("Ingresa el segundo número ENTERO");
    var n2 = Console.ReadLine();
    Console.WriteLine("Ingresa el tercer número ENTERO");
    var n3 = Console.ReadLine();

    var number1 =0;
    var number2 = 0;
    var number3 = 0;

    if (int.TryParse(n1, out number1) && int.TryParse(n2, out number2) && int.TryParse(n3, out number3))
    {
        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"El número {number1} es mayor");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"El número {number2} es mayor");
        }
        else
        {
            Console.WriteLine($"El número {number3} es mayor");
        }
    }
    else
    {
        Console.WriteLine("Alguno de los valores ingresados no es un número entero");
        continue;
    }

    Console.WriteLine("Presiona la letra 'S' si deseas salir");
    if(Console.ReadLine()!.ToLower() == "s")
    {
        break;
    }

} while (true);
