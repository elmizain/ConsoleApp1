using System;

class Program
{
    //static void PrintWelcomeMessage()
    //{
    //    Console.WriteLine("Welcome to the Library!");
    //}

    //static void Main()
    //{
    //    PrintWelcomeMessage();
    //}
    //========================================


    //static void PrintBookTitle(string title)
    //{
    //    Console.WriteLine("Book title: " + title);
    //}

    //static void Main()
    //{
    //    PrintBookTitle("Clean Code");
    //}
    //============================================


    //static void AddBonusPages(int pages)
    //{
    //    pages += 50;
    //}

    //static void Main()
    //{
    //    int pages = 400;
    //    AddBonusPages(pages);
    //    Console.WriteLine(pages);
    //}
    //===========================================
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }

    static void Main()
    {
        double[] prices = { 25.5, 40.0 };

        ApplyDiscount(prices);

        Console.WriteLine(prices[0]);
    }
}


