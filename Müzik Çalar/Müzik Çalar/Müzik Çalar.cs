using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Müzik_Çalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.SafeFileName;
            label1.Text = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = label1.Text;
        }
    }
}
