using System;
using System.IO;

namespace Exercises
{
    class FileRead
    {
        public static void Main()
        {
            string fileName;
            while(true)
            {
                Console.WriteLine("\n1.Create a file");
                Console.WriteLine("\n2.Existence of the file");
                Console.WriteLine("\n3.Read the contents of the file");
                Console.WriteLine("\n4.Exit");
                Console.WriteLine("\nEnter your choice:");
                int ch=int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\nEnter the file name to create:");
                        fileName = Console.ReadLine();
                        Console.WriteLine("\nWrite the Contents to the File:");
                        string r = Console.ReadLine();
                        using (StreamWriter fileStr = File.CreateText(fileName))
                        {
                            fileStr.WriteLine(r);
                        }
                        Console.WriteLine("File is Created...");
                        break;
                    case 2:
                        Console.WriteLine("\nEnter the file name:");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            Console.WriteLine("File exists...");
                        }
                        else
                        {
                            Console.WriteLine("File does not exist in the current directory!");
                        }
                        break;
                    case3:
                        Console.WriteLine("Enter the file name to read the contents:\n");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            using (StreamReader sr = File.OpenText(fileName))
                            {
                                string s = "";
                                Console.WriteLine("Here is the content of the file:");
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exists");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nExiting...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }

            }
        }
    }
}