////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include <tinyhal.h>

//--//
BOOL DMA_Initialize()
{
    return true;
}

BOOL DMA_Uninitialize()
{
    return true;
}

void DMA_MemCpy( void* dst, void*src, UINT32 size, BOOL async = FALSE )
{
}

void DMA_MemCpy2D( void* dst, void*src, UINT32 width, UINT32 height, UINT32 dataWidth, BOOL async = FALSE )
{
}

void DMA_StartDummyDMA()
{
}


