#if !defined(SIXTY4BITHOOKDLL_H)
#define SIXTY4BITHOOKDLL_H



/*
 *
 * includes
 *
 */
#include <windows.h>



/*
 *
 * function prototypes
 *
 */
// public DLL functions
void WINAPI StartMonitoring(void);
void WINAPI StopMonitoring(void);
void WINAPI GetTextBuffer(LPSTR, size_t *);
void WINAPI GetKeyBuffer(LPSTR, size_t *);



#endif
