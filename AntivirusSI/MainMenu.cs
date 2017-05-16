using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusSI
{
    public partial class MainMenu : Form
    {
        private string folderPath;
        string baza = Directory.GetCurrentDirectory() + "/baza.txt";

        public MainMenu()
        {
            InitializeComponent();
        }

        public string FolderPath
        {
            get
            {
                return folderPath;
            }

            set
            {
                folderPath = value;
            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                txtMapa.Text = folderPath;
                btnAnaliziraj.Enabled = true;
            }

        }

        private void btnAnaliziraj_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            string[] entries = Directory.GetFileSystemEntries(
               folderPath, "*", SearchOption.AllDirectories);


            StreamReader bazaPodaci = new StreamReader(baza);
            string line,  readText, hash, rezultat = "";
            List<string> myCollection = new List<string>();

            while ((line = bazaPodaci.ReadLine()) != null)
            {
                myCollection.Add(line);

            }
            foreach (var file in entries)
            {
                readText = File.ReadAllText(file);
                hash = generirajHash(readText);
               foreach(String stavka in myCollection)
                {
                    if (stavka.Equals(hash))
                    {
                        rezultat += file + Environment.NewLine;
                        brojac++;
                    }
                }
            }
            lblUkupanBroj.Text = brojac.ToString();
            txtListaVirusa.Text = rezultat;
        }

 
        public string generirajHash(string tekst)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(tekst);
            SHA512 sha = new SHA512CryptoServiceProvider();
            byte[] hash = sha.ComputeHash(inputBytes);
            string hashString = "";
            foreach (byte b in hash)
            {
                hashString += String.Format("{0:x2}", b);

            }
            return hashString;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            btnAnaliziraj.Enabled = true;
            bool fileExist = File.Exists(baza);
            provjeriStanje(fileExist);
          
        }
        public void provjeriStanje(bool fileExists)
        {

            if (fileExists)
            {
                btnOdaberi.Enabled = true;
                btnAnaliziraj.Enabled = false;

            }
            else
            {
                btnOdaberi.Enabled = false;
                btnAnaliziraj.Enabled = false;
            }
        }
    }

}