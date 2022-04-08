{//inicio
	Console.BackgroundColor = ConsoleColor.DarkBlue;

	Console.Clear();

	double clima, resul, a; // Criar um programa que converta a temperatura para FAHRENHEITTS 
							  //utilizando moldura e cores 

	Console.SetCursorPosition(15, 5);
	Console.WriteLine("Conversão da temperatura para fahrenheitts");
	Console.SetCursorPosition(10, 5);
	Console.WriteLine("╔══════════════════════════════════════════════════╗");
	Console.SetCursorPosition(10, 6);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 7);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 8);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 9);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 10);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 11);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 12);
	Console.WriteLine("║                                                  ║");
	Console.SetCursorPosition(10, 13);
	Console.WriteLine("╚══════════════════════════════════════════════════╝");


	Console.SetCursorPosition(11, 7);
	Console.Write("Insira a temperatura atual: ");
	clima = Double.Parse(Console.ReadLine());
	Console.SetCursorPosition(11, 9);
	a = (clima - 32) / 1.8; //Para converter graus Fahrenheit em graus Celsius, subtraia 32 e divida por 1,8.
	Console.SetCursorPosition(12, 10);
	Console.Write("A temperatura Convertida para Fahrenheit é :  " + Math.Round(+a)); // não sei como colocar outro writeline na mesma linha dps da variavel em +a "texto aqui");
	Console.ReadKey();






}//fim


