using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllaBolagScreenScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ScreenScraper screenscraper=new ScreenScraper();
            await screenscraper.Start(textBoxSearch.Text);
            labelResult.Text = screenscraper.Result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
