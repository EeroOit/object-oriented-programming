using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace FileManager
{
    
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        public FileManager()
        {
            this.filePath = @"C:\Users\Kannettava\source\repos\FileManager\car.json";
        }

        public string ReadWords()
        {
            string content = String.Empty;
            try
            {
                content = ReadFile();

                return content;
            }
            catch (WordListNotFoundException e)
            {
                return e.Message;
            }
            catch (FileNotFoundException e)
            {
                return e.Message;
            }
        }

        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<Car> carList = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(this.filePath));
                Console.WriteLine("List of the cars");
                Console.WriteLine($"Car count: {carList.Count}");
                foreach (Car car in carList)
                    {
                    Console.WriteLine();
                    Console.WriteLine($"Name:{car.Name}\nPrice:{car.Price}\nYear:{car.Year}");

                }
            }

            else if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            return "";
        }
    }
}
