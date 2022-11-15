using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.ProtoBase;

namespace CalibreSmartServer;




/// <summary>
/// 长度前缀的Json字符串形式
/// 34[0, {"key0":value, "key1": value}]
/// </summary>
/// <typeparam name="TPackageInfo"></typeparam>

public class LengthPrefixPackFliter<TPackageInfo> : PipelineFilterBase<TPackageInfo> where TPackageInfo : class
{

    protected readonly ReadOnlyMemory<byte> _splitMark;


    public LengthPrefixPackFliter(ReadOnlyMemory<byte> splitMark)
    {
        _splitMark = splitMark;
    }


    public override TPackageInfo? Filter(ref SequenceReader<byte> reader)
    {

        if (!reader.TryReadTo(out ReadOnlySequence<byte> prePack, _splitMark.Span, advancePastDelimiter: false))
        {
            return null;
        }


        var lengthStr = prePack.GetString(Encoding.UTF8);

        if (int.TryParse(lengthStr, out var length))
        {

            if (reader.Remaining < length)
            {
                reader.Rewind(prePack.Length);
                return null;
            }

            var pack = reader.Sequence.Slice(prePack.Length, length);

            try
            {
                return DecodePackage(ref pack);
            }
            finally
            {
                reader.Advance(length);
            }

        }
        return null;


    }
}
