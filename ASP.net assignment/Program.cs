csharp
    //calculate the quote total based on user inputs
    decimal monthlyTotal=50m; //Base price

    //1b-1d; Age calculations
    int age = DateTime.Now.Year - user.DateOfBirth.Year;
    if (user.DateOfBirth.AddYears(age) > DateTime.Now) age--; //Adjust for birthdate not yet reached this year

    if(age <=18)
    {
         monthlyTotal += 100;
    }
    else if(age>=19 && age <=25)
{
    monthlyTotal += 50;
}
else if(age>=26)
{
    monthlyTotal += 25;
}
    //1g-1h:Car Make and Model calculations
    if(user.CarMake.ToLower()=="porsche")
{
    monthlyTotal += 25;
    if(user.CarModel.ToLower()=="911 carrera")
    {
        monthlyTotal += 25;
    }
}
//1i:Speeding tickets ($10 per ticket)
monthlyTotal += (user.SpeedingTickets * 10);
//1j:DUI check (Add 25%)
if (user.HasDui)
{
    monthlyTotal *= 1.25m;
}
//1k:Full coverage check(Add 50%)
if (user.IsFullCoverage)
{
    monthlyTotal *= 1.50m;
}
//Save the final total to the model
user.Quote = monthlyTotal;

