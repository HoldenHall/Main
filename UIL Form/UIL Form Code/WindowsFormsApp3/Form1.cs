using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class UIL : Form
    {
        TextHolder holder = new TextHolder();
        public UIL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {     
            string Flash_Drive_folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Flash_Drive_folderPath = folderBrowserDialog1.SelectedPath;
                Flash_Drive_Box.Text = Flash_Drive_folderPath;
                holder.Set_Flash(Flash_Drive_folderPath);
            }
        }

        public void Recorder_Button_Click(object sender, EventArgs e)
        {
            string Recorder_folderPath = "";
            FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog();
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                Recorder_folderPath = folderBrowserDialog2.SelectedPath;
                Recorder_box.Text = Recorder_folderPath;
                holder.Set_Recorder(Recorder_folderPath);
            }
        }

        public void Enter_button_Click(object sender, EventArgs e)
        {
            
            var allFiles = Directory.GetFiles(holder.Get_Recorder(), "*.MP3", SearchOption.AllDirectories);
            foreach (string path in allFiles)
            {
                string name = holder.Get_School();
                name+=Convert.ToString(holder.Get_Counter());
                holder.Increment_Counter();
                //Path.GetFileName(path);
                string destination = holder.Get_Flash()+ name+".MP3";
                File.Move(path,destination);
            }
        }
    
        public void School_Box_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the name of the current school that is getting judged in the \"School Name\" text box.\n\n" +
                "Press Enter.\n\nDo not alter the \"School Name\" text box until after you are done with that school.\n\n" +
                "Choose the Flash Drive Path using the browse button.\n\n(Click Flash Drive then choose OK)\n\n" +
                "Choose the Recorder Path using the same method as the Flash Drive Path.\n\nPress Run, the mp3 files should now be in the flash drive accompanied with a number.\n" +
                "\n If the recorders all have the same name you do not need to change the" +
                " path when switching to the other recorders.\n\n(Otherwise hit browse)\n\nRepeat.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Program made to make file transfer easier/faster\nNot an official app\nHolden Hall 2018");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change school the school name?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                holder.Set_Counter(1);
                holder.Set_School(School_Box.Text);
            }
            else if (dialogResult == DialogResult.No)
            {
                School_Box.Text = holder.Get_School();
            }
        }

        private void School_Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change school the school name?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    holder.Set_Counter(1);
                    holder.Set_School(School_Box.Text);
                }
                else if (dialogResult == DialogResult.No)
                {
                    School_Box.Text = holder.Get_School();
                }
            }
        }

        private void Flash_Drive_Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                holder.Set_Flash(Flash_Drive_Box.Text);
            }
        }
        private void Recorder_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                holder.Set_Recorder(Recorder_box.Text);
            }
        }
    }


    public class TextHolder{

        public static Form Form1;

        string Recorder_hold;
        string Flash_Drive_hold;
        string School_hold;
        int counter_hold;

        public void Set_School(string School_text)
        {
            School_hold = School_text;
        }
        public string Get_School()
        {
            return School_hold;
        }
        public void Set_Counter(int counter)
        {
            counter_hold = counter;
        }
        public void Increment_Counter()
        {
            counter_hold++;
        }
        public int Get_Counter()
        {
            return counter_hold;
        }
        public void Set_Recorder(string Record_text)
        {
            Recorder_hold = Record_text;
        }
        public string Get_Recorder()
        {
            return Recorder_hold;
        }

        public void Set_Flash(string Flash_text)
        {
            Flash_Drive_hold = Flash_text;
        }
        public string Get_Flash()
        {
            return Flash_Drive_hold;
        }
    }
}