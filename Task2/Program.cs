// 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да
// Размер массива от 5 до 10
// Числа в массива от -20 до 20


namespace GB
{
    class Task2
    {
        static void Main(string[] args)
        {

            // Console.Clear();
            int[] array = new int[new Random().Next(5, 11)];
            FillArray(array);
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(Check(array, number));


        }
        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-20, 21);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static string Check(int[] array, int x)
        {
            string result = "Нет";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x) result = "Да";
                
            }
            return result; 
        }


    }
}
