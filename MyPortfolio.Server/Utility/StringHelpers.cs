namespace MyPortfolio.Server.Utility
{
    public class StringHelpers
    {
        /// <summary>
        /// Splits comma separated string into array of strings
        /// e.g. "comma,separated,objects,without,spaces"
        /// </summary>
        /// <param name="str">The string of comma separated strings</param>
        /// <returns>Array of strings</returns>
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string SnakeCase(string str)
        {
            return str.ToLower().Replace(" ", "_");
        }
    }
}
