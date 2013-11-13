using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

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
            string str = "สถานภาพผู้ตอบแบบสอบถาม :" + Environment.NewLine;
           
           
            str = str + "1.ตำแหน่ง===" ;
            if (apt1.Checked == true)
            {
                str = str + "ผู้บริหารสถานศึกษา" + Environment.NewLine;
            }
            if (apt2.Checked == true)
            {
                str = str + "ครูการเงินโรงเรียน" + Environment.NewLine;
            

            }
            str = str + "2.ระดับการศึกษา ===" ;
            if (bpt1.Checked == true)
            {
                str = str + "ต่ำกว่าปริญญาตรี" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "ปริญญาตรี" + Environment.NewLine;
            }
            if (radioButton1.Checked == true)
            {
                str = str + "สูงกว่าปริญญาตรี" + Environment.NewLine;

            }
            str = str + "3.ประสบการณ์การทำงาน ===" ;
            if (cpt1.Checked == true)
            {
                str = str + "น้อยกว่า 10 ปี" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "10-20 ปี" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "มากกว่า 20 ปี" + Environment.NewLine;

            }
            str = str + "4.ปฏิบัติหน้าที่ขนาดโรงเรียน ===" ;
            if (dpt1.Checked == true)
            {
                str = str + "มีจำนวนนักเรียนน้อยกว่า 120 คน" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "มีจำนวนนักเรียน 120-300 คน" + Environment.NewLine;
            }
            if (dpt3.Checked == true)
            {
                str = str + "ขนาดใหญ่ มีจำนวนนักเรียนมากกว่า 300 คน" + Environment.NewLine;


            


            }
            Form2 frm = new Form2(str );
            frm.Show();
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

