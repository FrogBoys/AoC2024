namespace Days;

public class Day3: IDay
{
    private string _date;

    public override string Date
    {
        get
        {
            return "03/12/2024";
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
            return 3;
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