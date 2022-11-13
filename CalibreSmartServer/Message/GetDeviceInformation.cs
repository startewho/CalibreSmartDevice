using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class GetDeviceInformationReq : IOperation<GetDeviceInformationReq>
{
    public static OperationType Op => OperationType.GET_DEVICE_INFORMATION;

}

public class DeviceInfo
{
    [JsonPropertyName("device_store_uuid")]
    public string DeviceStoreUuid { get; set; }

    [JsonPropertyName("device_name")]
    public string DeviceName { get; set; }
}


public class GetDeviceInformationRes : IOperation<GetDeviceInformationRes>
{
    public static OperationType Op => OperationType.GET_DEVICE_INFORMATION;

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("device_info")]
    public DeviceInfo DeviceInfo { get; set; }

    [JsonPropertyName("device_version")]
    public string DeviceVersion { get; set; }
}
