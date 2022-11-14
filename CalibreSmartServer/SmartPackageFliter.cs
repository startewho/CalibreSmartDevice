using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibreSmartServer;

public class SmartPackageFliter:LengthPrefixPackFliter<SmartPackage>
{
    public SmartPackageFliter():base(new byte[] { (byte)'[' })
    {

    }

    protected override SmartPackage DecodePackage(ref ReadOnlySequence<byte> buffer)
    {
        return base.DecodePackage(ref buffer);
    }

}
