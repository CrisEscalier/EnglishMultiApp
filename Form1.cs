using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishMultiApp
{
    public partial class MainForm : Form
    {
        private bool isPanelHidden = false;
        private readonly int PanelWidth = 280;
        public MainForm()
        {
            InitializeComponent();

            slideTimer.Interval = 2;
            slideTimer.Tick += SlideTimer_Tick;
        }

        private void ButtonToggle_Click(object sender, EventArgs e)
        {
            slideTimer.Start();
            if (isPanelHidden)
                ButtonToggle.Text = "Close Panel";
            else
                ButtonToggle.Text = "Open Panel";
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            int size = 5;
            if (isPanelHidden)
            {
                SlidePanel.Width += size;
                if(SlidePanel.Width >= PanelWidth)
                {
                    slideTimer.Stop();
                    isPanelHidden = false;
                    SlidePanel.Width = PanelWidth;
                }
            }
            else
            {
                SlidePanel.Width -= size;
                if (SlidePanel.Width <= 70)
                {
                    slideTimer.Stop();
                    isPanelHidden = true;
                    SlidePanel.Width = 70;
                }
            }
        }
    }
}
