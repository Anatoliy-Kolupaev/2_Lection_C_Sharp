int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;  
    return result;  
}
//              0   1   2   3   4   5   6   7   8   - это индексы элементов в массиве
int[] array = {21, 42, 831, 64, 35, 46, 87, 58, 19}; 
int max = Max (
    Max (array [0], array [1], array[2]),
    Max (array [3], array [4], array[5]),
    Max (array [5], array [6], array[8]));

Console.WriteLine(max);