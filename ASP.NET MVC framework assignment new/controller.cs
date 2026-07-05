//Assume 'basequote' is your starting claculation amount
decimal quotemodifier = 0
    if(caryear<2000)
    {
    //Add an extra charge for older cars(e.g., plus $25)
    quoteModifier+=25;
}
else if (carYear > 2015)
{
    //Add an extra charge for newer cars(e.g., plus $25
    quotemodifier += 25;
}
decimal finalQuote = basequote + quotemodifier;