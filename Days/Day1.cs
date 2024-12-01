namespace Days;

public class Day1: IDay
{
    private string? _input;
    
    private string _date = null!;

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
        _input = File.ReadAllText("/home/mattias/RiderProjects/AoC_2024/Days/Inputs/InputDay1");
        Part1();
        Part2();
    }

    private static List<int> list1 = new List<int> { 3, 4, 2, 1, 3, 3  };
    private static List<int> list2 = new List<int> { 4, 3, 5, 3 ,9, 3 };

    
    /// <summary>
    /// Part Uno of day one in AoC
    /// </summary>
    public override void Part1()
    {
        var intPuts = GetLists(_input);
        list1 = intPuts.Item1;
        list2 = intPuts.Item2;
        int distCount = 0;
        int length = (list1.Count);
        for (int i = 0; i < length; i++)
        {
            distCount += Subtraction(list2[i], list1[i]); 
        }
        Console.WriteLine("Part 1: " + distCount);
    }

    /// <summary>
    /// Part Dos of day one in AoC
    /// </summary>
    public override void Part2()
    {
        var intPuts = GetLists(_input);
        list1 = intPuts.Item1;
        list2 = intPuts.Item2;        
        int distCount = 0;
        int length = (list1.Count);
        for (int i = 0; i < length; i++)
        {
            var idCount = list2.Where(x => x == list1[i]).ToList().Count;
            distCount += Multiplication(list1[i], idCount); 
        }
        Console.WriteLine("Part 2: " + distCount);
    }

    private int Subtraction(int x, int y)
    {
        return Math.Abs(x - y);
    }
    
    private int Multiplication(int x, int y)
    {
        return Math.Abs(x * y);
    }
    private (List<int>, List<int>) GetLists(string? input)
    {
        input = input.Replace("\n", "    ");
        
        var inputList = input.Split("   ").ToList();
        var splitList1 = new List<int>();
        var splitList2 = new List<int>();
        for (int i = 0; i < inputList.Count; i++)
        {
            if (i % 2 == 0)
                splitList1.Add(int.Parse(inputList[i]));
            else
                splitList2.Add(int.Parse(inputList[i]));
        }
        splitList1 = splitList1.OrderBy(y => y).ToList();
        splitList2 = splitList2.OrderBy(y => y).ToList();
        return (splitList1, splitList2);
    }

}