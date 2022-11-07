namespace CalibreSmartServer
{



    /// <summary>
    /// Opertion
    /// </summary>
    public enum Op
    {

        NOOP                   = 12,
        OK                     = 0,
        BOOK_DONE              = 11,
        CALIBRE_BUSY           = 18,
        SET_LIBRARY_INFO       = 19,
        DELETE_BOOK            = 13,
        DISPLAY_MESSAGE        = 17,
        ERROR                  = 20,
        FREE_SPACE             = 5,
        GET_BOOK_FILE_SEGMENT  = 14,
        GET_BOOK_METADATA      = 15,
        GET_BOOK_COUNT         = 6,
        GET_DEVICE_INFORMATION = 3,
        GET_INITIALIZATION_INFO= 9,
        SEND_BOOKLISTS         = 7,
        SEND_BOOK              = 8,
        SEND_BOOK_METADATA     = 16,
        SET_CALIBRE_DEVICE_INFO= 1,
        SET_CALIBRE_DEVICE_NAME= 2,
        TOTAL_SPACE            = 4,

    }
}