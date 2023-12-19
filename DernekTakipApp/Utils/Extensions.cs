namespace DernekTakipApp.Utils
{
    public static class Extensions
    {
        public static double ToDouble(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0.0;
            }
            else if (double.TryParse(str, out double result))
            {
                return result;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
