/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] numbers = new int[20];
int count = 0;
Rdnumbers(numbers);

void Rdnumbers(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(10, 99);
}
}

for (int i = 0; i < numbers.Length; i++)
{
    count = count + numbers[i];
    i = i + 1;
}
Console.WriteLine(count);
Console.WriteLine("[{0}]", string.Join(", ", numbers));