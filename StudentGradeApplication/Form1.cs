using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class StudentGradeApplication : Form
    {
        private readonly object multilineTextBox;
        //String ric = "ricson";

        public StudentGradeApplication()
        {
            InitializeComponent();
            
        }
        //String ric = "ricson";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            
            Font font = new Font("Microsoft Tai Le", 12f);
            Font font2 = new Font("Vecoly", 10f);

            float English = float.Parse( tbx_english.Text);
            float Math = float.Parse(tbx_math.Text);
            float Science = float.Parse(tbx_science.Text);
            float Filipino = float.Parse(tbx_filipino.Text);
            float History = float.Parse(tbx_history.Text);

            float average = (English + Math + Science + Filipino + History) /5;
            Console.WriteLine(average.ToString("0.00"));

            


            if (average > 75.00){

                tbx_result.Visible = true;
                lbl_result.Visible = true;

                tbx_result.Text = "\n Conratulation " + Clipboard.GetText() + ", you passed! \n" +
                    "Your general average is " + average + ".";
                tbx_result.Font = font;

            }else if (average > 100){
                tbx_result.Visible = true;
                tbx_result.Text = "Something's wrong";
                tbx_result.Font = font;
                lbl_result.Visible = true;

            }else if (average < 75){
                tbx_result.Visible = true;
                tbx_result.Text = "\n Unfortunately " + Clipboard.GetText() + ", you did not passed. \n" +
                    "Your general average is only " + average + ".";
                tbx_result.Font = font;
                lbl_result.ForeColor = Color.Red;
                lbl_result.Visible = true;
            }




        }

        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_name.Text);
            
        }

        private void tbx_english_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_math_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_science_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
