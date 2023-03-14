using GlebsApplications;

var price = 0.0f;
while (true)
{
    var stan = new Stanford();
    if (stan.VerifyPrice(72, price)) break;
    price += 0.01f;
}
Console.WriteLine($"The price is ${price}. Total paid=${72 * price}");

