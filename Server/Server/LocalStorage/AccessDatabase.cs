using System;
using System.IO;

namespace Server.LocalStorage
{
    public class AccessDatabase
    {
        public static void WriteData()
        {
            try
            {
                string dekstopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = dekstopPath + "/P3Projekt/Server/Server/LocalStorage/Test.txt";
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine("Hello World!!");
                sw.WriteLine("From the StreamWriter class");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static string ReadData(string filename)
        {
            String line;
            try
            {
                string dekstopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = dekstopPath + "/P3Projekt/Server/Server/LocalStorage/"+filename+".txt";
                StreamReader sr = new StreamReader(filePath);
                string returned = "";
                line = sr.ReadLine();
                while (line != null)
                {
                    returned += line + "\n";
                    line = sr.ReadLine();
                }
                sr.Close();
                return returned;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return null;
        }
    }
}