using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_BS6
{
    public partial class Form1 : Form
    {
        Farm farm;
        List<Animal> allAnimals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {

            listViewAnimals.Columns.Add("Type", 100);
            listViewAnimals.Columns.Add("Offspring", 80);
            listViewAnimals.Columns.Add("Sound", 80);
            listViewAnimals.Columns.Add("Milk (L)", 80);
            listViewAnimals.View = View.Details;

           
            int columnCount = listViewAnimals.Columns.Count;
            int totalWidth = listViewAnimals.Width - SystemInformation.VerticalScrollBarWidth; 
            int columnWidth = totalWidth / columnCount;

            foreach (ColumnHeader column in listViewAnimals.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            int cows = int.Parse(txtCows.Text);
            int sheep = int.Parse(txtSheep.Text);
            int goats = int.Parse(txtGoats.Text);

            farm = new Farm(cows, sheep, goats);
            allAnimals.Clear();
            AddAnimalsToListView();
            MessageBox.Show("Farm initialized!");
        }

        private void AddAnimalsToListView()
        {
            listViewAnimals.Items.Clear();
            int totalMilk = 0;
            int totalOffspringCows = 0, totalOffspringSheep = 0, totalOffspringGoats = 0;
            string sounds = "";

            // Thêm bò
            for (int i = 0; i < farm.Cows.Quantity; i++)
            {
                Cow cow = new Cow(1);
                int milkProduced = cow.ProduceMilk();
                int offspring = cow.GiveBirth();
                totalMilk += milkProduced;
                totalOffspringCows += offspring;
                sounds += cow.MakeSound() + " ";
                listViewAnimals.Items.Add(new ListViewItem(new[] { "Cow", offspring.ToString(), cow.MakeSound(), milkProduced.ToString() }));
                allAnimals.Add(cow);
            }

            // Thêm cừu
            for (int i = 0; i < farm.Sheep.Quantity; i++)
            {
                Sheep sheep = new Sheep(1);
                int milkProduced = sheep.ProduceMilk();
                int offspring = sheep.GiveBirth();
                totalMilk += milkProduced;
                totalOffspringSheep += offspring;
                sounds += sheep.MakeSound() + " ";
                listViewAnimals.Items.Add(new ListViewItem(new[] { "Sheep", offspring.ToString(), sheep.MakeSound(), milkProduced.ToString() }));
                allAnimals.Add(sheep);
            }

            // Thêm dê
            for (int i = 0; i < farm.Goats.Quantity; i++)
            {
                Goat goat = new Goat(1);
                int milkProduced = goat.ProduceMilk();
                int offspring = goat.GiveBirth();
                totalMilk += milkProduced;
                totalOffspringGoats += offspring;
                sounds += goat.MakeSound() + " ";
                listViewAnimals.Items.Add(new ListViewItem(new[] { "Goat", offspring.ToString(), goat.MakeSound(), milkProduced.ToString() }));
                allAnimals.Add(goat);
            }

            // Cập nhật TextBox cho từng loại
            txtTotalCows.Text = (farm.Cows.Quantity + totalOffspringCows).ToString();
            txtTotalSheep.Text = (farm.Sheep.Quantity + totalOffspringSheep).ToString();
            txtTotalGoats.Text = (farm.Goats.Quantity + totalOffspringGoats).ToString();
            txtTotalMilk.Text = totalMilk.ToString();
            txtSounds.Text = sounds.Trim();
        }

        private void btnSounds_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSounds.Text);
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Milk: {txtTotalMilk.Text} liters");
        }

        private void btnOffspring_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Offspring: {txtTotalCows.Text} cows, {txtTotalSheep.Text} sheep, {txtTotalGoats.Text} goats");
        }
    }
}
