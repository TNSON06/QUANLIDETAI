namespace GUI
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCHT_Add = new System.Windows.Forms.RadioButton();
            this.rbtnHT_Add = new System.Windows.Forms.RadioButton();
            this.cbbChuNhiem_Add = new System.Windows.Forms.ComboBox();
            this.cbbCapDT_Add = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTenDT_Add = new System.Windows.Forms.TextBox();
            this.txtMaDT_Add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbbChuNhiem_Add);
            this.groupBox1.Controls.Add(this.cbbCapDT_Add);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTenDT_Add);
            this.groupBox1.Controls.Add(this.txtMaDT_Add);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCHT_Add);
            this.groupBox2.Controls.Add(this.rbtnHT_Add);
            this.groupBox2.Location = new System.Drawing.Point(491, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 42);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rbtnCHT_Add
            // 
            this.rbtnCHT_Add.AutoSize = true;
            this.rbtnCHT_Add.Location = new System.Drawing.Point(106, 16);
            this.rbtnCHT_Add.Name = "rbtnCHT_Add";
            this.rbtnCHT_Add.Size = new System.Drawing.Size(107, 17);
            this.rbtnCHT_Add.TabIndex = 1;
            this.rbtnCHT_Add.TabStop = true;
            this.rbtnCHT_Add.Text = "Chưa hoàn thành";
            this.rbtnCHT_Add.UseVisualStyleBackColor = true;
            // 
            // rbtnHT_Add
            // 
            this.rbtnHT_Add.AutoSize = true;
            this.rbtnHT_Add.Location = new System.Drawing.Point(8, 16);
            this.rbtnHT_Add.Name = "rbtnHT_Add";
            this.rbtnHT_Add.Size = new System.Drawing.Size(81, 17);
            this.rbtnHT_Add.TabIndex = 0;
            this.rbtnHT_Add.TabStop = true;
            this.rbtnHT_Add.Text = "Hoàn thành";
            this.rbtnHT_Add.UseVisualStyleBackColor = true;
            // 
            // cbbChuNhiem_Add
            // 
            this.cbbChuNhiem_Add.FormattingEnabled = true;
            this.cbbChuNhiem_Add.Location = new System.Drawing.Point(491, 79);
            this.cbbChuNhiem_Add.Name = "cbbChuNhiem_Add";
            this.cbbChuNhiem_Add.Size = new System.Drawing.Size(220, 21);
            this.cbbChuNhiem_Add.TabIndex = 10;
            // 
            // cbbCapDT_Add
            // 
            this.cbbCapDT_Add.FormattingEnabled = true;
            this.cbbCapDT_Add.Location = new System.Drawing.Point(491, 35);
            this.cbbCapDT_Add.Name = "cbbCapDT_Add";
            this.cbbCapDT_Add.Size = new System.Drawing.Size(220, 21);
            this.cbbCapDT_Add.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtTenDT_Add
            // 
            this.txtTenDT_Add.Location = new System.Drawing.Point(99, 76);
            this.txtTenDT_Add.Name = "txtTenDT_Add";
            this.txtTenDT_Add.Size = new System.Drawing.Size(246, 20);
            this.txtTenDT_Add.TabIndex = 7;
            // 
            // txtMaDT_Add
            // 
            this.txtMaDT_Add.Location = new System.Drawing.Point(99, 35);
            this.txtMaDT_Add.Name = "txtMaDT_Add";
            this.txtMaDT_Add.Size = new System.Drawing.Size(246, 20);
            this.txtMaDT_Add.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chủ nhiệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cấp đề tài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhận ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đề tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề tài";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(246, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(457, 241);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 24);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Cancel";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenDT_Add;
        private System.Windows.Forms.TextBox txtMaDT_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnCHT_Add;
        private System.Windows.Forms.RadioButton rbtnHT_Add;
        private System.Windows.Forms.ComboBox cbbChuNhiem_Add;
        private System.Windows.Forms.ComboBox cbbCapDT_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCal;
    }
}