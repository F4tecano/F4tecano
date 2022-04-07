{//inicio
	Console.BackgroundColor = ConsoleColor.DarkBlue;

	Console.Clear();

	double salario, resul, a; // Criar um programa que leia o salario minimo do cliente e informe 
							  // e quantos salarios minimos ele tem, utilizando moldura e cores 

	Console.SetCursorPosition(15, 5);
	Console.WriteLine("Calculando quantos salarios minimos você tem");
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
	Console.Write("Digite seu salario: ");
	salario = Double.Parse(Console.ReadLine());
	Console.SetCursorPosition(11, 9);
	a = salario / 1212;
	Console.SetCursorPosition(12, 10);
	Console.Write("Você tem: " + Math.Round(+a)); // não sei como colocar outro writeline na mesma linha dps da variavel em +a "texto aqui");
	Console.ReadKey();






}//fim