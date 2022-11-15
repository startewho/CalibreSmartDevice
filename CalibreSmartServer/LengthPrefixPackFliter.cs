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

        if (!reader.TryReadTo(out ReadOnlySequence<byte> markSeq, _splitMark.Span, advancePastDelimiter: false))
        {
            return null;
        }

        var len = markSeq.GetString(Encoding.UTF8);

        if (int.TryParse(len, out var msgLength))
        {

            if (reader.Remaining < msgLength)
            {
                reader.Rewind(markSeq.Length);// 回退
                return null;
            }

            var msgSeq = reader.Sequence.Slice(markSeq.Length, msgLength);
            try
            {
                return DecodePackage(ref msgSeq);
            }
            finally
            {
                reader.Advance(msgLength);//消费消息
            }

        }
        return null;


    }
}
