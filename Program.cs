namespace Assignments_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new int[] { 1, 5, 3 }, 5));
            Console.WriteLine(Search(new int[] { 9, 8, 3 }, 3));
            Console.WriteLine(Search(new int[] { 1, 2, 3 }, 4));
        }

        static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

