namespace Prochook64
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hookText = new System.Windows.Forms.TextBox();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.getText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hookText
            // 
            this.hookText.Location = new System.Drawing.Point(13, 27);
            this.hookText.Multiline = true;
            this.hookText.Name = "hookText";
            this.hookText.ReadOnly = true;
            this.hookText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hookText.Size = new System.Drawing.Size(553, 168);
            this.hookText.TabIndex = 0;
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(13, 216);
            this.keyText.Multiline = true;
            this.keyText.Name = "keyText";
            this.keyText.ReadOnly = true;
            this.keyText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.keyText.Size = new System.Drawing.Size(553, 168);
            this.keyText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prochook Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Keystroke Text:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Lime;
            this.startButton.Location = new System.Drawing.Point(588, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(128, 101);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Hooking >>";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(588, 283);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(128, 101);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop Hooking >>";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // getText
            // 
            this.getText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.getText.Location = new System.Drawing.Point(588, 154);
            this.getText.Name = "getText";
            this.getText.Size = new System.Drawing.Size(128, 101);
            this.getText.TabIndex = 6;
            this.getText.Text = "Get Text >>";
            this.getText.UseVisualStyleBackColor = false;
            this.getText.Click += new System.EventHandler(this.getText_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 401);
            this.Controls.Add(this.getText);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.hookText);
            this.Name = "MainWindow";
            this.Text = "64 Bit Prochook Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hookText;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button getText;
    }
}

