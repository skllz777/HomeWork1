// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1-20, 20);
}


void ReleaseArray(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            numbers++;
        
    }
    Console.WriteLine($"Number of positive numbers in the array: {numbers}");
}

Console.Clear();
Console.Write("Enter the number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
