/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Distance(int x1, int d1, int z1, int x2, int d2, int z2)
{
   double dist =Math.Pow((Math.Pow(x2 - x1, 2) +  Math.Pow(d2 - d1, 2) + Math.Pow(z2 - z1, 2)*1.0), 0.5); // Долго думал и выдовало Отсутствует аргумент, соответствующий требуемому формальному параметру "y" из "Math.P 
//ow(double, double) мне подсказали что добавить 2 числа 1.0), 0.5) ( а что это зачислы и почему так и не понял )
                          //Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 2);
    System.Console.WriteLine("расстояние между точками   " + dist);
}
Console.WriteLine("Введите координаты первой точки" );
int x1 = int.Parse(Console.ReadLine());
int d1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки" ); 
int x2 = int.Parse(Console.ReadLine()); 
int d2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
Distance(x1,d1,z1,x2,d2,z2);




