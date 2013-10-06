using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "รายการที่เลือก :" + Environment.NewLine;
            if (optMale.Checked == true)
            {
                str = str + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                str = str + "เพศ : หญิง" + Environment.NewLine;
            }
            str = str + "ระดับการศึกษา:" + Environment.NewLine;
            if (opt1.Checked == true)
            {
                str = str + "ปริญญาตรี" + Environment.NewLine;
            }
            if (opt2.Checked == true)
            {
                str = str + "ปริญญาโท" + Environment.NewLine;
            }
            if (opt3.Checked == true)
            {
                str = str + "ปริญญาเอก" + Environment.NewLine;
            }
            str = str + "1.ระยะห่างของรถไฟฟ้าที่วิ่งในแต่ละคัน:" + Environment.NewLine;
            if (apt1.Checked == true)
            {
                str = str + "ห่างมากไป" + Environment.NewLine;
            }
            if (apt2.Checked == true)
            {
                str = str + "พอดี" + Environment.NewLine;
            }
            if (apt3.Checked == true)
            {
                str = str + "ห่างน้อยไป" + Environment.NewLine;

            }
            str = str + "2.จำนวนที่นั่งบนรถไฟฟ้าเพียงพอหรือไม่ :" + Environment.NewLine;
            if (bpt1.Checked == true)
            {
                str = str + "เพียงพอ" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "ไม่เพียงพอ" + Environment.NewLine;

            }
            str = str + "3.คุณใช้ระยะเวลาในรอรถไฟฟ้าในแต่ละคัน :" + Environment.NewLine;
            if (cpt1.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "ปานกลาง" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;

            }
            str = str + "4.คุณเคยยืนหรือไม่ขณะใช้บริการรถไฟฟ้า :" + Environment.NewLine;
            if (dpt1.Checked == true)
            {
                str = str + "บ่อยครั้ง" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "บางครั้งคราว" + Environment.NewLine;
            }
            if (dpt3.Checked == true)
            {
                str = str + "ไม่เคย" + Environment.NewLine;


            }
            str = str + "5.คุณรู้สึกอึดอัดเพราะคนแน่นเกินไปหรือไม่ :" + Environment.NewLine;
            if (fpt1.Checked == true)
            {
                str = str + "ประจำ" + Environment.NewLine;
            }
            if (fpt2.Checked == true)
            {
                str = str + "บางครั้ง" + Environment.NewLine;
            }
            if (fpt3.Checked == true)
            {
                str = str + "ไม่เคย" + Environment.NewLine;


            }
            MessageBox.Show(str, "ผลการตรวจสอบ");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

