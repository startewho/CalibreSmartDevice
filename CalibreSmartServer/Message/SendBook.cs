using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class SendBookReq : IOperation<SendBookReq>
{

    public static OperationType Op => OperationType.SEND_BOOK;

    [JsonPropertyName("lpath")]
    public string Lpath { get; set; }

    [JsonPropertyName("length")]
    public int Length { get; set; }

    [JsonPropertyName("metadata")]
    public string Metadata { get; set; }

    [JsonPropertyName("thisBook")]
    public int ThisBook { get; set; }

    [JsonPropertyName("totalBooks")]
    public int TotalBooks { get; set; }

    [JsonPropertyName("willStreamBooks")]
    public bool WillStreamBooks { get; set; }

    [JsonPropertyName("willStreamBinary")]
    public bool WillStreamBinary { get; set; }

    [JsonPropertyName("wantsSendOkToSendbook")]
    public bool WantsSendOkToSendbook { get; set; }

    [JsonPropertyName("canSupportLpathChanges")]
    public bool CanSupportLpathChanges { get; set; }
}



public class SendBookRes : IOperation<SendBookRes>
{
    public static OperationType Op => OperationType.SEND_BOOK;
}
