using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_TourDuLich;

namespace TourDuLich
{
    public partial class Form1 : Form
    {
        BUS_Tour busTour = new BUS_Tour();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void DanhSachTour(object sender, EventArgs e)
        {

            dataGridView1.DataSource = busTour.getTour().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DiaDiem(object sender, EventArgs e)
        {
            
        }

        private void xoa(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int matour = Convert.ToInt16(row.Cells[0].Value.ToString());

                const string message = "Ban co chac chan xoa ?";
                const string caption = "Closing";
                var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {

                    if (busTour.xoaTour(matour))
                    {
                        dataGridView1.DataSource = busTour.getTour().Tables[0];
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Xoa khong thanh cong");
                    }
                }

            }
            else
            {
                MessageBox.Show("Hay chon thanh vien muon xoa");
            }
        }

        private void sua(object sender, EventArgs e)
        {
            //Show dialog Sua
            DialogSua dialog = new DialogSua();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog(this);
            //---------------
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //if(txtTen.Text !=)
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int matour = Convert.ToInt16(row.Cells[0].Value.ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTour.getTour().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them(object sender, EventArgs e)
        {
            DialogThem dialog = new DialogThem();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog(this);
           
        }
    }
}
