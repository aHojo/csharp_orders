using System;

namespace Acme.Common
{
    public static class StringHandler
    {

        public static string InsertSpaces(this string source) // The this keyword makes it an extension method. class and method must be static.
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}