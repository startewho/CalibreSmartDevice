using SuperSocket.ProtoBase;
using System.Buffers;
using System.Text;

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
            var op = pack.Substring(1, commaIndex-1);
            if (int.TryParse(op, out int code))
            {
                var msg=pack.Substring(commaIndex+1,pack.Length-op.Length-3);//,之后到最后]之前
                return new SmartPackage()
                {
                    Op = (OperationType)code,
                    Message = msg,
                };
            } 
        }
        return null;
    }

}
