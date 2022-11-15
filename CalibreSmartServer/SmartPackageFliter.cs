using SuperSocket.ProtoBase;
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

    protected override SmartPackage? DecodePackage(ref ReadOnlySequence<byte> buffer)
    {

        var pack=buffer.GetString(Encoding.UTF8);
        var commaIndex = pack.IndexOf(",");
        if (commaIndex>-1)
        {
            var opstr = pack.Substring(1, commaIndex-1);
            if (int.TryParse(opstr, out int opCode))
            {
                var opPack=pack.Substring(commaIndex+1,pack.Length-opstr.Length-3);

                return new SmartPackage()
                {
                    Op = (OperationType)opCode,
                    RawString = opPack,
                };
            } 
        }
        return null;
    }

}
