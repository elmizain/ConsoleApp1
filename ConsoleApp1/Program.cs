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
    //static void ApplyDiscount(double[] prices)
    //{
    //    prices[0] -= 5;
    //}

    //static void Main()
    //{
    //    double[] prices = { 25.5, 40.0 };

    //    ApplyDiscount(prices);

    //    Console.WriteLine(prices[0]);
    //}
    //=========================================

    //static void AddBonusPagesByRef(ref int pages)
    //{
    //    pages += 50;
    //}

    //static void Main()
    //{
    //    int pages = 400;

    //    AddBonusPagesByRef(ref pages);

    //    Console.WriteLine(pages);
    //}
    //=========================================

    //static void ReplaceArray(ref double[] prices)
    //{
    //    prices = new double[] { 10.0, 12.5, 15.0 };
    //}

    //static void Main()
    //{
    //    double[] prices = { 25.5, 40.0 };

    //    ReplaceArray(ref prices);

    //    Console.WriteLine(prices.Length);
    //}
    //=============================================

    //static bool TryGetPrice(string title, out double price)
    //{
    //    if (title == "Clean Code")
    //    {
    //        price = 25.5;
    //        return true;
    //    }

    //    price = 0;
    //    return false;
    //}

    //static void Main()
    //{
    //    double price;

    //    if (TryGetPrice("Clean Code", out price))
    //    {
    //        Console.WriteLine(price);
    //    }
    //}
    //=======================================
    //static void PrintBookInfo(string title, int pages = 300)
    //{
    //    Console.WriteLine($"Title: {title}, Pages: {pages}");
    //}

    //static void Main()
    //{
    //    PrintBookInfo("Clean Code");
    //    PrintBookInfo("The Pragmatic Programmer", 450);
    //}
    //=====================================

    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title: {title}, Pages: {pages}");
    }

    static void Main()
    {
        PrintBookInfo(pages: 500, title: "Clean Code");
    }

}






