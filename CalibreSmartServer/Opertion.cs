using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalibreSmartServer
{



    /// <summary>
    /// Opertion
    /// </summary>
    public enum Opertion
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

    public interface IOp<T> where T:IOp<T>
    {
        static sealed Opertion Op { get; }

        static sealed T FromString(string detail)
        {
            return JsonSerializer.Deserialize<T>(detail);
        }

         static sealed string OpString(T t)
        {
            var builer = new StringBuilder();
            builer.Append($"[{(int)Op},");
            builer.Append(JsonSerializer.Serialize(t));
            builer.Append(']');
            return $"{builer.Length}{builer.ToString()}";
        }
    }


    public class NOOP : IOp<NOOP>
    {

        public static Opertion Op => Opertion.NOOP;

      
    }

    public class OK
    {
        public static Opertion Op => Opertion.OK;
        public int free_space_on_device { get; set; }
    }

    public class SendBook
    {

        public static Opertion Op => Opertion.SEND_BOOK;

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


    public class DeleteBook
    {
        [JsonPropertyName("lpath")]
        public string Lpath { get; set; }
    }
}