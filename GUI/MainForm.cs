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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetCBBCDT();
            SetCBBCN();
            SetCBBSort();
        }
        public void SetCBBCDT()
        {
            cbbCapDT.Items.Add(new CBBItem
            {
                value = 0,
                Text = "All"
            });
            cbbCapDT.Items.AddRange(DTBUS.Instance.GetCapDTCBB().ToArray());
        }
        public void SetCBBCN()
        {
            cbbChuNhiem.Items.Add(new CBBItem
            {
                value = 0,
                Text = "All"
            });
            cbbChuNhiem.Items.AddRange(DTBUS.Instance.GetListCBBCN().ToArray());
        }
        public void SetCBBSort()
        {
            cbbSort.Items.AddRange(DTBUS.Instance.GetListCBBSort().ToArray());
        }
        private void ShowDGV(string name)
        {
            dataGridView1.DataSource = DTBUS.Instance.GetListDT(name);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV(null);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng đang được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị của các ô trong hàng đang được chọn
                txtMaDT.Text = selectedRow.Cells["MaDT"].Value.ToString();
                txtTenDT.Text = selectedRow.Cells["TenDT"].Value.ToString();
                dateTimePicker1.Value = (DateTime)selectedRow.Cells["NgayNhanDT"].Value;
                cbbChuNhiem.Text = selectedRow.Cells["ChuNhiemDT"].Value.ToString();
          
                if (selectedRow.Cells["TinhTrang"].Value.ToString() == "True")
                {
                    rbtnHT.Checked = true;
                    rbtnCHT.Checked = false;

                }
                else if (selectedRow.Cells["TinhTrang"].Value.ToString() == "False")
                {
                    rbtnHT.Checked = false;
                    rbtnCHT.Checked = true;
                }
                else
                {
                    rbtnHT.Checked = false;
                    rbtnCHT.Checked = false;
                }
           
                int maKhoaToSelect = (int)selectedRow.Cells["MaCapDT"].Value;

                // Duyệt qua danh sách mục trong ComboBox
                for (int i = 0; i < cbbCapDT.Items.Count; i++)
                {
                    CBBItem item = (CBBItem)cbbCapDT.Items[i];
                    if (item.value == maKhoaToSelect)
                    {
                        // Nếu tìm thấy giá trị, chọn nó
                        cbbCapDT.SelectedIndex = i;
                        break;
                    }
                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool? tt = null;
            if (rbtnCHT.Checked == false && rbtnHT.Checked == true)
            {
                tt = true;
            }
            else if (rbtnCHT.Checked == true && rbtnHT.Checked == false)
            {
                tt = false;
            }
            else if (rbtnHT.Checked == false && rbtnCHT.Checked == false)
            {
                tt = null;
            }

            CBBItem selectedCBBItem = (CBBItem)cbbCapDT.SelectedItem;

            int itemValue = (selectedCBBItem != null) ? selectedCBBItem.value : 0;

            DeTai d = new DeTai
            (
                 int.TryParse(txtMaDT.Text, out int maDT) ? maDT : 0,
                txtTenDT.Text,
                tt,
                itemValue,

              (DateTime?)dateTimePicker1?.Value,
                cbbChuNhiem.Text
               
                 
            );


            if (d != null)
            {
                DTBUS.Instance.ExcuteDB(d);
            }
            ShowDGV(null);
            MessageBox.Show("Update thanh cong");
            ClearComponents();
        }
        public void ClearComponents()
        {
            txtMaDT.Text = string.Empty;
            txtTenDT.Text = string.Empty;
            
            dateTimePicker1.Value = DateTime.Now;

            rbtnCHT.Checked = false;
            rbtnHT.Checked = false;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> LMDT = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    LMDT.Add(row.Cells["MaDT"].Value.ToString());
                }
                DTBUS.Instance.DelDT(LMDT);

                ShowDGV(null);
                MessageBox.Show("Xoa thanh cong");
                ClearComponents();
            }
            else
            {
                MessageBox.Show("Chon hang di cu");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtMaDT.Enabled = false;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<DeTai> listDT = new List<DeTai>();
            if (txtSearch.Text.Length == 0)
            {
                listDT = DTBUS.Instance.GetListDT(null);
            }
            else
            {
                listDT = DTBUS.Instance.GetListDT(txtSearch.Text);
            }





            switch (cbbSort.Text)
            {
                case "MaDT":
                    listDT.Sort((x, y) => x.MaDT.CompareTo(y.MaDT));
                    MessageBox.Show("Sap xep thanh cong");
                    break;
                case "TenDT":
                    listDT.Sort((x, y) => string.Compare(x.TenDT, y.TenDT));
                    MessageBox.Show("Sap xep thanh cong");
                    break;
                case "MaCapDT":
                    listDT.Sort((x, y) => x.MaCapDT.CompareTo(y.MaCapDT));
                    MessageBox.Show("Sap xep thanh cong");
                    break;
                case "NgayNhanDT":
                    listDT = listDT.OrderBy(x => x.NgayNhanDT).ToList();
                    MessageBox.Show("Sap xep thanh cong");
                    break;
                default:
                    MessageBox.Show("Chon thuoc tinh di cu");
                    break;
            }




            dataGridView1.DataSource = listDT;
            dataGridView1.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.d = new AddForm.MyDel(ShowDGV);
            add.Show();
        }
    }
}
