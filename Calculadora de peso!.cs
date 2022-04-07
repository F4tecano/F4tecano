{//inicio
	Console.BackgroundColor = ConsoleColor.DarkBlue;

	Console.Clear();

	double peso, soma, a, kg, acrescimo; // Criar um programa que leia o salario minimo do cliente e informe 
							  // e quantos salarios minimos ele tem, utilizando moldura e cores 

	Console.SetCursorPosition(15, 5);
	Console.WriteLine("Conversão de peso e com acrecimo de 10% ");
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
	Console.Write("Insira seu Peso! ");
	kg = Double.Parse(Console.ReadLine());
	Console.SetCursorPosition(11, 8);
	Console.Write("Insira seu Peso Para acrescentar 10% ");
	a = Convert.ToDouble(Console.ReadLine());
	Console.SetCursorPosition(11, 9);
	peso = kg * 1000;
	acrescimo = a * 1.10;
	Console.SetCursorPosition(12, 10);
	Console.WriteLine("Seu Peso Convertido em GRAMAS é de: " + peso); // não sei como colocar outro writeline na mesma linha dps da variavel em +a "texto aqui");
	Console.SetCursorPosition(12, 11);
	Console.WriteLine("Seu peso com acrecimo de 10% é: " + Math.Round(acrescimo, 1));
	Console.ReadKey();






}//fim


