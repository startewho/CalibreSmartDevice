using SuperSocket.ProtoBase;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibreSmartServer
{

    ///// <summary>
    ///// Encoder
    ///// </summary>
    ///// <typeparam name="T"></typeparam>
    //public class SmartPackageEncoder : IPackageEncoder<T> 
    //{
    //    public int Encode<T>(IBufferWriter<byte> writer, object pack) where T :IOperation<T>,new()
    //    {
    //        if (pack is IOperation<T> op)

    //        {

    //        }
    //        var encodePack = IOperation<T>.OpString(pack);
    //        var bytes = Encoding.UTF8.GetBytes(encodePack);
    //        writer.Write(bytes);
    //        return bytes.Length;
    //    }
    //}
}
