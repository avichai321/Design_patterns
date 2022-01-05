using adapater;

class program
{
    static void Main(string[] args)
    {
        Dollarpay adapter1 = new ConvetToEuro();
        int intx = new Random().Next(10);

        PaymentMethod(adapter1, intx);

    }

    public static void PaymentMethod(Dollarpay swich, double x)
    {
        Console.WriteLine(swich.Dolarpayment(x));
    }

}

