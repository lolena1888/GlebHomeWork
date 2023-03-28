using System.Globalization;

namespace GlebsApplications
{
    internal class Stanford
    {
        public bool VerifyPrice(int num, float priceForOne)
        {
            const string compare = "67.9";
            var price = (priceForOne * num).ToString(CultureInfo.InvariantCulture);
            return (!price.EndsWith(compare) && !price.StartsWith(compare) && price.Contains(compare));
        }

        private void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
