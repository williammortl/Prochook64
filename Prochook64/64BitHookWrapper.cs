
namespace Prochook64
{
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Text;

    /// <summary>
    /// Static wrapper class for 64BitHookDLL.dll
    /// </summary>
    [SuppressUnmanagedCodeSecurityAttribute]   
    static class Sixty4BitHookWrapper
    {

        /// <summary>
        /// Starts the prochook
        /// </summary>
        [DllImport("64BitHookDLL.dll", EntryPoint = "StartMonitoring", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void StartMonitoring();

        /// <summary>
        /// Stops the prochook
        /// </summary>
        [DllImport("64BitHookDLL.dll", EntryPoint = "StopMonitoring", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void StopMonitoring();

        /// <summary>
        /// Retrieves the buffer from the proc hook
        /// </summary>
        /// <param name="sbBuffer">the string buffer to write the hook text into</param>
        /// <param name="lSize">the size of the buffer</param>
        [DllImport("64BitHookDLL.dll", EntryPoint = "GetTextBuffer", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTextBuffer(StringBuilder sbBuffer, ref ulong lSize);

        /// <summary>
        /// Retrieves the keystroke log
        /// </summary>
        /// <param name="sbBuffer">the string buffer to write the hook text into</param>
        /// <param name="lSize">the size of the buffer</param>
        [DllImport("64BitHookDLL.dll", EntryPoint = "GetKeyBuffer", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetKeyBuffer(StringBuilder sbBuffer, ref ulong lSize);
    }
}
