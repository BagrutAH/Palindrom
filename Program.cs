﻿// See https://aka.ms/new-console-template for more information
int[] arr2Check = { 1, 2, 3, 4, 3, 2, 1 };
Console.WriteLine("Hello, World!");
//PrintArr1(arr2Check);

CheckIfPalindrom(arr2Check);

static void PrintArr(int[] arr)
{
    Console.Write("[");
    foreach (int n in arr)
        Console.Write(n + " ");
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

static void CheckIfPalindrom(int[] arr2Check)
{
    bool isPalindrom = true;//מניחים שהמערך שקיבלנו הוא פלינדרום
    int maxArrIndx = arr2Check.Length - 1;//חישוב האינדקס המקסימלי במערך
    int halfL = arr2Check.Length / 2;//חישוב אורך חצי המערך
    for (int i = 0; i < halfL; i++)//מבצעים השוואה בין הזוגות המתאימים
    //IsPalindrom אם מאתרים זוג לא זהה מעדכנים את המשתנה 
    //ויוצאים מן הלולאה
    {
        Console.WriteLine(arr2Check[i] + " " + arr2Check[maxArrIndx - i]);
        if (arr2Check[i] != arr2Check[maxArrIndx - i])
        { isPalindrom = false; break; }
    }
    PrintArr1(arr2Check);
    if (isPalindrom)
    {
        Console.WriteLine(" Is Palindrom");
    }
    else Console.WriteLine(" Is not Palindrom");
}