using System.Collections.Generic;

namespace MerchantOfGalaxy
{
    public class Roman
    {
        private static Dictionary<char, int> decimalValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int ValueOfRoman(char letter)
        {
            return decimalValues[letter];
        }
    }

   
}
