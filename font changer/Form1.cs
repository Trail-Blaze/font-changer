using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace font_changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("good bye");
            Application.Exit();
            
        }

        private void fnfontBtn_Click(object sender, EventArgs e)
        {
            changeLbl.Font = new Font("Burbank Big Cd Bk", changeLbl.Font.Size);
            this.Text = fnfontBtn.Text;
                            
        }

        private void RobotoBtn_Click(object sender, EventArgs e)
        {
            changeLbl.Font = new Font("Roboto", changeLbl.Font.Size);
            this.Text = RobotoBtn.Text;
        }

        private void MVBoliBtn_Click(object sender, EventArgs e)
        {
            changeLbl.Font = new Font("MV Boli", changeLbl.Font.Size);
            this.Text = MVBoliBtn.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            changeLbl.Font = new Font(changeLbl.Font, FontStyle.Underline);
            this.Text = checkBox1.Text;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changeLbl.Font = new Font(changeLbl.Font, FontStyle.Bold);
            this.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            changeLbl.Font = new Font(changeLbl.Font, FontStyle.Italic);
            this.Text = checkBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeLbl.Font = new Font("Burbank Big Cd Bk", 10, FontStyle.Regular);
            this.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeLbl.Font = new Font("Burbank Big Cd Bk", 14, FontStyle.Regular);
            this.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            changeLbl.Font = new Font("Burbank Big Cd Bk", 18, FontStyle.Regular);
            this.Text = radioButton3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "fontchanger";
        }
    }
}
