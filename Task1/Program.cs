// 1. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Размер массива от 5 до 10
// Числа в массива от -20 до 20



namespace GB
{
    class Task1
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int[] array = new int[new Random().Next(5, 11)];
            FillArray(array);
            PrintArray(array);


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
                Console.WriteLine($"{array[i]} \t {array[i] * -1}");   //    \t - табуляция 
            }
        }
    }

}
