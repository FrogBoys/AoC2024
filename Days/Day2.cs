namespace Days;

public class Day2: IDay
{
    private string _date;

    public override string Date
    {
        get
        {
            return "02/12/2024";
        }
        set
        {
            _date = value;
        }
    }

    private string _dayNumber;

    public override int DayNumber
    {
        get
        {
            return 2;
        }
        set
        {
            _dayNumber = value.ToString();
        }
    }

    public override void Run()
    {
    }

    public override void Part1()
    {
        throw new NotImplementedException();
    }

    public override void Part2()
    {
        throw new NotImplementedException();
    }
}