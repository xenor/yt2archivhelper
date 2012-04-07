using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public string[] config = new string[16];
        public List<System.Windows.Forms.Button> a;
        public Form4(Boolean lawl, ref List<System.Windows.Forms.Button> a)
        {
            InitializeComponent();
            //this.config = config;
            this.a = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*System.IO.Directory.GetCurrentDirectory() = textBox1.Text;
            this.config[1] = textBox2.Text;
            this.config[2] = textBox3.Text;

            string configFile = "/config.xml";
            string content = "<?xml version=\"1.0\"?>\r\n"
                    + "<config>\r\n"
                       + "\t<clientPath>" + textBox1.Text + "</clientPath>\r\n"
                       + "\t<unpackPath>" + textBox2.Text + "</unpackPath>\r\n"
                       + "\t<archiverName>" + textBox3.Text + "</archiverName>\r\n"
                    + "</config>";
            System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + configFile, content);

            MessageBox.Show("Einstellungen wurden übernommen und gespeichert.");

            this.a[0].Enabled = true;
            this.a[1].Enabled = true;
            this.a[2].Enabled = true;
            this.a[3].Enabled = true;
            this.a[4].Enabled = true;

            this.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*System.IO.Directory.GetCurrentDirectory() = textBox1.Text;
            this.config[1] = textBox2.Text;
            this.config[2] = textBox3.Text;
            MessageBox.Show("Einstellungen wurden übernommen.");
            this.a[0].Enabled = true;
            this.a[1].Enabled = true;
            this.a[2].Enabled = true;
            this.a[3].Enabled = true;
            this.a[4].Enabled = true;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.IO.Directory.GetCurrentDirectory();
            textBox2.Text = this.config[1];
            textBox3.Text = this.config[2];
            button3.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool fail = false;
            if (!System.IO.Directory.Exists(textBox1.Text) || !System.IO.Directory.Exists(textBox1.Text + "/pack"))
            {
                MessageBox.Show("Client Ordner nicht gefunden oder enthält keinen Pack-Ordner");
                fail = true;
            }
            if (!System.IO.File.Exists(textBox1.Text + "/" + textBox3.Text))
            {
                MessageBox.Show("Client Ordner enthält den angegebenen Archiver nicht.");
                fail = true;
            }
            if (fail == false)
            {
                button3.Enabled = true;
                button1.Enabled = true;
                MessageBox.Show("Es konnten keine Fehler in der Konfiguration festgestellt werden.");
            }
            else
            {
                button3.Enabled = false;
                button1.Enabled = false;
                this.a[0].Enabled = false;
                this.a[1].Enabled = false;
                this.a[2].Enabled = false;
                this.a[3].Enabled = false;
                this.a[4].Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = false;
        }
    }
}
