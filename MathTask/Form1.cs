// Project Created by Andriy Bakshalov
// 2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTask
{
    public partial class MATH : Form
    {
        Random rd = new Random();
        int timeleft=100;
      
        public MATH()
        {           
            InitializeComponent();
            timeLabel.Text = timeleft.ToString();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Generate random values for the quiz.
        private void generate_quiz()
        {
            addLeft.Text = rd.Next(40).ToString();
            addRight.Text = rd.Next(40).ToString();

            int sub_rd = rd.Next(1, 100);
            subLeft.Text = sub_rd.ToString();
            subRight.Text = rd.Next(sub_rd).ToString();

            mulLeft.Text = rd.Next(10).ToString();
            mulRight.Text = rd.Next(10).ToString();

            int leftdiv = rd.Next(10,80);
            divLeft.Text = leftdiv.ToString();
            divRight.Text = rd.Next(1,leftdiv/2).ToString();
        }
        //check the result entered by the user and return True or False.
        private bool check_quiz()
        {
            int sum = Int32.Parse(addLeft.Text) + Int32.Parse(addRight.Text);
            int sub = Int32.Parse(subLeft.Text) - Int32.Parse(subRight.Text);
            int mul = Int32.Parse(mulLeft.Text) * Int32.Parse(mulRight.Text);
            int div = Int32.Parse(divLeft.Text) / Int32.Parse(divRight.Text);

            if (sum == addRes.Value) { addState.Text = "OK"; addState.BackColor = Color.Green; }
            else { addState.Text = "BAD"; addState.BackColor = Color.Red; }
            if (sub == subRes.Value) { subState.Text = "OK"; subState.BackColor = Color.Green; }
            else { subState.Text = "BAD"; subState.BackColor = Color.Red; }
            if (mul == mulRes.Value) { mulState.Text = "OK"; mulState.BackColor = Color.Green; }
            else { mulState.Text = "BAD"; mulState.BackColor = Color.Red; }
            if (div == divRes.Value) { divState.Text = "OK"; divState.BackColor = Color.Green; }
            else { divState.Text = "BAD"; divState.BackColor = Color.Red; }

            return sum == addRes.Value && sub == subRes.Value && mul == mulRes.Value && div == divRes.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate_quiz();
            start_button.Enabled = false;
            timeleft = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0 && !check_quiz() )
            {
                timeleft--;
                if (timeleft == 1) timeLabel.Text = timeleft.ToString() + " second";
                else timeLabel.Text = timeleft.ToString() + " seconds";
            }
            else if (check_quiz())
            {
                timer1.Stop();
                MessageBox.Show("GOOD JOB! CORRECT!");
           
                start_button.Enabled = true;
            }
            else if (timeleft == 0)
            {
                timer1.Stop();
                timeLabel.Text = "TIME OUT!";
                check_quiz();
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
