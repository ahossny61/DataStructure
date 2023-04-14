// See https://aka.ms/new-console-template for more information

int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

Console.WriteLine("     ### Welcome To Binery Search Console App ###\n\n");

Thread.Sleep(1000);

Console.WriteLine("     ## Our Test Array : \n");
Thread.Sleep(1000);
foreach (var item in arr)
{
    Console.Write("     "+item);
    Thread.Sleep(100);
}

Thread.Sleep(500);
Console.WriteLine();

Console.WriteLine("     Please Enter the Target number ");
Console.Write("     ");
int targer =int.Parse (Console.ReadLine().ToString());

Console.WriteLine("     ## Start calling the Binery Search Function\n");
Thread.Sleep(500);
var target = ApplyBinerySearchAlg(arr,targer);

Console.WriteLine("     Remeber the Big O for Binery Search is : Log2 (n)  --- Note if the Array is sorted !");
//Console.WriteLine(target+ "  "+ arr[target]);




int ApplyBinerySearchAlg(int[] sortedArr,int targetItem)
{
    Console.Write("     Starting ");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(".");
    Console.WriteLine();
    

    
    int low = 0;
    int high = sortedArr.Length - 1;

    int step = 0;
    while (low <= high)
    {
        step++;
        Thread.Sleep(3000);
        Console.WriteLine("     Step :" + step);
        Thread.Sleep(200);
        Console.WriteLine("     ##########################################################################################\n\n\n");
        Thread.Sleep(500);
        Console.WriteLine("     The remaning numbers that we will search in \n");
        Thread.Sleep(1000);
        for (int i = low; i <= high; i++)
        {
            Console.Write("     "+sortedArr[i]);
            Thread.Sleep(100);
        }
        int mid = (high + low) / 2;
        int guess = sortedArr[mid];
        Console.WriteLine("\n");
        Thread.Sleep(2000);
        Console.WriteLine("     We Will select the number that in the middle of the Array >>>  " + guess+"\n");
        Thread.Sleep(4000);
        Console.WriteLine("     Check if the selected number is more or less than or equal the Target Number\n");
        Thread.Sleep(4000);

        if (guess == targetItem)
        {
            Console.WriteLine("     Ooh We found it ^_^ , The index of target number is "+mid+" , the total steps is "+step+"\n");
            Thread.Sleep(4000);
            return mid;
        }
        if (guess < targetItem)
        {
            Console.WriteLine("     Sorry ^_^ , The selected number is less than Target >>>   "+ guess + " < " + targetItem+"\n");
            Thread.Sleep(4000);
           
            Console.WriteLine("     We will cut down All number that less than or equal   " + guess + "\n");
            Thread.Sleep(4000);
            
            low = mid + 1;
            Thread.Sleep(4000);
        }
        else
        {
            Console.WriteLine("     Sorry ^_^ , The selected number is bigger than Target   "+ guess + " > " + targetItem + "\n");
            Thread.Sleep(4000);

            Console.WriteLine("     We will cut down All number that more than or equal  " + guess + "\n");
            Thread.Sleep(4000);
            high = mid - 1;
        }
        
    }
    Console.WriteLine("     Oops we couldn't find the Target ^_^\n");
    Thread.Sleep(4000);
    return -1;
   
}
