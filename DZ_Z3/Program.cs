/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int NumberUser(string num)

{
    Console.WriteLine(num);
    int numM = int.Parse(Console.ReadLine());

    return numM;
}
void Number(int numb, int degrees, int step)
{
    int a = numb;
    int b = degrees;
    int c = step;
        while (a <= b)
    {



        Console.Write(Math.Pow(a, c) + "\t");

        a++;

    }



}

int numberLin = NumberUser("введите число N");
int oneNumber = 1;
Number(oneNumber, numberLin, 1);
Console.WriteLine();
Number(oneNumber, numberLin, 3);



/*Почему я не могу без создания переменных использовать аргументы ?????
C:\Users\Professional\Desktop\Work_C#\DZ_Z3\Program.cs(14,5): error CS8112: Локальная функция "Number(int, int, int)" должна объявить тело, так как она не помечен 
а как "static extern". [C:\Users\Professional\Desktop\Work_C#\DZ_Z3\DZ_Z3.csproj]
C:\Users\Professional\Desktop\Work_C#\DZ_Z3\Program.cs(17,9): error CS0103: Имя "nub" не существует в текущем контексте. [C:\Users\Professional\Desktop\Work_C#\DZ 
_Z3\DZ_Z3.csproj]
C:\Users\Professional\Desktop\Work_C#\DZ_Z3\Program.cs(20,17): error CS0103: Имя "degrees" не существует в текущем контексте. [C:\Users\Professional\Desktop\Work_ 
C#\DZ_Z3\DZ_Z3.csproj]
C:\Users\Professional\Desktop\Work_C#\DZ_Z3\Program.cs(23,32): error CS0103: Имя "numb" не существует в текущем контексте. [C:\Users\Professional\Desktop\Work_C#\ 
DZ_Z3\DZ_Z3.csproj]
C:\Users\Professional\Desktop\Work_C#\DZ_Z3\Program.cs(23,37): error CS0103: Имя "step" не существует в текущем контексте. [C:\Users\Professional\Desktop\Work_C#\ 
DZ_Z3\DZ_Z3.csproj]*/