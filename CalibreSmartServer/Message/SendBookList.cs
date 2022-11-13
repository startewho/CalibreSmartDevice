using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class Collections
{
}

public class SendBookListReq : IOperation<SendBookListReq>
{

    public static OperationType Op => OperationType.SEND_BOOKLISTS;

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("collections")]
    public Collections Collections { get; set; }

    [JsonPropertyName("willStreamMetadata")]
    public bool WillStreamMetadata { get; set; }

    [JsonPropertyName("supportsSync")]
    public bool SupportsSync { get; set; }

}



public class SendBookListRes : IOperation<SendBookListRes>
{
    public static OperationType Op => OperationType.SEND_BOOKLISTS;
}
