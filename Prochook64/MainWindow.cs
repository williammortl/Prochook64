namespace Prochook64
{
    using System;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Class for the main window
    /// </summary>
    public partial class MainWindow : Form
    {

        /// <summary>
        /// Is a procedure hooked
        /// </summary>
        private Boolean isHooked = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = this.isHooked;
        }

        /// <summary>
        /// Starts the prochook
        /// </summary>
        /// <param name="sender">who clicked</param>
        /// <param name="e">event args</param>
        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.isHooked == false)
            {
                Sixty4BitHookWrapper.StartMonitoring();
                this.isHooked = true;
            }
        }

        /// <summary>
        /// Gets the text buffers from the hook
        /// </summary>
        /// <param name="sender">who clicked</param>
        /// <param name="e">event args</param>
        private void getText_Click(object sender, EventArgs e)
        {

            // setup the string buffer for the call
            ulong bufferSize = 0;
            StringBuilder buffer = new StringBuilder(String.Empty, 200000);

            // get the prochook text buffer
            Sixty4BitHookWrapper.GetTextBuffer(buffer, ref bufferSize);

            // display the text
            hookText.Text = buffer.ToString();

            // get the prochook text buffer
            buffer = new StringBuilder(String.Empty, 200000);
            Sixty4BitHookWrapper.GetKeyBuffer(buffer, ref bufferSize);

            // display the text
            keyText.Text = buffer.ToString();
        }

        /// <summary>
        /// Stops the prochook
        /// </summary>
        /// <param name="sender">who clicked</param>
        /// <param name="e">event args</param>
        private void stopButton_Click(object sender, EventArgs e)
        {
            if (this.isHooked == true)
            {
                Sixty4BitHookWrapper.StopMonitoring();
                this.isHooked = false;
            }
        }
    }
}
