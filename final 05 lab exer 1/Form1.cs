using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_05_lab_exer_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string getInput = txtInput.Text;

            string fileName = txtFileName.Text + ".txt";

            string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string docPath = Path.Combine(mainPath, "05LabFiles");

            Directory.CreateDirectory(docPath);

            string fullPath = Path.Combine(docPath, fileName);


            using (StreamWriter outputFile = new StreamWriter(fullPath))
            {
                outputFile.WriteLine(getInput);
            }

            MessageBox.Show("File created successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();

            this.Hide();
        }
    }
}
