// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты первой точки через пробел:");
int[] point1 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите координаты второй точки через пробел:");
int[] point2 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine(
                        Math.Round(Math.Sqrt(Math.Pow(point2[0]-point1[0], 2) + 
                                   Math.Pow(point2[1]-point1[1], 2) + 
                                   Math.Pow(point2[2]-point1[2], 2) ),2) );
