using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibreSmartServer;



public class FileBody
{
    public Stream Body { get; set; }
}


public class SmartPackage
{

    public OperationType Op { get; set; }

    public int Length { get; set; }

    public string Message { get; set; }

    public FileBody File { get; set; }
}
