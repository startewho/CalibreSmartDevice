﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.ProtoBase;

namespace CalibreSmartServer
{



    /// <summary>
    /// 长度前缀的Json字符串形式
    /// 34[0, {"key0":value, "key1": value}]
    /// </summary>
    /// <typeparam name="TPackageInfo"></typeparam>

    public class LengthPrefixPackFliter<TPackageInfo> : PipelineFilterBase<TPackageInfo> where TPackageInfo : class
    {

        private readonly ReadOnlyMemory<byte> _splitMark;


        public LengthPrefixPackFliter(ReadOnlyMemory<byte> splitMark)
        {
            _splitMark = splitMark;
        }


        public override TPackageInfo? Filter(ref SequenceReader<byte> reader)
        {

            if (!reader.TryReadTo(out ReadOnlySequence<byte> lengthPack, _splitMark.Span, advancePastDelimiter: false))
            {
                return null;
            }

            var lengthStr = reader.ReadString(Encoding.UTF8, lengthPack.Length);

            if (int.TryParse(lengthStr, out var length))
            {
                reader.Advance(lengthPack.Length);

                if (reader.Remaining < length)
                    return null;

                var pack = reader.Sequence.Slice(lengthPack.Length, length);

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
}
