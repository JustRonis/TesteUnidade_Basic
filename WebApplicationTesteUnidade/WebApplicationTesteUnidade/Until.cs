namespace WebApplicationTesteUnidade
{
    public static class Until
    {
        public static bool Maiusculo(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);

        }
    }
}
