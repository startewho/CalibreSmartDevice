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


    public class SmartPackage
    {

        public Opertion Op { get; set; }

        public int Length { get; set; }

        public string RawString { get; set; }

        public FileBody File { get; set; }
    }
}
