using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int tcount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tic tac toe is abt 2 player playing game ");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            tcount = 0;
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            tcount++;
            b.Enabled = false;
            checkwinner();

        }
        private void checkwinner()
        {
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");
            }
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");

            }
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");
            }
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");
            }
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");
            }
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show(") wins");
            }
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");
            }
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
            {
                disable();
                if (!turn)
                    MessageBox.Show("X wins");
                else
                    MessageBox.Show("O wins");
            }
            else
            {
                if (tcount == 9)
                    MessageBox.Show("draw");

            }
        }
    private void disable()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
    }
}