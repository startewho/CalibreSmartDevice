using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class FreeSpaceReq : IOperation<FreeSpaceReq>
{

    public static OperationType Op => OperationType.FREE_SPACE;

   

}



public class FreeSpaceRes : IOperation<FreeSpaceRes>
{
    public static OperationType Op => OperationType.FREE_SPACE;

    [JsonPropertyName("free_space_on_device")]
    public int FreeSpaceOnDevice { get; set; }
}
