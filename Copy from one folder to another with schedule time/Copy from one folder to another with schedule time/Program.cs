using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Copy_from_one_folder_to_another_with_schedule_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("D:\\Hello\\Hello.txt", "D:\\Server\\Hello.txt");

            Console.WriteLine("File copy done.");

            Console.ReadLine();
        }
    }
}
