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
        public static string Title;
        public static string Adress;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ScreenScraperAllaBolag screenscraper;
            ScreenScraperUpplysning screenscraperUp;
          Adress = "http://www." + comboBoxLevertor.Text + "/" + textBoxSearch.Text;
            if (comboBoxLevertor.SelectedIndex==0)
            {
                Title = "<span [^>]*class=(\"|')reportTitleBig(\"|')>(.*?)</span>";
               screenscraper= new ScreenScraperAllaBolag();
                await screenscraper.ScreenScrapeAsync(textBoxSearch.Text);
                labelResult.Text = screenscraper.Result;
            }
            else
            {
                Title = "";

                screenscraperUp = new ScreenScraperUpplysning();
                await screenscraperUp.ScreenScrapeAsync(textBoxSearch.Text);
                labelResult.Text = screenscraperUp.Result;
            }


        
         
          
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
