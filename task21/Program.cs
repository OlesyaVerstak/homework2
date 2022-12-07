// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] point = new int[6];
System.Console.WriteLine("Введите координату 1 точки по оси Х: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату 1 точки по оси Y: ");
point[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату 1 точки по оси Z: ");
point[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату 2 точки по оси Х: ");
point[3] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату 2 точки по оси Y: ");
point[4] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату 2 точки по оси Z: ");
point[5] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow(point[3] - point[0], 2) + Math.Pow(point[4] - point[1], 2) + Math.Pow(point[5] - point[2], 2)));
