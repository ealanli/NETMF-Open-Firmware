//-----------------------------------------------------------------------------
//
//    ** DO NOT EDIT THIS FILE! **
//    This file was generated by a tool
//    re-running the tool will overwrite this file.
//
//-----------------------------------------------------------------------------


#ifndef _LIB_H_
#define _LIB_H_

#include <TinyCLR_Interop.h>
struct Library_Lib_GHI_Networking_BaseInterface
{
    static const int FIELD_STATIC__activeInterface = 0;
    static const int FIELD_STATIC__reservations = 1;

    static const int FIELD__disposed = 1;
    static const int FIELD__isAvailable = 2;
    static const int FIELD__hasAddress = 3;
    static const int FIELD__type = 4;
    static const int FIELD__networkInterface = 5;

    TINYCLR_NATIVE_DECLARE(NativeConstructor___VOID);
    TINYCLR_NATIVE_DECLARE(NativeDispose___VOID);
    TINYCLR_NATIVE_DECLARE(NativeActivate___VOID);
    TINYCLR_NATIVE_DECLARE(NativeDeactivate___VOID);
    TINYCLR_NATIVE_DECLARE(NativeUpdateMacAddress___VOID__SZARRAY_U1);

    //--//

};

struct Library_Lib_GHI_Networking_PPPSerialModem
{
    static const int FIELD__deviceId = 6;
    static const int FIELD__port = 7;

    TINYCLR_NATIVE_DECLARE(NativeEnable___VOID__U4);
    TINYCLR_NATIVE_DECLARE(NativeConnect___BOOLEAN__U4__STRING__STRING__U4__BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeDisconnect___VOID);
    TINYCLR_NATIVE_DECLARE(NativeIsLinkConnected___BOOLEAN);

    //--//

};

struct Library_Lib_GHI_Networking_WiFiRS9110
{
    static const int FIELD_STATIC__FIRMWARE_VERSION = 2;

    static const int FIELD__waitOnScan = 6;
    static const int FIELD__waitOnSendBssidRequest = 7;
    static const int FIELD__waitOnJoin = 8;
    static const int FIELD__waitOnDisconnect = 9;
    static const int FIELD__waitOnConnectionStatusResponse = 10;
    static const int FIELD__waitOnCardReady = 11;
    static const int FIELD__waitOnImageUpgrade = 12;
    static const int FIELD__activeNetwork = 13;
    static const int FIELD__resetPin = 14;
    static const int FIELD__eventWorker = 15;
    static const int FIELD__completionWorker = 16;
    static const int FIELD__spi = 17;
    static const int FIELD__chipSelect = 18;
    static const int FIELD__externalInterrupt = 19;
    static const int FIELD__clockRate = 20;
    static const int FIELD__timeout = 21;

    TINYCLR_NATIVE_DECLARE(NativeExecuteCompletion___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeGetLastJoinError___U2);
    TINYCLR_NATIVE_DECLARE(NativeGetScanResponseSize___I4);
    TINYCLR_NATIVE_DECLARE(NativeGetBssidReponseSize___I4);
    TINYCLR_NATIVE_DECLARE(NativeSetHalConfig___VOID);
    TINYCLR_NATIVE_DECLARE(NativeTriggerContinuation___VOID);
    TINYCLR_NATIVE_DECLARE(NativeInitializeContinuations___VOID);
    TINYCLR_NATIVE_DECLARE(NativeUninitializeContinuations___VOID);
    TINYCLR_NATIVE_DECLARE(NativeInitializeSpiInterfaceRequest___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeGetEvent___I4);
    TINYCLR_NATIVE_DECLARE(NativeSetBootloaderOption___BOOLEAN__I4);
    TINYCLR_NATIVE_DECLARE(NativeQueryMacAddress___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeGetInternalMacAddress___VOID__SZARRAY_U1);
    TINYCLR_NATIVE_DECLARE(NativeSendBandRequest___VOID__I4);
    TINYCLR_NATIVE_DECLARE(NativeInitializeRequest___VOID);
    TINYCLR_NATIVE_DECLARE(NativeScan___BOOLEAN__U4__STRING);
    TINYCLR_NATIVE_DECLARE(NativeSendBssidRequest___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeGetBssidResponse___I4__SZARRAY_U1);
    TINYCLR_NATIVE_DECLARE(NativeDisconnect___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeQueryConnectionStatus___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeGetConnectionStatus___I4);
    TINYCLR_NATIVE_DECLARE(NativeQueryFirmwareVersion___BOOLEAN);
    TINYCLR_NATIVE_DECLARE(NativeGetFirmwareVersion___STRING);
    TINYCLR_NATIVE_DECLARE(NativeJoin___BOOLEAN__I4__I4__SZARRAY_U1__SZARRAY_U1__I4__I4__I4__I4__I4);

    //--//

};

struct Library_Lib_GHI_Networking_EthernetBuiltIn
{
    TINYCLR_NATIVE_DECLARE(NativeIsCableConnected___BOOLEAN);

    //--//

};

struct Library_Lib_GHI_Networking_EthernetENC28J60
{
    static const int FIELD__resetPin = 6;
    static const int FIELD__spi = 7;
    static const int FIELD__chipSelect = 8;
    static const int FIELD__externalInterrupt = 9;
    static const int FIELD__clockRate = 10;

    TINYCLR_NATIVE_DECLARE(NativeSetHalConfig___VOID);
    TINYCLR_NATIVE_DECLARE(NativeIsCableConnected___BOOLEAN);

    //--//

};

struct Library_Lib_GHI_Networking_WiFiRS9110__NetworkParameters
{
    static const int FIELD__channel = 1;
    static const int FIELD__rssi = 2;
    static const int FIELD__ssid = 3;
    static const int FIELD__key = 4;
    static const int FIELD__physicalAddress = 5;
    static const int FIELD__securityMode = 6;
    static const int FIELD__networkType = 7;


    //--//

};



extern const CLR_RT_NativeAssemblyData g_CLR_AssemblyNative_GHI_Networking;

#endif  //_LIB_H_
