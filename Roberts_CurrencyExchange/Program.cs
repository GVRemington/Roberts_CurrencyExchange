// S\.]=l-k0=iure3ee https://aka.ms/new-console-template for more information

//Rayleen Roberts
//IT121
//Notes: This seems like A LOT of Code
//Behaviors Not Implemented and Why: None that I know of
ConsoleKeyInfo StayOrGo;
Roberts_CurrencyExchange.ExMon ExchangeMonitor = new Roberts_CurrencyExchange.ExMon();
double curToEx;
ConsoleKeyInfo convFrom;
ConsoleKeyInfo convTo;

Console.WriteLine("\tHi, do you have currency to exchange? Press C to Begin\n");
StayOrGo = Console.ReadKey();
while (StayOrGo.Key == ConsoleKey.C)
{
    ExchangeMonitor.setExCount(1);
    Console.WriteLine("\tPlease Refer to this Chart: U=USD...C=CAD...G=GBP...E=EURO\n");
    Console.WriteLine("\tPlease Select Currency Type to Exchange ");
    convFrom = Console.ReadKey();
    Console.WriteLine("\tPlease Select Currency You Want to Exchange To ");
    convTo = Console.ReadKey();
    Console.Write("\tPlease Type the Amount to Be Exchanged (in Numbers Only), Then Hit Enter to Convert ");
    curToEx=double.Parse(Console.ReadLine());   
    if (convFrom.Key == ConsoleKey.U && convTo.Key == ConsoleKey.C)
    {
        Console.WriteLine("\n\t{0} USD converts to {1} CAD ", curToEx, Roberts_CurrencyExchange.CurEx.USD_CAN(curToEx));
    }
    if (convFrom.Key == ConsoleKey.U && convTo.Key == ConsoleKey.G)
    {
        Console.WriteLine("\n\t{0} USD converts to {1} GBP ", curToEx, Roberts_CurrencyExchange.CurEx.USD_GBP(curToEx));
    }
    if (convFrom.Key == ConsoleKey.U && convTo.Key == ConsoleKey.E)
    {
        Console.WriteLine("\n\t{0} USD converts to {1} EUROS ", curToEx, Roberts_CurrencyExchange.CurEx.USD_EURO(curToEx));
    }
    if (convFrom.Key == ConsoleKey.C && convTo.Key == ConsoleKey.U)
    {
        Console.WriteLine("\n\t{0} CAD converts to {1} USD ", curToEx, Roberts_CurrencyExchange.CurEx.CAN_USD(curToEx));
        ExchangeMonitor.fcToUSD(Roberts_CurrencyExchange.CurEx.CAN_USD(curToEx));
    }
    if (convFrom.Key == ConsoleKey.C && convTo.Key == ConsoleKey.G)
    {
        Console.WriteLine("\n\t{0} CAD converts to {1} GBP ", curToEx, Roberts_CurrencyExchange.CurEx.CAN_GBP(curToEx));
    }
    if (convFrom.Key == ConsoleKey.C && convTo.Key == ConsoleKey.E)
    {
        Console.WriteLine("\n\t{0} CAD converts to {1} EUROS ", curToEx, Roberts_CurrencyExchange.CurEx.CAN_EURO(curToEx));
    }
    if (convFrom.Key == ConsoleKey.G && convTo.Key == ConsoleKey.U)
    {
        Console.WriteLine("\n\t{0} GBP converts to {1} USD ", curToEx, Roberts_CurrencyExchange.CurEx.GBP_USD(curToEx));
        ExchangeMonitor.fcToUSD(Roberts_CurrencyExchange.CurEx.GBP_USD(curToEx));
    }
    if (convFrom.Key == ConsoleKey.G && convTo.Key == ConsoleKey.C)
    {
        Console.WriteLine("\n\t{0} GBP converts to {1} CAD ", curToEx, Roberts_CurrencyExchange.CurEx.GBP_CAN(curToEx));
    }
    if (convFrom.Key == ConsoleKey.G && convTo.Key == ConsoleKey.E)
    {
        Console.WriteLine("\n\t{0} GBP converts to {1} EUROS ", curToEx, Roberts_CurrencyExchange.CurEx.GBP_EURO(curToEx));
    }
    if (convFrom.Key == ConsoleKey.E && convTo.Key == ConsoleKey.U)
    {
        Console.WriteLine("\n\t{0} EUROS converts to {1} USD ", curToEx, Roberts_CurrencyExchange.CurEx.EURO_USD(curToEx));
        ExchangeMonitor.fcToUSD(Roberts_CurrencyExchange.CurEx.EURO_USD(curToEx));
    }
    if (convFrom.Key == ConsoleKey.E && convTo.Key == ConsoleKey.C)
    {
        Console.WriteLine("\n\t{0} EUROS converts to {1} CAD ", curToEx, Roberts_CurrencyExchange.CurEx.EURO_CAN(curToEx));
    }
    if (convFrom.Key == ConsoleKey.E && convTo.Key == ConsoleKey.G)
    {
        Console.WriteLine("\t{0} EUROS converts to {1} GBP ", curToEx, Roberts_CurrencyExchange.CurEx.EURO_GBP(curToEx));
    }
    Console.WriteLine("\n\tDo You Have More Currency to Exchange? Press C for Continue or Press E to Exit ");
    StayOrGo = Console.ReadKey();


    if (StayOrGo.Key == ConsoleKey.E)

    {
        Console.WriteLine("\n\tExchange Report is as Follows...");
        Console.WriteLine("\t{0} Total Exchanges Occurred ", ExchangeMonitor.ExCount);
        Console.WriteLine("\tForeign Currencies Were Exchanged to a Total of ${0} USD", ExchangeMonitor.GetUSD);
        Console.WriteLine("\tThank You for Using Our Exchange.");
        Environment.Exit(0);
    }
}
 

