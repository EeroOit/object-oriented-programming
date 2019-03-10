using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProductsRegister
{
    class FileManager
    {
        public string filePath;

        public FileManager()
        {
            this.filePath = @"C:\ProductsRegister\items.json"; // items.json must be in the file path defined here.
        }

        public string ReadWords()
        {
            string list = String.Empty;
            try
            {
                list = ReadFile();
                return list;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<ItemsList> itemList = JsonConvert.DeserializeObject<List<ItemsList>>(File.ReadAllText(this.filePath));

                foreach (ItemsList items in itemList)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"Name: {items.name}" +
                        $"\nItem number: {items.id}" +
                        $"\nGroup name: {items.groupName}");
                }

                Console.WriteLine("\nDo you wish to search all information from specific product?");
                Console.WriteLine("1 = Yes");
                Console.WriteLine("2 = No");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Input respective product id to display all info: ");
                    string Id = Console.ReadLine();
                    bool search = false;

                    foreach (ItemsList item in itemList)
                    {

                        if (Id == item.id)
                        {
                            search = true;
                            Console.WriteLine($"Name: {item.name}\nItem number:" +
                                                            $"{item.id} \nPrice: {item.price} +" +
                                                            $"\nGroup: {item.groupName}" +
                                                            $"  \nAmount: {item.amount}+" +
                                                            $"\nComment: {item.comment}\n");
                        }
                    }
                    if (search != true)
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("Press anything to return to the main menu.");
                }

                else
                {
                    Console.WriteLine("------------------\nWrong input.\nPress anything to return to the main menu.");
                }
            }

            else if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not available. Make the file path is correct.");
            }


            return "";
        }

        public string ProductGroups(string groupNumber)
        {
            if (File.Exists(filePath))

            {
                List<ItemsList> itemList = JsonConvert.DeserializeObject<List<ItemsList>>(File.ReadAllText(this.filePath));

                foreach (ItemsList item in itemList)
                {
                    if (groupNumber == "1")
                    {
                        if (item.groupName == "Lajittelu ja säilytys")
                        {
                            Console.WriteLine($"Name: {item.name}\nItem number:" +
                                                            $"{item.id} \nPrice: {item.price} +" +
                                                            $"\nGroup: {item.groupName}" +
                                                            $"  \nAmount: {item.amount}+" +
                                                            $"\nComment: {item.comment}\n");
                        }
                    }
                    else if (groupNumber == "2")
                    {
                        if (item.groupName == "Paperit ja lehtiöt")
                        {
                            Console.WriteLine($"Name: {item.name}\nItem number:" +
                                                            $"{item.id} \nPrice: {item.price}" +
                                                            $"\nGroup: {item.groupName}" +
                                                            $"  \nAmount: {item.amount}+" +
                                                            $"\nComment: {item.comment}\n");

                        }
                    }
                    else if (groupNumber == "3")
                    {
                        if (item.groupName == "Kynät")
                        {
                            Console.WriteLine($"Name: {item.name}\nItem number:" +
                                                            $"{item.id} \nPrice: {item.price}" +
                                                            $"\nGroup: {item.groupName}" +
                                                            $"  \nAmount: {item.amount}+" +
                                                            $"\nComment: {item.comment}\n");
                        }
                    }
                    else if (groupNumber == "4")
                    {
                        if (item.groupName == "Kortit ja kirjekuoret")
                        {
                            Console.WriteLine($"Name: {item.name}\nItem number: +" +
                                                            $"{item.id} \nPrice: {item.price} +" +
                                                            $"\nGroup: {item.groupName}" +
                                                            $"  \nAmount: {item.amount}+" +
                                                            $"\nComment: {item.comment}\n");
                        }
                    }

                    else
                    {
                        Console.WriteLine("------------------\nWrong input.\nPress anything to return to the main menu.");

                    }
                }
            }
            else if (!File.Exists(filePath))
            {
                Console.WriteLine("File not available. Make sure the file path is correct.");
            }

            return "";
        }



        public void OutOfStock()
        {

            if (File.Exists(filePath))

            {
                List<ItemsList> productList = JsonConvert.DeserializeObject<List<ItemsList>>(File.ReadAllText(this.filePath));

                foreach (ItemsList item in productList)
                {
                    if (item.amount == 0)
                    {
                        Console.WriteLine($"Name:{item.name}" +
                            $"\nItem number:{item.id}" +
                            $"\nGroup name: {item.groupName}" +
                            $"\nPrice: {item.price}" +
                            $"\nAmount: {item.amount}" +
                            $"\nComment: {item.comment}\n");
                    }
                }
            }
            else if (!File.Exists(filePath))
            {
                Console.WriteLine("File not available. Make sure the file path is correct.");
            }

            return;
        }

        public void EditComment()
        {
            if (File.Exists(filePath))

            {
                List<ItemsList> productList = JsonConvert.DeserializeObject<List<ItemsList>>(File.ReadAllText(this.filePath));

                int i = 0;
                foreach (ItemsList item in productList)
                {
                    Console.WriteLine($"{i + 1}. {item.name}");
                    i++;
                }
                Console.WriteLine("--------------------------");
                Console.WriteLine("Input the name of the product you wish to edit:");
                string commentItem = Console.ReadLine();
                bool FoundItem = false;

                foreach (ItemsList item in productList)
                {
                    if (item.name == commentItem)
                    {
                        FoundItem = true;

                        Console.WriteLine("Enter 1 to add comment.\nEnter 2 to delete old comments.");
                        string choice = Console.ReadLine().ToUpper();

                        if (choice == "1")
                        {
                            Console.WriteLine("Comment: ");
                            string Comment = Console.ReadLine();

                            if (item.comment.Replace("   ", "") != Comment)
                            {
                                item.comment += Comment + "   ";

                                File.WriteAllText(filePath, JsonConvert.SerializeObject(productList));
                                Console.WriteLine($"Comment has been added: {Comment}");
                                Console.WriteLine("------------------\nPress anything to return to the main menu.");
                            }
                            else if (item.comment.Replace("   ", "") == Comment)
                            {
                                Console.WriteLine("Comment already exists!");

                            }
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine($"Deleted comment: {item.comment}");
                            item.comment = "";
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(productList));
                            Console.WriteLine("------------------\nPress anything to return to the main menu.");
                        }
                        else
                        {
                            Console.WriteLine("------------------\nWrong input.\nPress anything to return to the main menu.");
                        }
                    }
                }
                    if (FoundItem != true)
                    {
                        Console.WriteLine("Product doesn't exist.");
                    }

                }

                  else if (!File.Exists(filePath))
            {
                Console.WriteLine("File not available. Make sure the file path is correct.");
            }
        }
    }
}