64-Bit Windows Prochook Example
by William Mortl

This example project uses a 64-bit Windows prochook to hook the following Windows API calls:

BOOL WINAPI ExtTextOutA(HDC, int, int, UINT, CONST RECT *, LPCSTR, UINT, CONST INT *);
BOOL WINAPI ExtTextOutW(HDC, int, int, UINT, CONST RECT *, LPCWSTR, UINT, CONST INT *);
BOOL WINAPI TextOutA(HDC, int, int, LPCSTR, int);
BOOL WINAPI TextOutW(HDC, int, int, LPCWSTR, int);
BOOL WINAPI TerminateProcess(HANDLE, UINT);

However, the technique can be used to hook any function/procedure within a 64-bit application library or any 64-bit Windows API call. 

Prochook64.exe uses a Windows message hook to inject itself into all 64-bit processes running on the system that are at or below its equivalent privilege level. It is important to note that in order to inject itself into ALL processes that Prochook64.exe must be "Run as administrator", only then will it inject itself into apps such as Task Manager. 

If Prochook64.exe is run as a administrator, the hook of the TerminateProcess API call will even ban the almighty Task Manager from shutting down Prochook64.exe. This is but one simple application of a procedure hook. 

Prochook64.exe also scrapes text out of some Windows applications via procedure hooks. Any calls to any of the previously listed display text API calls by a 64-bit application are captured and stored in a text buffer. The retrieved text buffer is split by the process id of the application which called the display text API call. The process id can be found in the buffer in the following manner: *!~!*{process id here}*!~!*

Prochook64.exe also implements a keystroke logger. The keystrokes are returned in a buffer in a similar manner to the text buffer containing intercepted text from the display text API calls. It is also split by the process id of the application where the text was typed.

The 64-bit procedure hook works by calling the Windows VirtualProtect API call and changing the attributes of the memory page containing the procedure to be hooked from PAGE_EXECUTE_READ to PAGE_EXECUTE_READWRITE. Next, the hooking dll retrieves the first 12 bytes of the procedure, and then holds these bytes in a variable. Then the hooking dll writes 12 bytes of x64 assembly over top of the beginning of the procedure to be hooked. This new assembly causes a jump to the address of our "Shadow" function which intercepts the call. The 12 bytes of assembly are (in hex):

48 B8 {64 bit memory address to jump to, in this case, our Shadow function's address}
FF E0

If we want to pass the call on to the original procedure from the Shadow procedure, we simply re-write the original first 12 bytes over top of the procedure, call the procedure, and then re-write our 12 byte jump code back when complete.

On a personal note, I have been working with procedure hooks since 1997. I first implemented Matt Pietreks's 16-bit prochook for Windows 3.11 and Windows 95 from his book "Windows Internals" in 1997, you can find Matt Pietrek's book here:

http://www.amazon.com/Windows-Internals-Implementation-Operating-Environment/dp/0201622173

Next, I worked with another engineer (who is quite brilliant) on implementing a 32-bit prochook for Windows 9x operating systems. This prochook required a call to the VXD driver API call PageModifyPermissions. Due to Windows 9x's wonky architecture, this was the most difficult of all the prochooks to implement correctly. 

While finalizing the Windows 9x prochook I created a 32-bit Windows NT based procedure hook (which still works to this day, even on 64-bit Windows 8.1). The 32-bit procedure hook ONLY hooks and works with 32-bit applications. The main difference between the 32-bit prochook and my new 64-bit prochook is the assembly instructions which are written over top of the beginning of the procedure. The 32-bit prochook only need to write 5 bytes as opposed to the 64-bit prochook which needs to write 12 bytes. The 5 bytes are (in hex):

E9 {32 bit relative address of where you need to jump to}

The relative address = (address of the function to hook) - (the address of the Shadow function)