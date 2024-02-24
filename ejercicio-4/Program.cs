//Ejercicio 1
for (int num = 2; num <= 10; num++)
{

    Console.WriteLine(num); num++;
}

//Ejercicio 2

int n = 0;
Random random = new Random();
int randomNumber = random.Next(1, 100);

do
{
    try
    {
        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine()!);

        if (n == randomNumber)
        {
            Console.WriteLine($"Adivinaste el numero random -> {n}");
            break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
} while (n != randomNumber);

//ejercicio 3

int n = 1;

while (true)
{
    try
    {
        if (n % 7 == 0 && n % 11 == 0)
        {
            Console.WriteLine($"El primer numero positivo entre 7 y 11 es {n}");
            break;
        }

        n++;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
}

//ejercicio 4

int n= 0;
int result = 0;

do
{
    try
    {
        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine()!);
        result = result + n;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
} while (n >= 0);

Console.WriteLine($"La suma de los numero enteros es {result}");

do
{
    try
    {
        Console.WriteLine("Ingrese la contraseña: ");
        userPass = Console.ReadLine()!;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
} while (userPass != pass);

Console.WriteLine($"Bienvenido al sistema!");