using System;
using System.IO;
using System.Text;
class Test///This C# program is used to create a file. Using Create() function the file is created and the content is written to the file. Using while loop check the file is not equal to null. If the condition is true then execute the statement and print the same content.///
{
    public static void Main()
    {
        string textpath = @"c:\sri\test.txt";
        using (FileStream fs = File.Create(textpath))
        {
            Byte[] info = new UTF8Encoding(true).GetBytes("File is Created");
            fs.Write(info, 0, info.Length);
        }
        using (StreamReader sr = File.OpenText(textpath))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
        Console.Read();
    }
}
///Output:File is Created//