// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
/*
Boolean palindrom(int num)
{
return (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10); 
}

 Console.WriteLine("Введите пятизначное число");
 int n = Convert.ToInt32(Console.ReadLine());
 if (n > 9999 && n < 100000 && palindrom(n)) 
 Console.WriteLine("Введенное число является палиндромом"); 
 else if (n < 10000 || n > 99999)
 {Console.WriteLine("Ошибка ввода. Введите пятизначное число");}
 else 
 Console.WriteLine("Введенное число не является палиндромом");
*/


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A(3, 6, 8); B(2, 1, -7), -> 15.84

// A(7, -5, 0); B(1, -1, 9)-> 11.53

/* double Rasst(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

}

Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("x:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("x:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($" Расстояние между точками: {Math.Round(Rasst(x1, y1, z1, x2, y2, z2), 2)}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


/*void CubesTable(int N)
{
     int count = 1;
     int cube = 0;
     while (count <= N)
     {
         cube = count * count * count;
         Console.WriteLine(count + " - " + cube);
         count ++;
     }
 }


 Console.WriteLine("Введите число");
 int N = Convert.ToInt32(Console.ReadLine());
 CubesTable(N);
 */


