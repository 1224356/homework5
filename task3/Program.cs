void printArr(double[] arrP)
{
    Console.Write("Массив чисел: ");
    Console.Write("[");
    for (int iArrP = 0; iArrP < arrP.Length; iArrP++)
    {
        Console.Write(arrP[iArrP]);
        if (iArrP == arrP.Length - 1) 
            Console.WriteLine("]");
        else
            Console.Write(" ");
    }
}

Random rnd = new Random(0);
// Для удобства визуализации и ограничели потенциальное количество элементов в массиве от 1 до 10
double[] mas = new double[rnd.Next(1, 10)];
for (int i = 0; i < mas.Length; i++)
{
    // Для удобства визуализации и ограничели потенциальные значения массива от -100 до 100
    mas[i] = rnd.Next(-100, 100);
}
printArr(mas);
double Min = mas[0];
double Max = mas[0];
for (int j = 1; j < mas.Length; j++)
{
    if (Min > mas[j])
        Min = mas[j];
    if (Max < mas[j])
        Max = mas[j];
}
Console.WriteLine($"Max = {Max}, Min = {Min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Max - Min}");