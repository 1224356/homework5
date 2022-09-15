void printArr(int[] arrP)
{
    Console.WriteLine("Массив чисел:");
    Console.Write("[");
    for (int iArrP = 0; iArrP < arrP.Length; iArrP++)
    {
        Console.Write(arrP[iArrP]);
        if (iArrP == arrP.Length - 1) 
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

Random rnd = new Random(0);
// Для удобства визуализации и ограничели потенциальное количество элементов в массиве от 1 до 10
int[] mas = new int[rnd.Next(1, 10)];
int sum = 0;
for (int i = 0; i < mas.Length; i++)
{
    // Для удобства визуализации и ограничели потенциальные значения массива от -100 до 100
    mas[i] = rnd.Next(-100, 100);
    if (i % 2 == 1)
        sum = sum + mas[i]; 
}
printArr(mas);
Console.WriteLine($"Сумма элементов массива с нечетным индексом: {sum}");