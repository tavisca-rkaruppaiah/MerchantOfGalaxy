namespace MerchantOfGalaxy
{
    public class Decimal
    {
        public static int ParseRoman(string roman)
        {
            int _valueOfRoman = 0;
            string _roman = roman.ToUpperInvariant();
            for(int index = 0; index<_roman.Length; index++)
            {
                int currentValue = Roman.ValueOfRoman(_roman[index]);
                if(index+1 < _roman.Length)
                {
                    int nextValue = Roman.ValueOfRoman(_roman[index+1]); ;
                    if(currentValue >= nextValue)
                        _valueOfRoman += currentValue;
                    else
                    {
                        _valueOfRoman += nextValue - currentValue;
                        index++;
                    }
                        
                }
                else
                {
                    _valueOfRoman += currentValue;
                    index++;
                }
            }

            return _valueOfRoman;
        }
    }

   
}
