using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace HardySave
{
    public partial class HardySafe : Form
    {

        //String selected;
        public HardySafe()
        {
            
            InitializeComponent();

            // wo bin ich?
            functions_sam.maybe_or_maybenot();
            //Console.WriteLine(Properties.Settings.Default.SAFE_ORT);

            //Speicherort for Textbox holen
            speicherORT_URL.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //ARRAY stellen zurweiterführende nutzung HAUPTARRAY
            String[] selectedArray = hol_dataAPP();

            // Hole Daten aus AppData (FOLDER)
            functions_sam.APP_sam_Folder(selectedArray, localbox, locallowbox, roamingbox);

            // testen internet
            functions_sam.internet_check(internetbox);

        }

        private void test1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locallowtxt_Click(object sender, EventArgs e)
        {

        }

        //Folder Name Holen
        private string lastName_DataURL(string dataURL)
        {
            int pos = dataURL.LastIndexOf('\\');
            string dataName = dataURL.Substring(pos + 1);

            return dataName;
        }

        //APPDATA Array holen folderstruktur
        private String[] hol_dataAPP()
        {
            String selected = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\appdata\\";
            String[] selectedArray = Directory.GetFileSystemEntries(selected);

            return selectedArray;
        }

        //SpeicherButton der Selectierten Folder speichern OHNE SPEICHERORT(BUTTON) kein SPEICHERN
        private void SaveTest_Click(object sender, EventArgs e)
        {

            int SAM_DATA_G = Math.Max(roamingbox.CheckedItems.Count, Math.Max(localbox.CheckedItems.Count, locallowbox.CheckedItems.Count));
            String[,] SAM_DATA_R = new String[3, SAM_DATA_G];
            String[] SAM_DATA_S = hol_dataAPP();

            functions_sam.APP_SAM_SAFE(SAM_DATA_S,SAM_DATA_R, localbox, locallowbox, roamingbox);

            Directory.CreateDirectory(speicherORT_URL.Text + "\\HardySAFE_SYSTEM");

            speicherORT.Enabled = true;

            functions_sam.check_SAFE(SAM_DATA_G ,SAM_DATA_R ,speicherORT_URL);

        }



        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        //Button fürs raussuchen vom speicherort ohne dem kein richtiges Speichern URL erfolderlich fürs Speichern
        private void speicherORT_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                speicherORT_URL.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                speicherORT_URL.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            SaveTest.Enabled = true;

        }


        private void speicherORT_URI_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SaveTest_MouseMove(object sender, MouseEventArgs e)
        {



        }

        private void SaveTest_MouseLeave(object sender, EventArgs e)
        {

            localbox.Enabled = true;
            locallowbox.Enabled = true;
            roamingbox.Enabled = true;

        }

        private void SaveTest_MouseEnter(object sender, EventArgs e)
        {


            localbox.Enabled = false;
            locallowbox.Enabled = false;
            roamingbox.Enabled = false;

        }

        private void locallowbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void localbox_MouseEnter(object sender, EventArgs e)
        {

            localbox.Focus();

        }

        private void locallowbox_MouseEnter(object sender, EventArgs e)
        {

            locallowbox.Focus();

        }

        private void roamingbox_MouseEnter(object sender, EventArgs e)
        {

            roamingbox.Focus();

        }

        private void roamingtxt_Click(object sender, EventArgs e)
        {

        }

        private void local_Click(object sender, EventArgs e)
        {

        }

        private void internet_Click(object sender, EventArgs e)
        {

        }

        private void internetbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
