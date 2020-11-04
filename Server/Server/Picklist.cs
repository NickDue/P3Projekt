using System;
using System.Collections.Generic;
using System.IO;
using Server.LocalStorage;

namespace Server
{
    public class Picklist
    {
        public int picklistID;
        public string picklistCity;
        public string picklistPlatform;
        public bool picklistExpress;
        public List<PicklistLine> pickLines;

        public Picklist(int picklistId, string picklistCity, string picklistPlatform, bool express,
            List<PicklistLine> pickLines)
        {
            picklistID = picklistId;
            this.picklistCity = picklistCity;
            this.picklistPlatform = picklistPlatform;
            picklistExpress = express;
            this.pickLines = pickLines;
        }

        public void AddLine(PicklistLine newLine)
        {
            pickLines.Add(newLine);
        }

        public void SavePicklist()
        {
            try
            {
                string dekstopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = dekstopPath + "/P3Projekt/Server/Server/LocalStorage/Picklists/" + picklistID + ".txt";
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write("City: " + picklistCity + "\n");
                sw.Write("Platform: " + picklistPlatform + "\n");
                sw.Write("Express?: " + picklistExpress + "\n");
                foreach (PicklistLine line in pickLines)
                {
                    sw.Write(line.plProductID +"#"+line.plAmount+"#"+line.plProductName+"#"+line.plWeight+"#"+line.plPlacement+"\n");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
