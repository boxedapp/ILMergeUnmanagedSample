using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MainApplication
{
    public partial class Form1 : Form
    {
        [DllImport("UnmanagedDll32.dll", EntryPoint = "fnUnmanagedDll")]
        internal static extern int fnUnmanagedDll32();

        [DllImport("UnmanagedDll64.dll", EntryPoint = "fnUnmanagedDll")]
        internal static extern int fnUnmanagedDll64();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCallUnmanagedDll_Click(object sender, EventArgs e)
        {
            if (IntPtr.Size == 8)
                MessageBox.Show("Unmanaged dll returned: " + fnUnmanagedDll64().ToString());
            else
                MessageBox.Show("Unmanaged dll returned: " + fnUnmanagedDll32().ToString());
        }
    }
}
