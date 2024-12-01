namespace Days;

public abstract class IDay
{
    public abstract string Date { get; set; }
    public abstract int DayNumber { get; set; }
    public abstract void Run();
    public abstract void Part1();
    public abstract void Part2();
}