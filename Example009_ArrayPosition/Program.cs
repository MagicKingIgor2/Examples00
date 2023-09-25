// Имеется одномерный массив из n элементов,
// требуется найти элемент массива, равный find
int[] array = {1, 2 , 3, 44, 36, 47, 8, 569, 4, 78, 0, 7};

int n = array.Length;
int find = 4;
int index = 0;
while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break; // завершает программу, в случае первого совпадения
    }
    index++;
}
