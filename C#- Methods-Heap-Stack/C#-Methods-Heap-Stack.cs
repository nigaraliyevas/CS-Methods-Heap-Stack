#region task-1
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
//Console.WriteLine(SumOddNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
/*Console.WriteLine(SumOddNumbers(12,19));
int SumOddNumbers(int n, int m)
{
    int sum = 0;
    if (n < m)
    {
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
            }
        }
    }
    return sum;
}*/
#endregion
#region task-2
//Verilmish arrayin icindeki tek ededlerin cemini tapin.
/*Console.WriteLine(SumOddNumbersInArr(1,5,12,17,10));
string SumOddNumbersInArr(params int[] arr)
{
    int sum = 0;
    foreach (int index in arr)
    {
        if (index % 2 != 0)
        {
            sum += index;
        }
    }
    return sum == 0 ? "Array doesn't contain odd numbers" : $"Sum is {sum}";
}*/
#endregion
#region task-3
//Verilmish arrayin icindeki cut ededlerin sayini tapin.
/*Console.WriteLine(EvenNumbersInArr(7,15,11,13,12));
string EvenNumbersInArr(params int[] arr)
{
    int sum = 0;
    int count = 0;
    foreach (int index in arr)
    {
        if (index % 2 == 0)
        {
            count++;
        }
    }
    if(count == 0)
    {
        return $"Array doesn't contain even numbers";
    }
    else
    {
        foreach (int index in arr)
        {
            if(index % 2 == 0)
            {
                sum += index;
            }
        }
        return $"Sum is {sum}";
    }
}*/
#endregion
#region task-4
// Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
/*Console.WriteLine(PrimeOrComposite(15));
string PrimeOrComposite(int n)
{
    int count = 0;
    for (int i = 1; i<=n; i++)
    {
        if (n % i == 0)
        {
            count++;
        }
    }
    if(count>2)
    {
        return $"{n} murekkeb ededdir";
    }
    else
    {
        return $"{n} sade ededdir";
    }
}*/
#endregion
#region task-5
// n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
// Meselen:Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.
/*int n = int.Parse(Console.ReadLine());
int i = n;
Console.WriteLine(PowerOfTwo(n));
string PowerOfTwo(int num)
{
    if (i > 0)
    {
        while (i % 2 == 0)
        {
            i /= 2;
        }
    }
    if (i == 1)
    {
        return $"{n} num is power of 2";
    }
    else
    {
        return $"{n} num isn't power of 2";
    }
}*/
#endregion
#region task-6
//Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
//Mes ([1,3,55,6,33], cavab : 18).
/*Console.WriteLine(ResultOfArr(22, 25, 55, 21, 33));
string ResultOfArr(params int[] arr)
{
    int total = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>=1 && arr[i]<=20)
        {
            total *= arr[i];
        }
    }
    return total == 1 ? $"Not contained numbers between 1-20" : $"Total is {total}";
}*/
#endregion
#region task-7
//Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
/*Console.WriteLine(PowOfEven(12,15,18,4,1,3));
string PowOfEven(params int[] arr)
{
    int sum = 0;
    foreach (int index in arr) { 
        if(index%2==0) { 
            sum += index;
        }
    }
    return sum==0 ? $"Not contained even numbers... " : $"Power of sum is {sum*sum}";
}*/
#endregion
#region task-8
//int tipindən bir array olur içində müsbət və mənfi ədədlər olur elə bir method yazın ki,
//bu array-i parametr olaraq qəbul etsin və qəbul etdiyi array-in əvvəlcədən assign olunması
//məcburi olsun daha sonra içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın
int[] arr = { 12, -15, 12, 14, -9, -5, 16 };
NegativeArr(arr);
int[] NegativeArr(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] *= -1;
        }
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]+" ");
    }
    return numbers;

}
#endregion

