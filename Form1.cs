using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishMultiApp.Classes;

namespace EnglishMultiApp
{
    public partial class MainForm : Form
    {
        private bool isPanelHidden = false;
        private readonly int PanelWidth = 310;
        public MainForm()
        {
            InitializeComponent();
            phonemeChart = new PhonemeChart();
            

            slideTimer.Interval = 2;
            slideTimer.Tick += SlideTimer_Tick;
        }

        private void ButtonToggle_Click(object sender, EventArgs e)
        {
            slideTimer.Start();
            if (isPanelHidden)
                ButtonToggle.Text = "<<";
            else
                ButtonToggle.Text = ">>";
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
        
        private void PureVowelButton_MouseEnter(object sender, EventArgs e)
        {
            PureVowelButton.BackColor = Color.FromArgb(166, 68, 93);
            PureVowelButton.ForeColor = Color.White;
        }

        private void PureVowelButton_MouseLeave(object sender, EventArgs e)
        {
            PureVowelButton.BackColor = Color.FromArgb(192,192,255);
            PureVowelButton.ForeColor = Color.Black;
        }

        private void DiphthongButton_MouseEnter(object sender, EventArgs e)
        {
            DiphthongButton.BackColor = Color.FromArgb(166, 68, 93);
            DiphthongButton.ForeColor = Color.White;
        }

        private void DiphthongButton_MouseLeave(object sender, EventArgs e)
        {
            DiphthongButton.BackColor = Color.FromArgb(192,192,255);
            DiphthongButton.ForeColor = Color.Black;
        }

        private void ConsonantButton_MouseEnter(object sender, EventArgs e)
        {
            ConsonantButton.BackColor = Color.FromArgb(166, 68, 93);
            ConsonantButton.ForeColor = Color.White;
        }

        private void ConsonantButton_MouseLeave(object sender, EventArgs e)
        {
            ConsonantButton.BackColor = Color.FromArgb(192, 192, 255);
            ConsonantButton.ForeColor = Color.Black;
        }

        private void PureVowelButton_Click(object sender, EventArgs e)
        {
            if (PhonemeTablePanel.Visible == false)
            {
                PhonemeTablePanel.Visible = true;
                RenderPhonemeButtons(12);
            }
        }

        private void RenderPhonemeButtons(int size)
        {
            Button[] VowelButtons = new Button[size];
            if(size==12)
                phonemeChart.InitializeVowelList();
            //if(size==8)
                //phonemeChart.InitializeDipthongList();
            //if(size==24)
                //phonemeChart.InitializeConsonantList();
            for (int i=0; i< VowelButtons.Length; i++)
            {
                int j = i + 1;
                VowelButtons[i] = new Button();
                VowelButtons[i].Text = phonemeChart.GetVowelByNumber(j).GetPhoneticSymbol();
                VowelButtons[i].Size = new Size(60,60);
                VowelButtons[i].Click += (s, e) => ShowPhonemeDetails(j);
                VowelButtons[i].UseVisualStyleBackColor = false;
                VowelButtons[i].FlatStyle = FlatStyle.Flat;
                VowelButtons[i].MouseEnter += PhonemeButton_MouseEnter;
                VowelButtons[i].MouseLeave += PhonemeButton_MouseLeave;
                VowelButtons[i].BackColor = Color.FromArgb(192, 192, 255);



                PhonemeTablePanel.Controls.Add(VowelButtons[i]);
            }
            PhonemeTablePanel.BackColor = Color.FromArgb(15, 27, 39);
        }

        private void PhonemeButton_MouseEnter(object sender, EventArgs e)
        {
            Button phonemeButton = sender as Button;
            phonemeButton.BackColor = Color.FromArgb(166, 68, 93);
            phonemeButton.ForeColor = Color.White;
        }

        private void PhonemeButton_MouseLeave(object sender, EventArgs e)
        {
            Button phonemeButton = sender as Button;
            phonemeButton.BackColor = Color.FromArgb(192, 192, 255);
            phonemeButton.ForeColor = Color.Black;
        }

        public void ShowPhonemeDetails(int number)
        {
            var phoneme = phonemeChart.GetVowelByNumber(number);
            PhonemeDetail.Visible = true;
            PhonemeDetail.BackColor = Color.FromArgb(192, 192, 255);
            PhonemeDetail.ForeColor = Color.FromArgb(15, 27, 39);
            PhonemeDetail.Text = phonemeChart.GetPhonemeDetails(phoneme);
            PhonemeDetail.MinimumSize = new Size(PhonemeButtonsPanel.Width - 12 - PhonemeTablePanel.Width, PhonemeTablePanel.Height);
            PhonemeDetail.Location = new Point(PhonemeTablePanel.Location.X + PhonemeTablePanel.Width + 12,PhonemeTablePanel.Location.Y);
        }

        private void PhonemeShowPanel_Click(object sender, EventArgs e)
        {
            PhonemePanel.Visible = true;
        }

        private void ShowTrancriptionPanel(object sender, EventArgs e)
        {
            SlidePanel.BackColor = Color.FromArgb(180,70,88);
            TranscriptionPanel.Visible = true;
            //PhonemePanel.Visible = false;
            this.BackColor = Color.FromArgb(180, 78, 88);
        }
    }
}
