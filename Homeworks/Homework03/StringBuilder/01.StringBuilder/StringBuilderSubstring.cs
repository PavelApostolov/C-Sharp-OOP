/*
   Problem 1. StringBuilder.Substring
   Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */
namespace StringBuilder
{
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder final = new StringBuilder();
            for (int i = index, z = 0; z < length; i++, z++)
            {
                final.Append(input[i]);
            }
            return final;
        }
    }
}