using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalibreSmartServer;




/// <summary>
/// OperationType
/// </summary>
public enum OperationType
{

    NOOP = 12,
    OK = 0,
    BOOK_DONE = 11,
    CALIBRE_BUSY = 18,
    SET_LIBRARY_INFO = 19,
    DELETE_BOOK = 13,
    DISPLAY_MESSAGE = 17,
    ERROR = 20,
    FREE_SPACE = 5,
    GET_BOOK_FILE_SEGMENT = 14,
    GET_BOOK_METADATA = 15,
    GET_BOOK_COUNT = 6,
    GET_DEVICE_INFORMATION = 3,
    GET_INITIALIZATION_INFO = 9,
    SEND_BOOKLISTS = 7,
    SEND_BOOK = 8,
    SEND_BOOK_METADATA = 16,
    SET_CALIBRE_DEVICE_INFO = 1,
    SET_CALIBRE_DEVICE_NAME = 2,
    TOTAL_SPACE = 4,

}

public interface IOperation<T> where T : IOperation<T>,new ()
{
    static abstract OperationType Op { get; }


    static sealed T FromString(string detail)
    {
        return JsonSerializer.Deserialize<T>(detail);
    }

    static virtual T CreateDefault()
    {
        return new T();
    }
    

     static sealed string OpString(T t)
    {
        var builer = new StringBuilder();
        builer.Append($"[{(int)T.Op},");
        builer.Append(JsonSerializer.Serialize(t));
        builer.Append(']');
        return $"{builer.Length}{builer.ToString()}";
    }
}


public class NoOp : IOperation<NoOp>
{
    public static OperationType Op => OperationType.NOOP;

    public static NoOp CreateDefault()
    {
        return new NoOp();
    }
}

public class Ok:IOperation<Ok> 
{
    public static OperationType Op => OperationType.OK;

    public static Ok CreateDefault()
    {
        return new Ok();
    }
}



