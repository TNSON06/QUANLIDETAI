using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class AddForm : Form
    {
        public delegate void MyDel(string name);
        public MyDel d { get; set; }
        public AddForm()
        {
            InitializeComponent();
            SetCBBCDT();
            SetCBBCN();


        }
        public void SetCBBCDT()
        {
            cbbCapDT_Add.Items.Add(new CBBItem
            {
                value = 0,
                Text = "All"
            });
            cbbCapDT_Add.Items.AddRange(DTBUS.Instance.GetCapDTCBB().ToArray());
        }
        public void SetCBBCN()
        {
            cbbChuNhiem_Add.Items.Add(new CBBItem
            {
                value = 0,
                Text = "All"
            });
            cbbChuNhiem_Add.Items.AddRange(DTBUS.Instance.GetListCBBCN().ToArray());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool? tt = null;
            if (rbtnCHT_Add.Checked == false && rbtnHT_Add.Checked == true)
            {
                tt = true;
            }
            else if (rbtnCHT_Add.Checked == true && rbtnHT_Add.Checked == false)
            {
                tt = false;
            }
            else if (rbtnHT_Add.Checked == false && rbtnCHT_Add.Checked == false)
            {
                tt = null;
            }

            CBBItem selectedCBBItem = (CBBItem)cbbCapDT_Add.SelectedItem;

            int itemValue = (selectedCBBItem != null) ? selectedCBBItem.value : 0;

            DeTai dt = new DeTai
            (
                 int.TryParse(txtMaDT_Add.Text, out int maDT) ? maDT : 0,
                txtTenDT_Add.Text,
                tt,
                itemValue,

              (DateTime?)dateTimePicker1?.Value,
                cbbChuNhiem_Add.Text


            );


            if (dt != null)
            {
                DTBUS.Instance.ExcuteDB(dt);
            }

            MessageBox.Show("Them thanh cong");
            d(null);
            this.Dispose();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}
