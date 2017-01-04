// UnmanagedDll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "UnmanagedDll.h"


// This is an example of an exported variable
UNMANAGEDDLL_API int nUnmanagedDll=0;

// This is an example of an exported function.
UNMANAGEDDLL_API int fnUnmanagedDll(void)
{
	return 42;
}

// This is the constructor of a class that has been exported.
// see UnmanagedDll.h for the class definition
CUnmanagedDll::CUnmanagedDll()
{
	return;
}
