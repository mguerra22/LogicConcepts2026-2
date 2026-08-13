var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese tres números diferentes");

    Console.Write("Ingrese primer número: ");
    var a = int.Parse(Console.ReadLine());

    Console.Write("Ingrese segundo número: ");
    var b = int.Parse(Console.ReadLine());

    Console.Write("Ingrese tercer número: ");
    var c = int.Parse(Console.ReadLine());

    if (a > b && a > c)
    {
        Console.WriteLine($"El número mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El número mayor es: {b}");
    }
    else
    {
        Console.WriteLine($"El número mayor es: {c}");
    }

    do
    {
      
        Console.Write("¿Deseas continuar [S]i, [N]o?: ");
        answer = Console.ReadLine();
    }

    while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");