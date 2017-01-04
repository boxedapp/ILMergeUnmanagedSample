namespace MainApplication
{
    partial class Form1
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
            this.buttonCallUnmanagedDll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCallUnmanagedDll
            // 
            this.buttonCallUnmanagedDll.Location = new System.Drawing.Point(31, 46);
            this.buttonCallUnmanagedDll.Name = "buttonCallUnmanagedDll";
            this.buttonCallUnmanagedDll.Size = new System.Drawing.Size(174, 72);
            this.buttonCallUnmanagedDll.TabIndex = 0;
            this.buttonCallUnmanagedDll.Text = "Call Unmanaged DLL";
            this.buttonCallUnmanagedDll.UseVisualStyleBackColor = true;
            this.buttonCallUnmanagedDll.Click += new System.EventHandler(this.buttonCallUnmanagedDll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 170);
            this.Controls.Add(this.buttonCallUnmanagedDll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCallUnmanagedDll;
    }
}

