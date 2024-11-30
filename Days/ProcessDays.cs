using System.Reflection;

namespace Days;
public class ProcessDays
{
    public void StartProcessing(int dateNumber)
    {

        var days = GetEnumerableOfType<IDay>();
        
        foreach (var VARIABLE in days)
        {
            if (VARIABLE.DayNumber == dateNumber)
            {
                Console.WriteLine("Starting challenge day " + VARIABLE.DayNumber);
                Console.WriteLine("Date of challenge" + VARIABLE.Date);
            }
        }
    }
    public static IEnumerable<IDay> GetEnumerableOfType<TIDay>(params object[] constructorArgs)
    {
        List<IDay> objects = new List<IDay>();
        foreach (Type type in 
                 Assembly.GetAssembly(typeof(TIDay)).GetTypes()
                     .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(IDay))))
        {
            objects.Add((IDay)Activator.CreateInstance(type, constructorArgs));
        }
        objects.Sort();
        return objects;
    }
}