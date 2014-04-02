//-----------------------------------------------------------------------------
//
//                   ** WARNING! ** 
//    This file was generated automatically by a tool.
//    Re-running the tool will overwrite this file.
//    You should copy this file to a custom location
//    before adding any customization in the copy to
//    prevent loss of your changes when the tool is
//    re-run.
//
//-----------------------------------------------------------------------------


#ifndef _LIB_GHI_PROCESSOR_RUNTIMELOADABLEPROCEDURES_H_
#define _LIB_GHI_PROCESSOR_RUNTIMELOADABLEPROCEDURES_H_

namespace GHI
{
    namespace Processor
    {
        struct RuntimeLoadableProcedures
        {
            // Helper Functions to access fields of managed object
            // Declaration of stubs. These functions are implemented by Interop code developers
            static void NativeInitializeZeroRegion( UINT32 param0, UINT32 param1, HRESULT &hr );
            static void NativeLoadELF( CLR_RT_TypedArray_UINT8 param0, UINT32 * param1, UINT32 * param2, UINT32 * param3, HRESULT &hr );
            static UINT32 NativeFindSymbolAddress( CLR_RT_TypedArray_UINT8 param0, LPCSTR param1, INT32 param2, HRESULT &hr );
        };
    }
}
#endif  //_LIB_GHI_PROCESSOR_RUNTIMELOADABLEPROCEDURES_H_
