using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


public class GetInitializationInfoReq : IOperation<GetInitializationInfoReq>
{
    public static OperationType Op => OperationType.GET_INITIALIZATION_INFO;


    public static GetInitializationInfoReq CreateDefault()
    {
        return new GetInitializationInfoReq();
    }

    [JsonPropertyName("serverProtocolVersion")]
    public int serverProtocolVersion { get; set; } = 1;

    [JsonPropertyName("validExtensions")]
    public List<string> validExtensions { get; set; } = new List<string>() { "epub", "zip", "html", "azw" };

    [JsonPropertyName("passwordChallenge")]
    public string passwordChallenge { get; set; }

    [JsonPropertyName("currentLibraryName")]
    public string currentLibraryName { get; set; } = "CalibreLib";

    [JsonPropertyName("currentLibraryUUID")]
    public string currentLibraryUUID { get; set; } = "1ca06db8-9bbb-469c-ab49-968d8e307107";

    [JsonPropertyName("pubdateFormat")]
    public string pubdateFormat { get; set; }

    [JsonPropertyName("timestampFormat")]
    public string timestampFormat { get; set; }

    [JsonPropertyName("lastModifiedFormat")]
    public string lastModifiedFormat { get; set; }

    [JsonPropertyName("calibre_version")]
    public List<int> calibre_version { get; set; } = new List<int>() { 6, 8, 0 };

    [JsonPropertyName("canSupportUpdateBooks")]
    public bool canSupportUpdateBooks { get; set; } = true;

    [JsonPropertyName("canSupportLpathChanges")]
    public bool canSupportLpathChanges { get; set; } = true;
}



public class ExtensionPathLengths
{
    [JsonPropertyName("docx")]
    public int Docx { get; set; }

    [JsonPropertyName("xhtml")]
    public int Xhtml { get; set; }

    [JsonPropertyName("html")]
    public int Html { get; set; }

    [JsonPropertyName("djvu")]
    public int Djvu { get; set; }

    [JsonPropertyName("htm")]
    public int Htm { get; set; }

    [JsonPropertyName("md")]
    public int Md { get; set; }

    [JsonPropertyName("zip")]
    public int Zip { get; set; }

    [JsonPropertyName("djv")]
    public int Djv { get; set; }

    [JsonPropertyName("epub")]
    public int Epub { get; set; }

    [JsonPropertyName("pdf")]
    public int Pdf { get; set; }

    [JsonPropertyName("chm")]
    public int Chm { get; set; }

    [JsonPropertyName("pdb")]
    public int Pdb { get; set; }

    [JsonPropertyName("doc")]
    public int Doc { get; set; }

    [JsonPropertyName("prc")]
    public int Prc { get; set; }

    [JsonPropertyName("rtf")]
    public int Rtf { get; set; }

    [JsonPropertyName("txt")]
    public int Txt { get; set; }

    [JsonPropertyName("azw")]
    public int Azw { get; set; }

    [JsonPropertyName("mobi")]
    public int Mobi { get; set; }

    [JsonPropertyName("fb2")]
    public int Fb2 { get; set; }

    [JsonPropertyName("xps")]
    public int Xps { get; set; }

    [JsonPropertyName("cbz")]
    public int Cbz { get; set; }
}
public class GetInitializationInfoRes : IOperation<GetInitializationInfoRes>
{
    public static OperationType Op => OperationType.GET_INITIALIZATION_INFO;

    [JsonPropertyName("appName")]
    public string AppName { get; set; }

    [JsonPropertyName("acceptedExtensions")]
    public List<string> AcceptedExtensions { get; set; }

    [JsonPropertyName("cacheUsesLpaths")]
    public bool CacheUsesLpaths { get; set; }

    [JsonPropertyName("canAcceptLibraryInfo")]
    public bool CanAcceptLibraryInfo { get; set; }

    [JsonPropertyName("canDeleteMultipleBooks")]
    public bool CanDeleteMultipleBooks { get; set; }

    [JsonPropertyName("canReceiveBookBinary")]
    public bool CanReceiveBookBinary { get; set; }

    [JsonPropertyName("canSendOkToSendbook")]
    public bool CanSendOkToSendbook { get; set; }

    [JsonPropertyName("canStreamBooks")]
    public bool CanStreamBooks { get; set; }

    [JsonPropertyName("canStreamMetadata")]
    public bool CanStreamMetadata { get; set; }

    [JsonPropertyName("canUseCachedMetadata")]
    public bool CanUseCachedMetadata { get; set; }

    [JsonPropertyName("ccVersionNumber")]
    public string CcVersionNumber { get; set; }

    [JsonPropertyName("coverHeight")]
    public int CoverHeight { get; set; }

    [JsonPropertyName("deviceKind")]
    public string DeviceKind { get; set; }

    [JsonPropertyName("deviceName")]
    public string DeviceName { get; set; }

    [JsonPropertyName("extensionPathLengths")]
    public ExtensionPathLengths ExtensionPathLengths { get; set; }

    [JsonPropertyName("passwordHash")]
    public string PasswordHash { get; set; }

    [JsonPropertyName("maxBookContentPacketLen")]
    public int MaxBookContentPacketLen { get; set; }

    [JsonPropertyName("useUuidFileNames")]
    public bool UseUuidFileNames { get; set; }

    [JsonPropertyName("versionOK")]
    public bool VersionOK { get; set; }
}
