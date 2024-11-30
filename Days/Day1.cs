namespace Days;

public class Day1: IDay
{
    private string _date;

    public override string Date
    {
        get
        {
            return "01/12/2024";
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
            return 1;
        }
        set
        {
            _dayNumber = value.ToString();
        }
    }

    public override void Run()
    {
    }
}