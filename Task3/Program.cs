int[] arr = new int[]  { 1, 2, 4, 5, 6, 7, 8, 9 };
int count = arr.Length;
void Rec(int[] arr, int count)
{

    if (count == 0)
    {
        return;
    }
    else
    {
        count--;
        Console.Write(arr[count]+" ");
        Rec(arr, count);
    }
}
Rec(arr, count);