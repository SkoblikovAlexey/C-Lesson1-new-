int[] array = { 23, 454, 98, 43, 23, 7, 56, 90 };

int n = array.Length;
int find = 23;

int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}