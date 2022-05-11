using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Manipulate_Local_File
{
    public class Files
    {


        public void Filee()
        {
            string filePath = @"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File\kashyap.txt";
            Console.WriteLine(File.Exists(filePath) ? "File exists." : "File does not exist.");
            try
            {
            //    string filePath = @"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File\kashyap.txt";
                //  string NewPath = @"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File\NewPath.txt";
                string writeText = "Welcome";  // Create a text string
                File.WriteAllText(filePath, writeText);  // Create a file and write the contents of writeText to it
                                                         //  File.AppendAllText(filePath, writeText);

                var lines = File.ReadAllLines(filePath).ToList();
                lines.Add("Append New Line");
             
                File.AppendAllLines(filePath, lines);
              //  var readText = File.ReadAllLines(filePath); 
              var readText = File.ReadAllText(filePath);    
                Console.WriteLine(readText); // Output the content
              //  File.Delete(filePath);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


           
        }

    
        public void Read_File_And_Added_New_Line
            ()
        {
            string filePath = @"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File\Name.txt";
            var lines = File.ReadAllLines(filePath).ToList();    
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            lines.Add("Anurag Thakur");
            File.WriteAllLines(filePath, lines);
         
        }
        public void writeFile()
        {
            string path = @"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File\WriteFile.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

        }

    }
    

}
