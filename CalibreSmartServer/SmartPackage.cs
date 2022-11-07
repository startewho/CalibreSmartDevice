using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibreSmartServer
{


    public class FileBody
    {
        public Stream Body { get; set; }
    }


    internal class SmartPackage<T>
    {

        public int Length { get; set; }


        public T Cotent { get; set; }


        public FileBody File { get; set; }
    }
}
