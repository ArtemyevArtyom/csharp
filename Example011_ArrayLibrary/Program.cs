void FillArray(int[] collection) /* cоздает и заполняет новый
массив целочисленных элементов случайным количеством случайных элементов.
Размер массива должен быть в диапазоне от 10 до 100 элементов.
Значение каждого элемента должно быть в диапазоне -200 до 200. 
*/
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int [] array = new int[10];

FillArray(array);
PrintArray(array); /*выводит переданный массив
в поток вывода консольного приложения. */
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);