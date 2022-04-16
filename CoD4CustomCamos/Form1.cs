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
using System.IO.Compression;

namespace CoD4CustomCamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the user a message confirming if they want to install custom camos
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to install custom camos?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                checklocalizedEngIW07();
            }
        }

        public void checklocalizedEngIW07()
        {
            // Messy but an easy way of checking if each file exists
            if (File.Exists("localized_english_iw07.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("You already have custom camos installed. Open 'localized_english_iw07.iwd' in 7-Zip or WinRAR, add an images folder and put your camos in there.", "Already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists("localized_english_iw07.iwd"))
            {
                checkOtherFilesInstall();
                createLE07();
                DialogResult dialogResult = MessageBox.Show("Required files renamed and created. Open 'localized_english_iw07.iwd' in 7-Zip or WinRAR, open the images folder and drag your camos in there.");
            }
        }

        public void checkOtherFilesInstall()
        {
            // Very messy but it works, don't slander me
            if (File.Exists("iw_00.iwd"))
            {
                renIW00();
            }
            else if (!File.Exists("iw_00.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_00.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("iw_01.iwd"))
            {
                renIW01();
            }
            else if (!File.Exists("iw_01.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_01.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("iw_02.iwd"))
            {
                renIW02();
            }
            else if (!File.Exists("iw_02.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_02.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("iw_03.iwd"))
            {
                renIW03();
            }
            else if (!File.Exists("iw_03.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_03.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("iw_04.iwd"))
            {
                renIW04();
            }
            else if (!File.Exists("iw_04.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_04.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("iw_05.iwd"))
            {
                renIW05();
            }
            else if (!File.Exists("iw_05.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_05.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("iw_06.iwd"))
            {
                renIW06();
            }
            else if (!File.Exists("iw_06.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File iw_06.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void renIW00()
        {
            File.Move("iw_00.iwd", "localized_english_aa.iwd");

        }

        public void renIW01()
        {
            File.Move("iw_01.iwd", "localized_english_aab.iwd");

        }

        public void renIW02()
        {
            File.Move("iw_02.iwd", "localized_english_aac.iwd");

        }

        public void renIW03()
        {
            File.Move("iw_03.iwd", "localized_english_aad.iwd");

        }

        public void renIW04()
        {
            File.Move("iw_04.iwd", "localized_english_aae.iwd");

        }

        public void renIW05()
        {
            File.Move("iw_05.iwd", "localized_english_aaf.iwd");

        }

        public void renIW06()
        {
            File.Move("iw_06.iwd", "localized_english_aag.iwd");

        }

        public void createLE07()
        {
            Directory.CreateDirectory("localized_english_iw07");
            Directory.CreateDirectory("localized_english_iw07/images");
            ZipFile.CreateFromDirectory("localized_english_iw07", "localized_english_iw07.iwd");
            Directory.Delete("localized_english_iw07/images");
            Directory.Delete("localized_english_iw07");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the user a message confirming if they want to install custom camos
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove custom camos?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                removeCamo();
                File.Delete("localized_english_iw07.iwd");
                MessageBox.Show("Required files returned to their original state. You now have a pure client.");
            }
        }

        public void removeCamo()
        {
            // Very messy but it works, don't slander me
            if (File.Exists("localized_english_aa.iwd"))
            {
                renLEAA();
            }
            else if (!File.Exists("localized_english_aa.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aa.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("localized_english_aab.iwd"))
            {
                renLEAAB();
            }
            else if (!File.Exists("localized_english_aab.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aab.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("localized_english_aac.iwd"))
            {
                renLEAAC();
            }
            else if (!File.Exists("localized_english_aac.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aac.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("localized_english_aad.iwd"))
            {
                renLEAAD();
            }
            else if (!File.Exists("localized_english_aad.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aad.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("localized_english_aae.iwd"))
            {
                renLEAAE();
            }
            else if (!File.Exists("localized_english_aae.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aae.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("localized_english_aaf.iwd"))
            {
                renLEAAF();
            }
            else if (!File.Exists("localized_english_aaf.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aaf.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("localized_english_aag.iwd"))
            {
                renLEAAG();
            }
            else if (!File.Exists("localized_english_aag.iwd"))
            {
                DialogResult dialogResult = MessageBox.Show("File localized_english_aag.iwd doesn't exist.", "File doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void renLEAA()
        { 
            File.Move("localized_english_aa.iwd", "iw_00.iwd");

        }

        public void renLEAAB()
        {
            File.Move("localized_english_aab.iwd", "iw_01.iwd");

        }

        public void renLEAAC()
        {
            File.Move("localized_english_aac.iwd", "iw_02.iwd");

        }

        public void renLEAAD()
        {
            File.Move("localized_english_aad.iwd", "iw_03.iwd");

        }

        public void renLEAAE()
        {
            File.Move("localized_english_aae.iwd", "iw_04.iwd");

        }

        public void renLEAAF()
        {
            File.Move("localized_english_aaf.iwd", "iw_05.iwd");

        }

        public void renLEAAG()
        {
            File.Move("localized_english_aag.iwd", "iw_06.iwd");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Open 'localized_english_iw07.iwd' with 7-Zip or WinRAR, open the images folder and paste your camos in", "How to", MessageBoxButtons.OK);
        }
    }
}
