namespace FindSmallestLetterGreaterThanTarget;

internal class Program
{
    private static char NextGreatestLetter(char[] letters, char target)
    {
        int left = 0;
        int right = letters.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (letters[mid] <= target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left == letters.Length ? letters[0] : letters[left];
    }

    static void Main(string[] args)
    {
        char[] letters = ['c', 'f', 'j'];
        char target = 'a';

        char result = NextGreatestLetter(letters, target);
        Console.WriteLine(result);
    }
}
