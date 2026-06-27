namespace Enum1;

class Program
{
    static void Main(string[] args)
    {
       int daynuber=
(int)DaysOfWeek.Monday;
       Console.WriteLine(daynuber);

       int [] daynumbers = (int[])Enum.GetValues(typeof(DaysOfWeek));
       foreach (int day in daynumbers)
       {
        Console.WriteLine(day);
       }
       int monthnumber = (int)Months.November;
       Console.WriteLine(monthnumber);
    }
}
public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
public enum Months
{
    January=1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November=45,
    December
}