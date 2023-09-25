// Модифицированный поиск элеметов в массиве
// в котором идет рандомный подбор элементов
void FillArray(int[] collection) {
    int length = collection.Length; // .length  - длина (количество элеметов) в массиве
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1, 15);
        index++;
    }
}
// выше представлен метод заполнения массива рандомными числами от 1 до 14 включительно
void PrintArray(int[] col) {
    int count = col.Length;
    int position = 0;
    while (position < count) {
        Console.WriteLine(col[position]);
        position++;
    }
}
// выше представлен метод печати массива, который был заполнен рандомно 
int IndexOf(int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count) {
        if (collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
// описан метод нахождения позиции искомого значения в массиве
int[] array = new int[15]; // new int - функция создания массива из 15 элементов, заполненные 0 по умолчанию

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 777);
Console.WriteLine(pos);