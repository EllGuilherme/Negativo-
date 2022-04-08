int numero;
  
Console.WriteLine("Digite um número: "); 
numero = Convert.ToInt32(Console.ReadLine());

 if (numero < 0)


Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(" Você digitou um número negativo.");
Console.ResetColor();