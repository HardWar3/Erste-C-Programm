using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace HardySave
{

    public static class functions_sam
    {


        // Speicher ort ermitteln
        public static string speicher_me_here()
        {
            return (System.Reflection.Assembly.GetExecutingAssembly().Location).Substring(0, System.Reflection.Assembly.GetExecutingAssembly().Location.LastIndexOf('\\')+1);
        }

        // maybe or maybe not
        public static void maybe_or_maybenot()
        {
            
                Properties.Settings.Default.SAFE_ORT = speicher_me_here();
                Properties.Settings.Default.Save();
          
        }


        // Hole Daten aus AppData (FOLDER)
        public static void APP_sam_Folder(String[] selectedArray, CheckedListBox localbox, CheckedListBox locallowbox, CheckedListBox roamingbox)
        {

            foreach (String item in selectedArray)
            {

                string testName = lastName_DataURL(item);
                Console.WriteLine(testName);

                if (testName == "Local")
                {

                    String[] localFolder = dataSAM_HOL(item);

                    localbox.Items.AddRange(dataSAM_withURL(localFolder));

                }
                else if (testName == "LocalLow")
                {

                    String[] locallowFolder = dataSAM_HOL(item);

                    locallowbox.Items.AddRange(dataSAM_withURL(locallowFolder));

                }
                else if (testName == "Roaming")
                {

                    String[] roamingFolder = dataSAM_HOL(item);

                    roamingbox.Items.AddRange(dataSAM_withURL(roamingFolder));

                }


            }

        }

        //APPDATA folderstruktur der Unterordner Holen
        public static String[] dataSAM_HOL(string dataFOLDER)
        {

            String[] dataSAM = Directory.GetFileSystemEntries(dataFOLDER);

            return dataSAM;
        }

        //Folder Name holen übergabe WITH URL auswurf ohne URL
        public static String[] dataSAM_withURL(String[] dataSAM)
        {
            String[] dataEnd_SAM = new string[dataSAM.Length];

            for (int index = 0; index < dataSAM.Length; index++)
            {

                //Console.WriteLine(lastName_DataURL(dataSAM[index]));
                dataEnd_SAM[index] = lastName_DataURL(dataSAM[index]);

            }

            return dataEnd_SAM;
        }

        //Folder Name Holen
        public static string lastName_DataURL(string dataURL)
        {
            int pos = dataURL.LastIndexOf('\\');
            string dataName = dataURL.Substring(pos + 1);

            return dataName;
        }

        public static void APP_SAM_SAFE(String[] SAM_DATA_S, String[,] SAM_DATA_R, CheckedListBox localbox, CheckedListBox locallowbox, CheckedListBox roamingbox)
        {

            foreach (String item in SAM_DATA_S)
            {

                string testName = lastName_DataURL(item);
                //Console.WriteLine(testName);

                if (testName == "Local")
                {

                    for (int i = 0; i < localbox.CheckedItems.Count; i++)
                    {

                        //Console.WriteLine(data_url_hol(localbox.CheckedItems[i].ToString(), item));               
                        SAM_DATA_R[0, i] = data_url_hol(localbox.CheckedItems[i].ToString(), item);

                    }

                }
                else if (testName == "LocalLow")
                {

                    for (int i = 0; i < locallowbox.CheckedItems.Count; i++)
                    {

                        //Console.WriteLine(data_url_hol(locallowbox.CheckedItems[i].ToString(), item));
                        SAM_DATA_R[1, i] = data_url_hol(locallowbox.CheckedItems[i].ToString(), item);

                    }

                }
                else if (testName == "Roaming")
                {

                    for (int i = 0; i < roamingbox.CheckedItems.Count; i++)
                    {

                        // Console.WriteLine(data_url_hol(roamingbox.CheckedItems[i].ToString(), item));
                        SAM_DATA_R[2, i] = data_url_hol(roamingbox.CheckedItems[i].ToString(), item);

                    }

                }

            }

        }

        //URL vom FolderNamen holen !!! WICHTIG FÜR DAS SPEICHERN !!! because without this nothing right saving URL erfolderlich
        public static string data_url_hol(string dataNAME, string dataURL)
        {

            String[] dataSAM = functions_sam.dataSAM_HOL(dataURL);

            string rightURL = "kekse";

            foreach (String item in dataSAM)
            {
                if (lastName_DataURL(item) != dataNAME)
                {
                    continue;
                }
                else
                {
                    rightURL = item;
                }
            }

            return rightURL;

        }

        public static void check_SAFE(int SAM_DATA_G,String[,] SAM_DATA_R,TextBox speicherORT_URL)
        {

            if (Directory.GetFileSystemEntries(speicherORT_URL.Text + "\\HardySAFE_SYSTEM").Length == 0)
            {

                safe_vorgang(SAM_DATA_G, SAM_DATA_R, speicherORT_URL);

                MessageBox.Show("Speiche Vorgang ABGESCHLOSSEN");

            }
            else
            {

                string abfrageTEXT = "Ordner ist schon vorhanden!\n\n\"Ja\" - Für ich möchte den Ornder verwenden(\"Inhalt des Ordners wird gelöscht\")\n\"NEIN\" - Für ich möchte einen anderen Speicher Ort angeben!";

                DialogResult result = MessageBox.Show(abfrageTEXT, "ICH BIN SCHON VORHANDEN! Oo", MessageBoxButtons.YesNo);

                Console.WriteLine(result);

                if (result == DialogResult.Yes)
                {

                    Directory.Delete(speicherORT_URL.Text + "\\HardySAFE_SYSTEM", true);

                    safe_vorgang(SAM_DATA_G, SAM_DATA_R, speicherORT_URL);

                    MessageBox.Show("Speiche Vorgang ABGESCHLOSSEN");

                }
                else
                {
                    return;
                }



            }

        }

        //nicht mein CODE **angucken um es besser zu verstehen** 
        public static void CopyDirectory(string dirSource, string dirTarget)
        {
            // wenn aktueller Ordner nicht existiert -> ersstellen
            if (!Directory.Exists(dirTarget))
                Directory.CreateDirectory(dirTarget);

            // Unterverzeichnise durchlaufen und Funktion mit dazu gehörigen Zielpfad erneut aufrufen (Rekursion)
            foreach (string subDir in Directory.GetDirectories(dirSource))
                CopyDirectory(subDir,
                              dirTarget + "\\\\" + Path.GetFileName(subDir));

            // alle enthaltenden Dateien des aktuellen Verzeichnisses durchlaufen und Kopieren
            foreach (string strFile in Directory.GetFiles(dirSource))
                File.Copy(strFile,
                          dirTarget + "\\\\" + Path.GetFileName(strFile),
                          true);
        }

        public static void safe_vorgang(int SAM_DATA_G, String[,] SAM_DATA_R, TextBox speicherORT_URL)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < SAM_DATA_G; j++)
                {
                    if (i == 0)
                    {

                        Directory.CreateDirectory(speicherORT_URL.Text + "\\HardySAFE_SYSTEM\\Local");

                        if (SAM_DATA_R[i, j] != null)
                        {
                            CopyDirectory(SAM_DATA_R[i, j], speicherORT_URL.Text + "\\HardySAFE_SYSTEM\\Local\\" + lastName_DataURL(SAM_DATA_R[i, j]));
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else if (i == 1)
                    {

                        Directory.CreateDirectory(speicherORT_URL.Text + "\\HardySAFE_SYSTEM\\LocalLow");

                        if (SAM_DATA_R[i, j] != null)
                        {
                            CopyDirectory(SAM_DATA_R[i, j], speicherORT_URL.Text + "\\HardySAFE_SYSTEM\\LocalLow\\" + lastName_DataURL(SAM_DATA_R[i, j]));
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else if (i == 2)
                    {

                        Directory.CreateDirectory(speicherORT_URL.Text + "\\HardySAFE_SYSTEM\\Roaming");

                        if (SAM_DATA_R[i, j] != null)
                        {
                            CopyDirectory(SAM_DATA_R[i, j], speicherORT_URL.Text + "\\HardySAFE_SYSTEM\\Roaming\\" + lastName_DataURL(SAM_DATA_R[i, j]));
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else
                    {
                        continue;
                    }
                }

                //Console.WriteLine(i);

            }

        }

        // Internet checken ob vorhanden
        public static void internet_check(CheckedListBox internetbox)
        {

            // Console.WriteLine(internetbox.Items[1]);





        }

    }
}
