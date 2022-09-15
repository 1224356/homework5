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
int count = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(100, 999);
    if (Convert.ToDouble(mas[i]) % 2 == 0)
        count++; 
}
printArr(mas);
Console.WriteLine($"В массиве четных чисел: {count}");

