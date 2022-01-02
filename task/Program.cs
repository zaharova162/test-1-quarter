// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 




int[] a = new int[10];
Random rnd;
rnd = new Random();
for (int i = 1; i < 10; i++)
{
    a[i] = rnd.Next(1, 30);
}
for (int i = 1; i < 10; i++)

    Console.Write(a[i] + " ");

Console.WriteLine();

for (int i = 1; i < 10; i++)
{
    if(a[i]%2==0)
    {
        Console.Write(a[i] + " ");
    }
}