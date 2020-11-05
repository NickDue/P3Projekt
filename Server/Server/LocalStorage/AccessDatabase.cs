using System;
using System.Collections.Generic;
using System.IO;

namespace Server.LocalStorage
{
    public class AccessDatabase
    {
        public static void WriteData(string filename)
        {
            try
            {
                string dekstopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = dekstopPath + "/P3Projekt/Server/Server/LocalStorage/"+filename+".txt";
                StreamWriter sw = new StreamWriter(filePath);
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