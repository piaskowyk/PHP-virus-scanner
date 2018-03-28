using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PHP_virus_scaner
{
    public partial class Form1 : Form
    {
        public dynamic config;
        public int scanningFile = 0;
        public int allFile = 0;
        public int potentialRisk = 0;
        public int ignoreFile = 0;
        public int fCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string configJson = File.ReadAllText(@"config/config.json");
            dynamic configObj = JObject.Parse(configJson);
            this.config = configObj;
            lbStatus.Text = "Counting files...";
            lbStatus.Refresh();
            fCount = Directory.GetFiles(configObj.path.ToString(), "*", SearchOption.AllDirectories).Length;
            this.allFile = fCount;
            this.scanningFile = 0;
            this.potentialRisk = 0;
            this.ignoreFile = 0;
            label1.Text = fCount.ToString();
            label1.Refresh();
            lbStatus.Text = "Scaning file...";
            lbStatus.Refresh();
            this.startScanRecursive(configObj.path.ToString());
            button1.Enabled = true;
            this.updateCounter();
        }

        public void startScanRecursive(string path)
        {
            string[] files = Directory.GetFiles(path);
            string extension;
            bool next = false;
            foreach (string item in files)
            {
                next = false;
                extension = Path.GetExtension(item);
                foreach (string ext in this.config.ignoreExt)
                {
                    if (extension == ext)
                    {
                        next = true;
                    }
                }
                if (next) {
                    this.ignoreFile++;
                    continue;
                }
                this.scanFile(item);
            }

            string[] directories = Directory.GetDirectories(path);
            foreach (string item in directories)
            {
                next = false;
                foreach (string dir in this.config.ignoreDir) {
                    if (item == (this.config.path + "\\" + dir).ToString())
                    {
                        next = true;
                        continue;
                    }
                }
                if (next)
                {
                    this.ignoreFile += Directory.GetFiles(item, "*", SearchOption.AllDirectories).Length;
                    continue;
                }
                this.startScanRecursive(item);
            }
        }

        public void scanFile(string path)
        {   
            string raport = "";
            string text = File.ReadAllText(path);
            string[] lines = File.ReadAllLines(path);
            int lineNumber = 0;
            bool valid = true;
            int limit = 0;
            foreach (string line in lines)
            {
                foreach(string item in this.config.search)
                {
                    if (line.Contains(item))
                    {
                        valid = false;
                        raport += "Line: " + lineNumber + " - " + item + Environment.NewLine;
                        if(line.Length > 50)
                        {
                            limit = 50;
                        }
                        else
                        {
                            limit = line.Length;
                        }
                        raport += "Potential risk: " + Environment.NewLine + line.Substring(0, limit) + Environment.NewLine;
                    }
                }
            }

            if (!valid)
            {
                this.potentialRisk++;
                File.AppendAllText(this.config.outPath.ToString(), this.scanningFile + ": " + path + Environment.NewLine);
                try
                {
                    File.AppendAllText(this.config.outPath.ToString(), raport + Environment.NewLine);
                }
                catch (Exception e)
                {
                    File.AppendAllText(this.config.outPath.ToString(), "Contains unprintable character." + Environment.NewLine);
                }
                
            }
            else if (this.config.showAll.ToString() == "1")
            {
                File.AppendAllText(this.config.outPath.ToString(), this.scanningFile + ": " + path + Environment.NewLine + Environment.NewLine);
            }
            this.scanningFile++;
            this.updateCounter();
        }

        public void updateCounter()
        {
            lbScanFile.Text = this.scanningFile.ToString();
            lbIgnoreFile.Text = this.ignoreFile.ToString();
            lbPotentialRisk.Text = this.potentialRisk.ToString();
            lbScanFile.Refresh();
            lbIgnoreFile.Refresh();
            lbPotentialRisk.Refresh();
            progress.Value = 100 * (this.ignoreFile + this.scanningFile) / this.fCount;
            progress.Refresh();
            if (this.scanningFile + this.ignoreFile == this.allFile)
            {
                this.lbStatus.Text = "Complete";
                lbStatus.Refresh();
            }
        }

    }
}
