using System.Data;
using System.Diagnostics;

class Program
{
    readonly static int[] ValuesToTest = { 10000, 1000000, 10000000 };
    readonly static int[] ExtraColumnsInDt = { 0, 10, 100 };

    static void Main()
    {
        PreBurn();

        foreach (int n in ValuesToTest)
        {
            foreach (var m in ExtraColumnsInDt)
            {
                Console.WriteLine($"{n.ToString("#,##0")} values and {m.ToString("#,##0")} extra columns in the datatable");
                RunBenchmark(n, m);
                Console.WriteLine("\n");
            }
        }
    }

    private static void RunBenchmark(int num_values, int extra_columns_dt)
    {
        int[] arr = CreateTestingArray(num_values);
        var arrTime = TimeAction(() =>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Sqrt(arr[i]);
            }
        });
        Console.WriteLine($"Array: {arrTime.ToString("#,##0")}ms");


        List<int> list = CreateTestingList(num_values);
        var listTime = TimeAction(() =>
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (int)Math.Sqrt(list[i]);
            }
        });
        Console.WriteLine($"List: {listTime.ToString("#,##0")}ms");


        DataTable dt = CreateTestingDataTable(num_values, extra_columns_dt);
        var dtTime = TimeAction(() =>
        {
            foreach (DataRow row in dt.Rows)
            {
                row[0] = (int)Math.Sqrt((int)row[0]);
            }
        });
        Console.WriteLine($"DataTable: {dtTime.ToString("#,##0")}ms");
    }

    static long TimeAction(Action action)
    {
        var watch = Stopwatch.StartNew();
        action();
        watch.Stop();
        return watch.ElapsedMilliseconds;
    }

    static List<int> CreateTestingList(int n)
    {
        var list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            list.Add(i);
        }
        return list;
    }

    static int[] CreateTestingArray(int n)
    {
        var arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        return arr;
    }

    static DataTable CreateTestingDataTable(int n, int m)
    {
        var dt = new DataTable();
        foreach (var i in Enumerable.Range(0, m + 1))
        {
            dt.Columns.Add($"Column{i}", typeof(int));
        }

        for (int i = 0; i < n; i++)
        {
            var row = dt.NewRow();
            for (int j = 0; j < m + 1; j++)
            {
                row[j] = i + j;
            }
            dt.Rows.Add(row);
        }

        return dt;
    }

    static void PreBurn()
    {
        var arr = new int[1000000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
    }
}


