do
{
    Console.Write("Ingrese número o Ctrol C para terminar:");
    var numberString = Console.ReadLine();
    try
    {
        var numberInt = int.Parse(numberString!);
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número: {numberInt}, es par.");

        }
        else
        {
            Console.WriteLine($"El número_ {numberInt}, es impar.");
        }
    }
    catch 
    {

        Console.WriteLine($"El número ingresado: {numberString}, no es valido. Solo utilice carácteres numéricos.");
        
    }
  
} while (true);


