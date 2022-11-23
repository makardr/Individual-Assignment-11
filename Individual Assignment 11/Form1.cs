using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Individual_Assignment_11
{
    public partial class Form1 : Form
    {
        Pet[] pets = new Pet[10];
        int petsCreated=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (petsCreated != 10)
            {
                try
                {
                    pets[petsCreated] = new Pet(nameTextbox.Text, typeTextbox.Text, Int32.Parse(ageTextbox.Text));
                    petsCreated++;
                    refreshPanel();
                } catch
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }

        public void refreshPanel()
        {

            panelScreen.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (pets[i] != null)
                {
                    Label newLabel = new Label
                    {
                        Text = pets[i].getName + " " + pets[i].getType + " " + pets[i].getAge
                    };
                    panelScreen.Controls.Add(newLabel);
                    newLabel.Location = new Point(1, i*20);
                }
            }
        }

    }
    public class Pet { 
        private string petName;
        private string petType;
        private int petAge;
        public Pet(string name, string type, int age)
        {
            petName = name;
            petType = type;
            petAge = age;
        }
        public string getName
        {
            get { return petName; }
        }
        public string getType { 
            get { return petType; }
        }
        public int getAge
        {
            get { return petAge; }
        }
    }
}
