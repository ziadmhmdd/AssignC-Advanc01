using System.Collections;

namespace AssignC_Advanc01
{
    #region Task01

    // Task01
    //public class RipenessChecker<T> where T : IComparable<T>
    //{
    //    private T lowLimit;
    //    private T highLimit;

    //    // Constructor
    //    public RipenessChecker(T low, T high)
    //    {
    //        lowLimit = low;
    //        highLimit = high;
    //    }

    //    // Method with a different name
    //    public bool CheckRipeness(T level)
    //    {
    //        bool aboveMin = level.CompareTo(lowLimit) >= 0;
    //        bool belowMax = level.CompareTo(highLimit) <= 0;
    //        return aboveMin && belowMax;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("=== Banana Ripeness Checker ===");

    //        // Get range limits
    //        Console.Write("Minimum perfect ripeness: ");
    //        var minVal = Convert.ToDouble(Console.ReadLine());

    //        Console.Write("Maximum perfect ripeness: ");
    //        var maxVal = Convert.ToDouble(Console.ReadLine());

    //        // Create checker object
    //        var checker = new RipenessChecker<double>(minVal, maxVal);

    //        // Get ripeness to test
    //        Console.Write("Enter ripeness to test: ");
    //        var testVal = Convert.ToDouble(Console.ReadLine());

    //        // Show result
    //        string result = checker.CheckRipeness(testVal) ? "Perfect Banana!" : "Not Perfect!";
    //        Console.WriteLine(result);
    //    }
    //} 
    #endregion

    #region Task02
    //public class ItemBox<T>
    //{
    //    private readonly List<T> storage = new List<T>();

    //    public void Add(T element) => storage.Add(element);

    //    public IEnumerable<T> ShowAll() => storage;

    //    public int TotalItems() => storage.Count;

    //    public bool HasNoItems() => storage.Count == 0;
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        // عمل صندوق لتخزين النصوص
    //        var wordsBox = new ItemBox<string>();

    //        // فحص إذا كان الصندوق فاضي
    //        Console.WriteLine(wordsBox.HasNoItems()); // True

    //        // إضافة عنصرين
    //        wordsBox.Add("Mango");
    //        wordsBox.Add("Peach");

    //        // عرض عدد العناصر
    //        Console.WriteLine(wordsBox.TotalItems()); // 2
    //    }
    //} 
    #endregion

    #region Q01

    //#region Interval Class Implementation
    //public class Interval<T> where T : IComparable<T>
    //{
    //    private T startPoint;
    //    private T endPoint;

    //    public Interval(T start, T end)
    //    {
    //        this.startPoint = start;
    //        this.endPoint = end;
    //    }

    //    public bool Contains(T target)
    //    {
    //        bool greaterThanStart = target.CompareTo(startPoint) >= 0;
    //        bool lessThanEnd = target.CompareTo(endPoint) <= 0;
    //        return greaterThanStart && lessThanEnd;
    //    }

    //    public double RangeSize()
    //    {
    //        return Convert.ToDouble(endPoint) - Convert.ToDouble(startPoint);
    //    }
    //}
    //#endregion

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.Write("Minimum: ");
    //        double start = double.Parse(Console.ReadLine());

    //        Console.Write("Maximum: ");
    //        double end = double.Parse(Console.ReadLine());

    //        var range = new Interval<double>(start, end);

    //        Console.Write("Check value: ");
    //        double value = double.Parse(Console.ReadLine());

    //        Console.WriteLine("Inside range? " + range.Contains(value));
    //        Console.WriteLine("Range length: " + range.RangeSize());
    //    }
    //} 
    #endregion

    #region Q02
    //internal class Program
    //{
    //    // Method to reverse ArrayList elements in place
    //    static void ReverseList(ArrayList arr)
    //    {
    //        for (int i = 0; i < arr.Count / 2; i++)
    //        {
    //            int j = arr.Count - 1 - i;
    //            (arr[i], arr[j]) = (arr[j], arr[i]); // tuple swap
    //        }
    //    }

    //    static void Main()
    //    {
    //        ArrayList items = new ArrayList();

    //        Console.Write("How many items? ");
    //        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
    //        {
    //            Console.WriteLine("Invalid number!");
    //            return;
    //        }

    //        Console.WriteLine("Enter your items:");
    //        for (int k = 0; k < n; k++)
    //            items.Add(Console.ReadLine());

    //        Console.WriteLine("\nBefore reverse:");
    //        foreach (var el in items)
    //            Console.Write(el + " ");
    //        Console.WriteLine();

    //        ReverseList(items);

    //        Console.WriteLine("\nAfter reverse:");
    //        foreach (var el in items)
    //            Console.Write(el + " ");
    //        Console.WriteLine();
    //    }
    //} 
    #endregion

    #region Q03
    internal class Program
    {
        static IEnumerable<int> FilterEvens(IEnumerable<int> data)
        {
            return data.Where(x => x % 2 == 0);
        }

        static void Main()
        {
            Console.Write("How many numbers? ");
            if (!int.TryParse(Console.ReadLine(), out int total) || total <= 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            var inputList = new List<int>();

            Console.WriteLine("Enter numbers:");
            for (int idx = 0; idx < total; idx++)
            {
                if (int.TryParse(Console.ReadLine(), out int val))
                    inputList.Add(val);
            }

            var evens = FilterEvens(inputList);

            Console.WriteLine("\nEvens found:");
            Console.WriteLine(string.Join(" ", evens));
        }

    } 
    #endregion
}