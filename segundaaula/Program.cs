using System.Globalization;
string[] months = new string[12];

for(int month = 1; month <- 12; month++)
{
    DateTime FirstDay = new DateTime(DateTime.Now.Year, month, 1);
    string name = FirstDay.ToString("MMMM",
    CultureInfo.CreateSpecificCulture("en"));
}

foreach (string month in mouths)
{
    Console.WriteLine($"-> {month}");
}