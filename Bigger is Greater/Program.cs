class Result
{

    /*
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        char[] arr = w.ToCharArray();
        int n = arr.Length;

        // Step 1: Find the rightmost character which is smaller than its next character
        int i;
        for (i = n - 2; i >= 0; i--)
        {
            if (arr[i] < arr[i + 1])
            {
                break;
            }
        }

        // If no such character is found, then this is the highest permutation
        if (i < 0)
        {
            return "no answer";
        }

        // Step 2: Find the smallest character on right side of i that is greater than arr[i]
        int j;
        for (j = n - 1; j > i; j--)
        {
            if (arr[j] > arr[i])
            {
                break;
            }
        }

        // Step 3: Swap characters at i and j
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;

        // Step 4: Reverse the sequence from i+1 to end
        Array.Reverse(arr, i + 1, n - i - 1);

        return new string(arr);
    }
    private static string SortString(string str)
    {
        // Convert the string to a character array
        char[] charArray = str.ToCharArray();

        // Sort the character array
        Array.Sort(charArray);

        // Convert the sorted character array back to a string
        return new string(charArray);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
