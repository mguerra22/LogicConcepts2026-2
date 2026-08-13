using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString           ("Ingrese nombre________________________: ");
    var workHours = ConsoleExtension.GetFloat       ("Ingrese número de horas trabajadas____: ");
    var hourValue = ConsoleExtension.GetDecimal     ("Ingrese valor hora____________________: ");
    var salaryMimimun = ConsoleExtension.GetDecimal ("Ingrese valor salario mínimo mensual__: ");

    var salary = (decimal)workHours * hourValue;
    if (salary < salaryMimimun)
    {
        Console.WriteLine($"Nombre______________________________: {name}");
        Console.WriteLine($"Salario_____________________________: {salaryMimimun:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre______________________________: {name}");
        Console.WriteLine($"Salario_____________________________: {salary:C2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");