// int n = 10;
int[] array = {2, 17, 12, -14, 9, 21, 32, 36, 8, -92};

int i = 0;

while (i < array.Length) {
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i++;
}