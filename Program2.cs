using System.Collections;
/*
1. Stringbuilder when you want to change a mutable string. String when you are using an immutable 

2. The array class

3. int[] arr = new int[] {0, 1, 2, 3}
Array.sort(arr);

4. You can take advantage of the Count() method or length of the array

5. Only a single data type can be stored in an array

6. CopyTo requires an array to copy elements to while clone returns a new identical array.


//Question 1
int[] arr1 = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9} ;

int[] arr2 = new int[arr1.Length];
for(int i = 0; i < arr1.Length; i++)
{
    arr2[i] = arr1[i];
}
foreach(int num in arr2)
{
    Console.Write(num);
}
Console.WriteLine();
foreach(int num in arr1)
{
    Console.Write(num);
}
Console.WriteLine();
/////////////////////////////////////////

//Question 2
/*bool condition = false;
ArrayList al = new ArrayList();
while(condition == false)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string key = Console.ReadLine();
    string[] stuff = key.Split(' ');
    if(stuff[0] == "+")
    {
        al.Add(stuff[1]);
    }
    else if (stuff[0] == "-")
    {
        al.Remove(stuff[1]);
    }
    else
    {
        al = new ArrayList();
    }
    foreach(object obj in al)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}

//Question 3
static int[] FindPrimesInRange(int startNum, int endNum)
{
    ArrayList pl = new ArrayList();
    int count = 0;
    bool isPrime = true;
    for (int i = startNum; i <= endNum; i++)
    {
        for (int j = 2; j <= endNum; j++)
        {
            if (i != j && i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            pl.Add(i);
            count++;
        }
        isPrime = true;
    }
    int[] arr = new int[count];
    int n = 0;
    foreach(int num in pl)
    {
        arr[n] = num;
        n++;
    }
    return arr;
}

//Question 4
static int[] RotateAndSum(int[] input, int k)
{
    int[] sum = new int[input.Length];
    int[] arr1 = new int[input.Length];
    for(int i = 0; i < k; i++)
    {
        for(int j = 0; j < arr1.Length; j++)
        {
            arr1[(i + 1) % arr1.Length] = input[i];
        }
        for(int j = 0; j < arr1.Length; j++)
        {
            sum[j] = sum[j] + arr1[j];
        }
        arr1 = new int[input.Length];
    }
    return sum;
}

//Question 5
static int[] Longest(int[] input)
{
    int count = 1;
    int max = 0;
    ArrayList al = new ArrayList();
    ArrayList temp = new ArrayList();
    al.Add(input[0]);
    for(int i = 1; i < input.Length; i++)
    {
        if(input[i] == input[i-1])
        {
            temp.Add(input[i]);
            count++;
        }
        else
        {
            if(count > max)
            {
                al = new ArrayList();
                foreach(int num in temp)
                {
                    al.Add((num);
                }
                temp = new ArrayList
            }
        }
    }
}

// Question 7

static int mostFrequent(int[] arr)
{

    Array.Sort(arr);
    int cNum = arr[0];
    int max = 0;
    int count = 1;
    int maxNum = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] == cNum)
        {
            count++;
        }
        else
        {
            cNum = arr[i];
            if(count > max)
            {
                max = count;
                maxNum = arr[i - 1];
            }
        }
    }
    Console.WriteLine("The number " + maxNum + " is the most frequent");
    return maxNum;
}

// Question 1
Console.WriteLine("Give a word to reverse: ");
string word = Console.ReadLine();
string newWord = "";
for(int i = word.Length - 1; i >= 0; i--)
{
    newWord = newWord + word[i];
}

Console.WriteLine(newWord);


/////////////////////
ArrayList list = new ArrayList();
list.Add(".");
list.Add(",");
list.Add(":");
list.Add(";");
list.Add("=");
list.Add("(");
list.Add(")");
list.Add("&");
list.Add("[");
list.Add("]");
list.Add("\"");
list.Add("'");
list.Add("\\");
list.Add("/");
list.Add("!");
list.Add("?");
list.Add(" ");
Console.WriteLine("Give a sentence to reverse: ");
string sent = Console.ReadLine();
string newSent = string.Join(" ", sent.Split('.','?',',',':',';','=','(',')','&','[',']','\"','\'','\\','/','!', ' ').Reverse()).ToString();

Console.WriteLine(newSent);


Console.WriteLine("Enter a sentence for palindromes: ");
string s = Console.ReadLine();
string[] words = s.Split(',','?',' ','!',':','.');
ArrayList p = new ArrayList();
foreach(string word1 in words)
{
    string newWord1 = "";
    for (int i = word1.Length - 1; i >= 0; i--)
    {
        newWord1 = newWord1 + word1[i];
    }
    if(newWord1 == word1)
    {
        p.Add(word1);
    }
}

Console.WriteLine(String.Join(", ", p));
*/

//Last Question
string url = Console.ReadLine();
string[] arr1 = url.Split("://");
string protocol = arr1[0];
string[] arr2 = arr1[1].Split("/");
string server = arr2[0];
string resource = arr2[1];
Console.WriteLine(protocol);
Console.WriteLine(server);
Console.WriteLine(resource);    













