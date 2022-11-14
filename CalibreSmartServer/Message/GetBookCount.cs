using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


/// <summary>
/// Get Book Count
/// </summary>
public class GetBookCountReq : IOperation<GetBookCountReq>
{

    public static OperationType Op => OperationType.GET_BOOK_COUNT;

    [JsonPropertyName("canStream")]
    public bool CanStream { get; set; }

    [JsonPropertyName("canScan")]
    public bool CanScan { get; set; }

    [JsonPropertyName("willUseCachedMetadata")]
    public bool WillUseCachedMetadata { get; set; }

    [JsonPropertyName("supportsSync")]
    public bool SupportsSync { get; set; }

    [JsonPropertyName("canSupportBookFormatSync")]
    public bool CanSupportBookFormatSync { get; set; }

}



public class GetBookCountRes : IOperation<GetBookCountRes>
{
    public static OperationType Op => OperationType.GET_BOOK_COUNT;

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("willStream")]
    public bool WillStream { get; set; }

    [JsonPropertyName("willScan")]
    public bool WillScan { get; set; }
}
