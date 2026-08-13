var numberString = String.Empty;
do
{
    Console.Write("Ingrese número o ´salir´para terminar:");
    numberString = Console.ReadLine();
    if(numberString!.ToLower() =="salir")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número: {numberInt}, es par.");

        }
        else
        {
            Console.WriteLine($"El número: {numberInt}, es impar.");
        }
    }
    else
    {

        Console.WriteLine($"El número ingresado: {numberString}, no es valido. Solo utilice carácteres numéricos.");

    }
  
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over.");


