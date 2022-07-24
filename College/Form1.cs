using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet12.Course' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.courseTableAdapter.Fill(this.dataSet12.Course);
            // TODO: Bu kod satırı 'dataSet12.Course' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.courseTableAdapter.Fill(this.dataSet12.Course);
            // TODO: Bu kod satırı 'dataSet12.Student' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentTableAdapter.Fill(this.dataSet12.Student);
            // TODO: Bu kod satırı 'dataSet12.Student' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentTableAdapter.Fill(this.dataSet12.Student);
            // TODO: Bu kod satırı 'dataSet11.University' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.universityTableAdapter.Fill(this.dataSet11.University);
            // TODO: Bu kod satırı 'dataSet11.University' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.universityTableAdapter.Fill(this.dataSet11.University);
            // TODO: Bu kod satırı 'dataSet1.Enroll' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
            // TODO: Bu kod satırı 'dataSet1.Course' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.courseTableAdapter.Fill(this.dataSet1.Course);
            // TODO: Bu kod satırı 'dataSet1.Department' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
            // TODO: Bu kod satırı 'dataSet1.Professor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.professorTableAdapter.Fill(this.dataSet1.Professor);
            // TODO: Bu kod satırı 'dataSet1.Student' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentTableAdapter.Fill(this.dataSet1.Student);
            // TODO: Bu kod satırı 'dataSet1.University' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.universityTableAdapter.Fill(this.dataSet1.University);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.universityTableAdapter.InsertQuery(textBox2.Text, textBox3.Text, textBox4.Text);
            this.universityTableAdapter.Fill(this.dataSet1.University);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int U_ID;
            int.TryParse(textBox1.Text, out U_ID);
            this.universityTableAdapter.UpdateQuery(textBox5.Text, textBox6.Text, textBox7.Text, U_ID);
            this.universityTableAdapter.Fill(this.dataSet1.University);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int U_ID;
            int.TryParse(textBox1.Text, out U_ID);
            this.universityTableAdapter.DeleteQuery(U_ID);
            this.universityTableAdapter.Fill(this.dataSet1.University);

            this.studentTableAdapter.UpdateQuery1(U_ID);
            this.studentTableAdapter.Fill(this.dataSet1.Student);

            this.professorTableAdapter.UpdateQuery2(U_ID);
            this.professorTableAdapter.Fill(this.dataSet1.Professor);

            this.departmentTableAdapter.UpdateQuery3(U_ID);
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int U_ID;
            int.TryParse(textBox1.Text, out U_ID);
            textBox5.Text = this.universityTableAdapter.ScalarQuery(U_ID);
            textBox6.Text = this.universityTableAdapter.ScalarQuery1(U_ID);
            textBox7.Text = this.universityTableAdapter.ScalarQuery2(U_ID);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int U_ID, S_Age;
            int.TryParse(textBox11.Text, out S_Age);
            int.TryParse(comboBox1.SelectedValue.ToString(), out U_ID);

            this.studentTableAdapter.InsertQuery(textBox9.Text, textBox10.Text,S_Age, U_ID);
            this.studentTableAdapter.Fill(this.dataSet1.Student);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int S_ID, U_ID, S_Age;
            int.TryParse(textBox14.Text, out S_Age);
            int.TryParse(textBox8.Text, out S_ID);
            int.TryParse(comboBox1.SelectedValue.ToString(), out U_ID);

            this.studentTableAdapter.UpdateQuery(textBox12.Text, textBox13.Text, S_Age, U_ID, S_ID);
            this.studentTableAdapter.Fill(this.dataSet1.Student);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int S_ID;
            int.TryParse(textBox8.Text, out S_ID);
            this.studentTableAdapter.DeleteQuery(S_ID);
            this.studentTableAdapter.Fill(this.dataSet1.Student);

            this.enrollTableAdapter.UpdateQuery_Student_Delete(S_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int S_ID;
            int.TryParse(textBox8.Text, out S_ID);
            textBox12.Text = this.studentTableAdapter.ScalarQuery(S_ID);
            textBox13.Text = this.studentTableAdapter.ScalarQuery1(S_ID);
            textBox14.Text = this.studentTableAdapter.ScalarQuery2(S_ID).ToString(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int P_ID;
            int.TryParse(comboBox2.SelectedValue.ToString(), out P_ID);

            this.professorTableAdapter.InsertQuery(textBox16.Text, textBox17.Text, textBox18.Text, P_ID);
            this.professorTableAdapter.Fill(this.dataSet1.Professor);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int P_ID, U_ID;
            int.TryParse(textBox15.Text, out P_ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out U_ID);

            this.professorTableAdapter.UpdateQuery(textBox19.Text, textBox20.Text, textBox21.Text, U_ID, P_ID);
            this.professorTableAdapter.Fill(this.dataSet1.Professor);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int P_ID;
            int.TryParse(textBox15.Text, out P_ID);
            this.professorTableAdapter.DeleteQuery(P_ID);
            this.professorTableAdapter.Fill(this.dataSet1.Professor);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int P_ID;
            int.TryParse(textBox15.Text, out P_ID);
            textBox19.Text = this.professorTableAdapter.ScalarQuery(P_ID);
            textBox20.Text = this.professorTableAdapter.ScalarQuery1(P_ID);
            textBox21.Text = this.professorTableAdapter.ScalarQuery2(P_ID);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int D_ID, D_Code;
            int.TryParse(textBox24.Text, out D_Code);
            int.TryParse(comboBox3.SelectedValue.ToString(), out D_ID);

            this.departmentTableAdapter.InsertQuery(textBox23.Text, D_Code, D_ID);
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int D_ID, U_ID, D_Code;
            int.TryParse(textBox22.Text, out D_ID);
            int.TryParse(textBox26.Text, out D_Code);
            int.TryParse(comboBox3.SelectedValue.ToString(), out U_ID);

            this.departmentTableAdapter.UpdateQuery(textBox25.Text, D_Code, U_ID, D_ID);
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int D_ID;
            int.TryParse(textBox22.Text, out D_ID);
            this.departmentTableAdapter.DeleteQuery(D_ID);
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int D_ID;
            int.TryParse(textBox22.Text, out D_ID);
            textBox25.Text = this.departmentTableAdapter.ScalarQuery(D_ID);
            textBox26.Text = this.departmentTableAdapter.ScalarQuery1(D_ID).ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int C_Credit;
            int.TryParse(textBox30.Text, out C_Credit);
            this.courseTableAdapter.InsertQuery(textBox28.Text, textBox29.Text, C_Credit);
            this.courseTableAdapter.Fill(this.dataSet1.Course);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int C_ID, C_Course;
            int.TryParse(textBox33.Text, out C_Course);
            int.TryParse(textBox27.Text, out C_ID);
            this.courseTableAdapter.UpdateQuery(textBox31.Text, textBox32.Text, C_Course, C_ID);
            this.courseTableAdapter.Fill(this.dataSet1.Course);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(textBox27.Text, out C_ID);
            this.courseTableAdapter.DeleteQuery(C_ID);
            this.courseTableAdapter.Fill(this.dataSet1.Course);


            this.enrollTableAdapter.UpdateQuery_Course_Delete(C_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(textBox27.Text, out C_ID);
            textBox31.Text = this.courseTableAdapter.ScalarQuery(C_ID);
            textBox32.Text = this.courseTableAdapter.ScalarQuery1(C_ID);
            textBox33.Text = this.courseTableAdapter.ScalarQuery1(C_ID).ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            int S_ID, C_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out S_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out C_ID);
            this.enrollTableAdapter.InsertQuery(S_ID, C_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int Enroll_ID, S_ID, C_ID;
            int.TryParse(textBox34.Text, out Enroll_ID);
            int.TryParse(textBox35.Text, out S_ID);
            int.TryParse(textBox36.Text, out C_ID);
            this.enrollTableAdapter.UpdateQuery(S_ID, C_ID, Enroll_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int Enroll_ID;
            int.TryParse(textBox34.Text, out Enroll_ID);
            this.enrollTableAdapter.DeleteQuery(Enroll_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int Enroll_ID;
            int.TryParse(textBox34.Text, out Enroll_ID);
            textBox35.Text = this.enrollTableAdapter.ScalarQuery(Enroll_ID).ToString();
            textBox36.Text = this.enrollTableAdapter.ScalarQuery1(Enroll_ID).ToString();
        }
    }
}
