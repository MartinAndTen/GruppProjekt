using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllaBolagScreenScraper
{
    public partial class Form1 : Form
    {
        public static string Title;
        public static string Adress;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();
        
          
            
            IScreenScraper screenscraper = ScreenScraperFactory.CreateScreenScrape(comboBoxLevertor.Text);
            await screenscraper.ScreenScrapeAsync(textBoxSearch.Text);
            labelResult.Text = screenscraper.Result;

            timer.Stop();
            labelTimer.Text = Convert.ToString(timer.ElapsedMilliseconds);
            
         
        
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxLevertor.SelectedIndex = 0;
        }

        private void comboBoxLevertor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
