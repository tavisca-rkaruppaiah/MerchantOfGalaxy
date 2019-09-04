namespace MerchantOfGalaxy
{
    public class Dialog
    {
        public static string TypeOf(string dialog)
        {
            if(dialog.EndsWith("?"))
            {
                return Customer.Ask(dialog);
            }
            else
            {
                return Merchant.Tell(dialog);
            }
        }
    }

   
}
