// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the UNMANAGEDDLL_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// UNMANAGEDDLL_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef UNMANAGEDDLL_EXPORTS
#define UNMANAGEDDLL_API __declspec(dllexport)
#else
#define UNMANAGEDDLL_API __declspec(dllimport)
#endif

// This class is exported from the UnmanagedDll.dll
class UNMANAGEDDLL_API CUnmanagedDll {
public:
	CUnmanagedDll(void);
	// TODO: add your methods here.
};

extern UNMANAGEDDLL_API int nUnmanagedDll;

UNMANAGEDDLL_API int fnUnmanagedDll(void);
