using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDuLich
{
    public partial class DialogThem : Form
    {
        public DialogThem()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_loaiTour(object sender, EventArgs e)
        {

        }

        private void comboBox1_loaiTour(object sender, EventArgs e)
        {

        }

        private void textBox1_tenTour(object sender, EventArgs e)
        {

        }

        private void tabPage1_giaTour(object sender, EventArgs e)
        {

        }

        private void tabPage2_diaDiem(object sender, EventArgs e)
        {
        }

        private void label3_giaTour(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_timeBatDau(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_timeKetThuc(object sender, EventArgs e)
        {

        }

        private void DialogThem_Load(object sender, EventArgs e)
        {
            //auto load listbox1
            for(int i = 1; i < 20; i++)
            {
                listBox1.Items.Add("Item " + i.ToString());
                //load combobox
                comboBox1.Items.Add("Item " + i.ToString());
            }
            //----------//
           
        }

        private void button1_themDiaDiemTour(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_xoaDiaDiemTour(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_allTour(object sender, EventArgs e)
        {
            
        }

        private void listBox2_dsDiaDiem(object sender, EventArgs e)
        {

        }
    }
}
