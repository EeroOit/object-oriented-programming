using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine(fileManager.ReadWords());


        }
    }
}
