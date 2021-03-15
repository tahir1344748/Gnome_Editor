using System.IO;
using System.Collections;
using System;

namespace Gnome_Edit{
    public static class FileHandler{
        
        public static void Reader(string fileName, ArrayList streamList)
        {
            StreamReader fileReaderObj = new StreamReader(fileName);
            while(!fileReaderObj.EndOfStream)
            {
                streamList.Add(fileReaderObj.ReadLine());
            }
            fileReaderObj.Close();
        }
    }
}