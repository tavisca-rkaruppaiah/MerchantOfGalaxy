namespace MerchantOfGalaxy
{
    public class Merchant
    {
        private static ProductDetails productDetails = new ProductDetails();
        public static string Reply(string dialog)
        {

            if(dialog.StartsWith("how much is "))
            {
                var romanLetter = Galaxy.GetRomanNumberFromDialog(dialog, "how much is ");
                return Galaxy.GetSentenceFromDialog(dialog, "how much is ") + "is " + Decimal.ParseRoman(romanLetter);
                
            }
            else if(dialog.StartsWith("how many Credits is "))
            {
                var romanLetter = Galaxy.GetRomanNumberFromDialog(dialog, "how many Credits is ");
                var letters = Galaxy.GetSentenceFromDialog(dialog, "how many Credits is ").Split(" ");
                var productName = letters[letters.Length - 2];
                return Galaxy.GetSentenceFromDialog(dialog, "how many Credits is ") + "is " + Decimal.ParseRoman(romanLetter) * productDetails.GetProductPrice(productName) + " Credits";
            }
            else
            {
                return "I have no idea what you are talking about";
            }
        }

        public static string Tell(string dialog)
        {
            return dialog;
        }
    }

   
}
