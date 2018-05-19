using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Mod3_Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // creates StreamReader object called "streamReaderObject
            // assigns its value to null
            StreamReader streamReaderObject = null;

            try
            {
                //assigns "streamReaderObject to read from a text file named "file1"
                streamReaderObject = new StreamReader("file1.txt");

                // reads all characters from the current position to the end of the stream
                //stores in string variable "contents"
                String contents = streamReaderObject.ReadToEnd();

                // closes StreamReader
                streamReaderObject.Close();

                //writes the amount of text elements in the text file to the console
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }
            //code to handle any errors
            catch (FileNotFoundException)
            {
                //informs user there is no file created
                Console.WriteLine("The file cannot be found.");
            }
        }  
    }
}
