namespace ReverseString_2Pointers;

internal class Program
{
    private static void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char temp = s[left];
            s[left++] = s[right];
            s[right--] = temp;
        }
    }
    static void Main(string[] args)
    {
        char[] s1 = [ 'h', 'e', 'l', 'l', 'o' ];
        ReverseString(s1);
    }
}
