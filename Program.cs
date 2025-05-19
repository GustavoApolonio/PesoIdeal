double At,  PI;

string Sexo;

Console.Clear();

Console.WriteLine("--Descubra seu peso ideal--");

Console.Write("Olá Viajante, digite sua altura em metros e descobriremos seu peso ideal:  ");
  
At = Convert.ToDouble(Console.ReadLine ());

Console .Write("precisamos saber seu sexo, se você for Homem digite (M), se for mulher digite (F): ");

 
Sexo = (Console.ReadLine())!.ToUpper();


if (Sexo == "M")
{

    Console.WriteLine("você é um homem, iremos calcular seu peso ideal agora.");

    PI = Convert.ToDouble(1);

    PI = (At * 72.7) - 58.0;

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\nE seu peso ideal é {PI:N1}kg");
}
else if (Sexo == "F")
{

    Console.WriteLine("você é uma mulher, iremos calcular seu peso ideal agora.");

    PI = Convert.ToDouble(0);

    PI = (At * 62.1) - 44.7;

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\nE seu peso ideal é {PI:N1}kg");

}
Console.ResetColor();