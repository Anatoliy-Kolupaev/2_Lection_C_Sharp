int[] array = { 21, 82, 23, 68, 34, 65, 68, 57, 18 };

int n = array.Length;
int find = 68;
int index = 0;
while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}