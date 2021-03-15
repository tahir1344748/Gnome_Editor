using System.Collections;
using System;
namespace Gnome_Edit
{
    class Stream
    {
        private ArrayList inputStream;
        public Stream(string fileName)
        {
            inputStream = new ArrayList();
            FileHandler.Reader(fileName, inputStream);
        }

        public ArrayList InputStream
        {
            set
            {
                this.inputStream = value;
            }
            get
            {
                return this.inputStream;
            }
        }
    }
}