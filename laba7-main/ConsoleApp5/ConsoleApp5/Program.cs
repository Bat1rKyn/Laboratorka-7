
using System.Threading.Tasks;

namespace ConsoleApp5;
internal class Program
{
    private static void Main(string[] args)
    {
        Create_file();
    }

    private static void Create_file()
    {
        string Name = "Quest";
        Task5_1.Createfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 10, 0, 30, true);
        Task5_1.Reserchfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 1);
        Name = "Quest2";
        Task5_1.Createfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 10, 0, 30, false);
        Task5_1.Reserchfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 2);
        Name = "Quest3";
        Task5_1.Reserchfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 3);

        Name = "Quest4";
        Task5_1.Createfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 10, 0, 30, false);
        Task5_1.Reserchfile($"C:\\Users\\boxer\\Desktop\\YP\\" +
            $"laba7\\ConsoleApp5\\{Name}.txt", 4);
    }
}