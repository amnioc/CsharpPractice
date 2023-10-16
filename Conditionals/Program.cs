Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
}
else
{
    discountPercentage = 10;
}


if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration <= 1)
        {

            Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
        }
        else
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
        }
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}
else
{
    Console.WriteLine();
}

