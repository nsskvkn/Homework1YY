using System;
using Homework;
class Program
{
    static void Main()
    {
        try
        {
            var arr = new SafeArray(5);
            Console.WriteLine("Довжина = " + arr.Length);

            arr[2] = 10;
            Console.WriteLine("arr[2] = " + arr[2]);

            arr[10] = 5;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
