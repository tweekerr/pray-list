namespace ChurchPrayList.Extensions;

public static class StringExtensions
{
    public static string FixedStr(this string s, int length, char padChar = ' ')
        => string.IsNullOrEmpty(s) ? new string(padChar, length) : s.Length > length ? s.Remove(length) : s.Length < length ? s.PadLeft(length, padChar) : s;
}