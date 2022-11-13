using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class DeleteBookReq : IOperation<DeleteBookReq>
{

    public static OperationType Op => OperationType.DELETE_BOOK;

    [JsonPropertyName("lpath")]
    public string Lpath { get; set; }
}



public class DeleteBookRes : IOperation<DeleteBookRes>
{
    public static OperationType Op => OperationType.DELETE_BOOK;
}
