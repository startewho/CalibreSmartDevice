using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class SetDeviceInformationReq : IOperation<SetDeviceInformationReq>
{
    public static OperationType Op => OperationType.SET_CALIBRE_DEVICE_INFO;


    [JsonPropertyName("device_store_uuid")]
    public string DeviceStoreUuid { get; set; }

    [JsonPropertyName("device_name")]
    public string DeviceName { get; set; }

    [JsonPropertyName("location_code")]
    public string LocationCode { get; set; }

    [JsonPropertyName("last_library_uuid")]
    public string LastLibraryUuid { get; set; }

    [JsonPropertyName("calibre_version")]
    public string CalibreVersion { get; set; }

    [JsonPropertyName("date_last_connected")]
    public DateTime DateLastConnected { get; set; }

    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }
}




public class SetDeviceInformationRes : IOperation<SetDeviceInformationRes>
{
    public static OperationType Op => OperationType.SET_CALIBRE_DEVICE_INFO;

   
}
