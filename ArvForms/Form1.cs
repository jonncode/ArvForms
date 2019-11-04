using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArvForms
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            animals.Add(new Dog("Dogge"));
            animals.Add(new Cat("Yeet"));
            animals.Add(new Bird("Cheeto"));
            foreach (Animal a in animals)
            {
                cbNames.Items.Add(a.Name);
            }

        }

        private void CbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Animal animal = animals[selectedIndex];
                lbSpecies.Text = animal.Species.ToString();
                pictureBox1.Image = imageList1.Images[(int)animal.Species];
                lbCanFly.Text = (animal.CanFly ? "Kan flyga" : "Kan INTE flyga");
            }
            else
            {
                lbCanFly.Text = "Kan INTE flyga";
                pictureBox1.Image = null;
            }
        }
    }
}
