64 Bit Windows Prochook Example
by William Mortl

This example project uses a 64-bit Windows Prochook to hook the following Windows API calls:

BOOL WINAPI ExtTextOutA(HDC, int, int, UINT, CONST RECT *, LPCSTR, UINT, CONST INT *);
BOOL WINAPI ExtTextOutW(HDC, int, int, UINT, CONST RECT *, LPCWSTR, UINT, CONST INT *);
BOOL WINAPI TextOutA(HDC, int, int, LPCSTR, int);
BOOL WINAPI TextOutW(HDC, int, int, LPCWSTR, int);
BOOL WINAPI TerminateProcess(HANDLE, UINT);

but it can be used to hook any function or Windows API call. 

It uses a Windows message hook to inject itself into all 64-bit processes on the system that are at its equivalent proviledge level. It is important to note that in order to inject itself into ALL processes that Prochook64.exe must be "Run as administrator", only then will it inject itself into such apps as Task Manager. 

If run as administrator, the hook of TerminateProcess will ban even the almighty Task Manager from killing the application. This is but one application of a procedure hool