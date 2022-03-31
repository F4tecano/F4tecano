double a, b, c, delta, x1, x2;
Console.WriteLine("Insira os valores da sua conta de uma equação de segundo grau: ");
Console.Write("A : ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("B : ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("C : ");
c = Convert.ToDouble(Console.ReadLine());

delta = (Math.Pow(b, 2)) - 4 * a * c;
Console.WriteLine("Delta = " + delta);

x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine("X1 = " + x1);
Console.WriteLine("X2 = " + x2);
Console.ReadKey();