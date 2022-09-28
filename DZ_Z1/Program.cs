/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Задача 21
*/

int NumberUser(string num)

{
    Console.WriteLine(num);
    int numM = int.Parse(Console.ReadLine());

    return numM;
}

int OneNumber(int num, int index)
{
    while (num / Math.Pow(10, index) > 1)
    {
        num = num / 10;
    }
    return num;
}


int LastNumber(int numb)
{
    int lastNumber = 0; // почему то я думал, что можно создавать переменные прям в if.
    if (numb < 0) numb *= -1;
    if (numb > 99)
    {

        lastNumber = numb %=100; // (почему не смог создать тут переменную ( а пришлось выносить ) int lastNumber при запуске выдет ошибку (Имя "lastNumber" не существует в текущем контексте)
                                                 // numb %= Math.Pow(10, index); почему нельзя так? почему пишит про преобразования =))  ( хотя в методе выше все норм что то не понимаю int OneNumber(int num, int index))можно было бы добавить уневерсальности                      
    }
    else if (numb > 9)
    {
        lastNumber = numb % 10;
    }

    else
    {
        Console.WriteLine("Введите число больше 9");
    }
    return lastNumber;

}

void PalidromM(int num1, int num2, int index)
{
    if (num1 / 10 == num2 % 10 && num1 % 10 == num2 / 10) //(num1 %= 10 == num2 / Math.Pow(10, index) && num2 %= 10 == num1 / Math.Pow(10, index))
    {
        Console.WriteLine("Вы ввели полидром");
    }


    else
    {
        Console.WriteLine("Введенное число не полидром");
    }


}

int number = NumberUser("Введите пятизначное число");
int x = LastNumber(number);
int y = OneNumber(number, 2);
Console.WriteLine(x);
Console.WriteLine(y);
PalidromM(x, y, 2);


