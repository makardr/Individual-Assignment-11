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
            if (pets[0] != null)
            {
                Label newLabel1 = new Label
                {
                    Text = pets[0].getName + " " + pets[0].getType + " " + pets[0].getAge
                };
                panelScreen.Controls.Add(newLabel1);

                newLabel1.Location = new Point(1, 1);
            }
            if (pets[1] != null)
            {
                Label newLabel2 = new Label
                {
                    Text = pets[1].getName + " " + pets[1].getType + " " + pets[1].getAge
                };
                panelScreen.Controls.Add(newLabel2);
                newLabel2.Location = new Point(1, 20);
            }
            if (pets[2] != null)
            {
                Label newLabel3 = new Label
                {
                    Text = pets[2].getName + " " + pets[2].getType + " " + pets[2].getAge
                };
                panelScreen.Controls.Add(newLabel3);
                newLabel3.Location = new Point(1, 40);
            }
            if (pets[3] != null)
            {
                Label newLabel4 = new Label
                {
                    Text = pets[3].getName + " " + pets[3].getType + " " + pets[3].getAge
                };
                panelScreen.Controls.Add(newLabel4);
                newLabel4.Location = new Point(1, 60);
            }
            if (pets[4] != null)
            {
                Label newLabel5 = new Label
                {
                    Text = pets[4].getName + " " + pets[4].getType + " " + pets[4].getAge
                };
                panelScreen.Controls.Add(newLabel5);
                newLabel5.Location = new Point(1, 80);
            }
            if (pets[5] != null)
            {
                Label newLabel5 = new Label
                {
                    Text = pets[5].getName + " " + pets[5].getType + " " + pets[5].getAge
                };
                panelScreen.Controls.Add(newLabel5);
                newLabel5.Location = new Point(1, 100);
            }
            if (pets[6] != null)
            {
                Label newLabel5 = new Label
                {
                    Text = pets[6].getName + " " + pets[6].getType + " " + pets[6].getAge
                };
                panelScreen.Controls.Add(newLabel5);
                newLabel5.Location = new Point(1, 120);
            }
            if (pets[7] != null)
            {
                Label newLabel6 = new Label
                {
                    Text = pets[7].getName + " " + pets[7].getType + " " + pets[7].getAge
                };
                panelScreen.Controls.Add(newLabel6);
                newLabel6.Location = new Point(1, 140);
            }
            if (pets[8] != null)
            {
                Label newLabel7 = new Label
                {
                    Text = pets[8].getName + " " + pets[8].getType + " " + pets[8].getAge
                };
                panelScreen.Controls.Add(newLabel7);
                newLabel7.Location = new Point(1, 160);
            }
            if (pets[9] != null)
            {
                Label newLabel8 = new Label
                {
                    Text = pets[9].getName + " " + pets[9].getType + " " + pets[9].getAge
                };
                panelScreen.Controls.Add(newLabel8);
                newLabel8.Location = new Point(1, 180);
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
