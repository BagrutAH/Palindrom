// See https://aka.ms/new-console-template for more information
int[] arr2check = {1, 2, 3, 3,2,1};
Console.WriteLine("Hello, World!");
PrintArr1(arr2check);
static void PrintArr(int[] arr)
{
    Console.Write("[");
    foreach (int n in arr)
        Console.Write(n+" ");
    Console.Write("]");
}
static void PrintArr1(int[] arr)
{
    bool printComa = true;

    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) printComa = false;
        Console.Write(arr[i]);
        if (printComa) Console.Write(",");
    }
    Console.WriteLine("]");
}