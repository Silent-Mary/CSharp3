/* 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Input coordinates of two points in 3D space: ");

int numberX1 = Convert.ToInt32(Console.ReadLine()); 
int numberY1 = Convert.ToInt32(Console.ReadLine());
int numberZ1 = Convert.ToInt32(Console.ReadLine()); 
int numberX2 = Convert.ToInt32(Console.ReadLine()); 
int numberY2 = Convert.ToInt32(Console.ReadLine()); 
int numberZ2 = Convert.ToInt32(Console.ReadLine());

double numberXYZ = Math.Sqrt((numberX2 - numberX1)*(numberX2 - numberX1) + (numberY2 - numberY1)*(numberY2 - numberY1) + (numberZ2 - numberZ1)*(numberZ2 - numberZ1));
double roundedNumber = Math.Round(numberXYZ, 2);
Console.WriteLine(roundedNumber);
