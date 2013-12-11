using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minor
{
    public partial class Form1 : Form
    {
        ///Global Variables
        ///

        //Full Array
        int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5 };
        
        //Arrays are declared here
        int[] first;//front
        int[] second;//left
        int[] third;//right
        int[] fourth;//top
        int[] fifth;//bottom
        int[] sixth;//back

        //Random Number
        Random ran=new Random();

        int temp1, temp2, temp3; //temp variables
        bool check_Hide = true;
        int[] rotate = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        
        ///User-Defined Function
        ///

        //Function to initialise cube
        private void solve()
        {
            first = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //Red
            second = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }; //Blue
            third = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 }; //Green
            fourth = new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3 }; //Yellow
            fifth = new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4 }; //White
            sixth = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 }; //Orange
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Red;
            panel4.BackColor = Color.Red;
            panel5.BackColor = Color.Red;
            panel6.BackColor = Color.Red;
            panel7.BackColor = Color.Red;
            panel8.BackColor = Color.Red;
            panel9.BackColor = Color.Red;
            colorAll();
        }

        private void short_solve_1()
        {
            first = new int[] { 0, 0, 2, 3, 0, 0, 2, 4, 0 };
            second = new int[] { 1, 2, 1, 1, 1, 2, 1, 1, 0 };
            third = new int[] { 3, 3, 2, 4, 2, 2, 4, 1, 2 };
            fourth = new int[] { 3, 3, 3, 0, 3, 0, 3, 1, 0 };
            fifth = new int[] { 4, 2, 1, 4, 4, 3, 4, 4, 4 };
            sixth = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            show();
        }

        private void short_solve_2()
        {
            first = new int[] { 1, 0, 0, 0, 0, 0, 4, 0, 2 };
            second = new int[] { 1, 1, 3, 1, 1, 4, 1, 1, 0 };
            third = new int[] { 2, 2, 2, 1, 2, 2, 4, 2, 2 };
            fourth = new int[] { 3, 3, 3, 3, 3, 3, 0, 3, 3 };
            fifth = new int[] { 1, 2, 0, 4, 4, 4, 4, 4, 4 };
            sixth = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            show();
        }

        private void short_solve_3()
        {
            first = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            second = new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1 };
            third = new int[] { 2, 2, 2, 1, 2, 2, 2, 2, 2 };
            fourth = new int[] { 3, 3, 3, 3, 3, 3, 3, 4, 3 };
            fifth = new int[] { 4, 3, 4, 4, 4, 4, 4, 4, 4 };
            sixth = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            show();
        }

        //Function to color all faces of a cube
        private void colorAll()
        {
            color(first[0], panel28);
            color(first[1], panel26);
            color(first[2], panel24);
            color(first[3], panel27);
            color(first[4], panel25);
            color(first[5], panel23);
            color(first[6], panel22);
            color(first[7], panel21);
            color(first[8], panel20);
            color(second[0], panel55);
            color(second[1], panel53);
            color(second[2], panel51);
            color(second[3], panel54);
            color(second[4], panel52);
            color(second[5], panel50);
            color(second[6], panel49);
            color(second[7], panel48);
            color(second[8], panel47);
            color(third[0], panel64);
            color(third[1], panel62);
            color(third[2], panel60);
            color(third[3], panel63);
            color(third[4], panel61);
            color(third[5], panel59);
            color(third[6], panel58);
            color(third[7], panel57);
            color(third[8], panel56);
            color(fourth[0], panel11);
            color(fourth[1], panel12);
            color(fourth[2], panel13);
            color(fourth[3], panel16);
            color(fourth[4], panel15);
            color(fourth[5], panel14);
            color(fourth[6], panel19);
            color(fourth[7], panel18);
            color(fourth[8], panel17);
            color(fifth[0], panel37);
            color(fifth[1], panel35);
            color(fifth[2], panel33);
            color(fifth[3], panel36);
            color(fifth[4], panel34);
            color(fifth[5], panel32);
            color(fifth[6], panel31);
            color(fifth[7], panel30);
            color(fifth[8], panel29);
            color(sixth[0], panel38);
            color(sixth[1], panel39);
            color(sixth[2], panel40);
            color(sixth[3], panel41);
            color(sixth[4], panel43);
            color(sixth[5], panel45);
            color(sixth[6], panel42);
            color(sixth[7], panel44);
            color(sixth[8], panel46);
        }
        //Function to color cube to default value at any point of time
        private void color(int a, Panel p)
        {
            if (a == 0)
                p.BackColor = Color.Red;
            else if (a == 1)
                p.BackColor = Color.Blue;
            else if (a == 2)
                p.BackColor = Color.DarkGreen;
            else if (a == 3)
                p.BackColor = Color.Yellow;
            else if (a == 4)
                p.BackColor = Color.White;
            else
                p.BackColor = Color.DarkOrange;
        }

        //Function to display face of cube
        void show()
        {
            if (radioButton1.Checked)
                colorDefault(first);
            else if (radioButton2.Checked)
                colorDefault(second);
            else if (radioButton3.Checked)
                colorDefault(third);
            else if (radioButton4.Checked)
                colorDefault(fourth);
            else if (radioButton5.Checked)
                colorDefault(fifth);
            else
                colorDefault(sixth);
            colorAll();
        }

        //Function to randomize cube
        private void random()
        {
            for (int i = 0; i < 48; i++)
            {
                temp1 = ran.Next(i, 48);

                temp2 = arr[i];
                arr[i] = arr[temp1];
                arr[temp1] = temp2;
            }
        }

        //Function to rotate a face clockwise
        private void rotate_Clock(int[] f)
        {
            for (int i = 0; i < 9; i++)
                rotate[i] = f[i];
            f[0] = rotate[6];
            f[1] = rotate[3];
            f[2] = rotate[0];
            f[3] = rotate[7];
            f[5] = rotate[1];
            f[6] = rotate[8];
            f[7] = rotate[5];
            f[8] = rotate[2];
        }

        //Functionto color cube dynamically
        private void colorDefault(int[] a)
        {
            color(a[0], panel1);
            color(a[1], panel2);
            color(a[2], panel3);
            color(a[3], panel4);
            color(a[4], panel5);
            color(a[5], panel6);
            color(a[6], panel7);
            color(a[7], panel8);
            color(a[8], panel9);
        }

        //Function to rotate a face counter-clockwise
        private void rotate_CounterClock(int[] f)
        {
            for (int i = 0; i < 9; i++)
                rotate[i] = f[i];
            f[0] = rotate[2];
            f[1] = rotate[5];
            f[2] = rotate[8];
            f[3] = rotate[1];
            f[5] = rotate[7];
            f[6] = rotate[0];
            f[7] = rotate[3];
            f[8] = rotate[6];
        }

        ///Form Event Functions
        ///
        
        public Form1()
        {
            InitializeComponent();
        }

        //Function To Color Cube on loading
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 587;
            solve();
        }

        //Function to restore cube
        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            solve();
        }

        //Function to show all faces

        private void button3_Click(object sender, EventArgs e)
        {
            if (check_Hide)
            {
                this.Width = 971;
                button3.Text = "Hide All Faces";
            }
            else
            {
                this.Width = 587;
                button3.Text = "Show All Faces";
            }
            check_Hide = !check_Hide;
            show();
        }

        //Function to change face of cube to front
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            colorDefault(first);
        }

        //Function to change face of cube to left
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            colorDefault(second);
        }

        //Function to change face of cube to right
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            colorDefault(third);
        }

        //Function to change face of cube to top
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            colorDefault(fourth);
        }

        //Function to change face of cube to bottom
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            colorDefault(fifth);
        }

        //Function to change face of cube to back
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            colorDefault(sixth);
        }

        //Function to randomize cube
        private void button1_Click(object sender, EventArgs e)
        {
            shuffle();
            show();
        }

        #region rotations

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = fourth[6];
                temp2 = fourth[7];
                temp3 = fourth[8];
                fourth[6] = second[8];
                fourth[7] = second[5];
                fourth[8] = second[2];
                second[2] = fifth[0];
                second[5] = fifth[1];
                second[8] = fifth[2];
                fifth[0] = third[6];
                fifth[1] = third[3];
                fifth[2] = third[0];
                third[0] = temp1;
                third[3] = temp2;
                third[6] = temp3;
                rotate_Clock(first);
            }

            else if (radioButton2.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
            }

            else if (radioButton3.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third);
            }

            else if (radioButton4.Checked)
            {
                temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
            }

            else if (radioButton5.Checked)
            {
                temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
            }

            else
            {
                temp1 = fourth[0];
                temp2 = fourth[1];
                temp3 = fourth[2];
                fourth[0] = third[2];
                fourth[1] = third[5];
                fourth[2] = third[8];
                third[2] = fifth[8];
                third[5] = fifth[7];
                third[8] = fifth[6];
                fifth[6] = second[0];
                fifth[7] = second[3];
                fifth[8] = second[6];
                second[0] = temp3;
                second[3] = temp2;
                second[6] = temp1;
                rotate_Clock(sixth);
            }
            show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = third[0];
                temp2 = third[3];
                temp3 = third[6];
                third[0] = fifth[2];
                third[3] = fifth[1];
                third[6] = fifth[0];
                fifth[0] = second[2];
                fifth[1] = second[5];
                fifth[2] = second[8];
                second[2] = fourth[8];
                second[5] = fourth[7];
                second[8] = fourth[6];
                fourth[6] = temp1;
                fourth[7] = temp2;
                fourth[8] = temp3;
                rotate_CounterClock(first);
            }

            else if (radioButton2.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fifth[0];
                first[3] = fifth[3];
                first[6] = fifth[6];
                fifth[0] = sixth[8];
                fifth[3] = sixth[5];
                fifth[6] = sixth[2];
                sixth[2] = fourth[6];
                sixth[5] = fourth[3];
                sixth[8] = fourth[0];
                fourth[0] = temp1;
                fourth[3] = temp2;
                fourth[6] = temp3;
                rotate_CounterClock(second);
            }

            else if (radioButton3.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fourth[2];
                first[5] = fourth[5];
                first[8] = fourth[8];
                fourth[2] = sixth[6];
                fourth[5] = sixth[3];
                fourth[8] = sixth[0];
                sixth[0] = fifth[8];
                sixth[3] = fifth[5];
                sixth[6] = fifth[2];
                fifth[2] = temp1;
                fifth[5] = temp2;
                fifth[8] = temp3;
                rotate_CounterClock(third);
            }

            else if (radioButton4.Checked)
            {
                temp1 = second[0];
                temp2 = second[1];
                temp3 = second[2];
                second[0] = sixth[0];
                second[1] = sixth[1];
                second[2] = sixth[2];
                sixth[0] = third[0];
                sixth[1] = third[1];
                sixth[2] = third[2];
                third[0] = first[0];
                third[1] = first[1];
                third[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_CounterClock(fourth);
            }

            else if (radioButton5.Checked)
            {
                temp1 = third[6];
                temp2 = third[7];
                temp3 = third[8];
                third[6] = sixth[6];
                third[7] = sixth[7];
                third[8] = sixth[8];
                sixth[6] = second[6];
                sixth[7] = second[7];
                sixth[8] = second[8];
                second[6] = first[6];
                second[7] = first[7];
                second[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_CounterClock(fifth);
            }

            else
            {
                temp1 = fourth[0];
                temp2 = fourth[1];
                temp3 = fourth[2];
                fourth[0] = second[6];
                fourth[1] = second[3];
                fourth[2] = second[0];
                second[0] = fifth[6];
                second[3] = fifth[7];
                second[6] = fifth[8];
                fifth[6] = third[8];
                fifth[7] = third[5];
                fifth[8] = third[2];
                third[2] = temp1;
                third[5] = temp2;
                third[8] = temp3;
                rotate_CounterClock(sixth);
            }
            show();
        }

        #endregion

        #region RIGHT_BUTTONS

        //Function called when right top is clicked
        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = second[0];
                temp2 = second[1];
                temp3 = second[2];
                second[0] = sixth[0];
                second[1] = sixth[1];
                second[2] = sixth[2];
                sixth[0] = third[0];
                sixth[1] = third[1];
                sixth[2] = third[2];
                third[0] = first[0];
                third[1] = first[1];
                third[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_CounterClock(fourth);
            }
            else if (radioButton2.Checked)
            {
                temp1 = second[0];
                temp2 = second[1];
                temp3 = second[2];
                second[0] = sixth[0];
                second[1] = sixth[1];
                second[2] = sixth[2];
                sixth[0] = third[0];
                sixth[1] = third[1];
                sixth[2] = third[2];
                third[0] = first[0];
                third[1] = first[1];
                third[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_CounterClock(fourth);
            }
            else if (radioButton3.Checked)
            {
                temp1 = second[0];
                temp2 = second[1];
                temp3 = second[2];
                second[0] = sixth[0];
                second[1] = sixth[1];
                second[2] = sixth[2];
                sixth[0] = third[0];
                sixth[1] = third[1];
                sixth[2] = third[2];
                third[0] = first[0];
                third[1] = first[1];
                third[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_CounterClock(fourth);
            }
            else if (radioButton4.Checked)
            {
                temp1 = fourth[0];
                temp2 = fourth[1];
                temp3 = fourth[2];
                fourth[0] = second[6];
                fourth[1] = second[3];
                fourth[2] = second[0];
                second[0] = fifth[6];
                second[3] = fifth[7];
                second[6] = fifth[8];
                fifth[6] = third[8];
                fifth[7] = third[5];
                fifth[8] = third[2];
                third[2] = temp1;
                third[5] = temp2;
                third[8] = temp3;
                rotate_CounterClock(sixth);
            }
            else if (radioButton5.Checked)
            {
                temp1 = fifth[0];
                temp2 = fifth[1];
                temp3 = fifth[2];
                fifth[0] = second[2];
                fifth[1] = second[5];
                fifth[2] = second[8];
                second[2] = fourth[8];
                second[5] = fourth[7];
                second[8] = fourth[6];
                fourth[6] = third[0];
                fourth[7] = third[3];
                fourth[8] = third[6];
                third[0] = temp3;
                third[3] = temp2;
                third[6] = temp1;
                rotate_CounterClock(first);
            }
            else
            {
                temp1 = second[0];
                temp2 = second[1];
                temp3 = second[2];
                second[0] = sixth[0];
                second[1] = sixth[1];
                second[2] = sixth[2];
                sixth[0] = third[0];
                sixth[1] = third[1];
                sixth[2] = third[2];
                third[0] = first[0];
                third[1] = first[1];
                third[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_CounterClock(fourth);
            }
            show();
        }

        //Function called when right bottom is clicked
        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
            }
            else if (radioButton2.Checked)
            {
                temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
            }
            else if (radioButton3.Checked)
            {
                temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
            }
            else if (radioButton4.Checked)
            {
                temp1 = fourth[6];
                temp2 = fourth[7];
                temp3 = fourth[8];
                fourth[6] = second[8];
                fourth[7] = second[5];
                fourth[8] = second[2];
                second[2] = fifth[0];
                second[5] = fifth[1];
                second[8] = fifth[2];
                fifth[0] = third[6];
                fifth[1] = third[3];
                fifth[2] = third[0];
                third[0] = temp1;
                third[3] = temp2;
                third[6] = temp3;
                rotate_Clock(first);
            }
            else if (radioButton5.Checked)
            {
                temp1 = fifth[6];
                temp2 = fifth[7];
                temp3 = fifth[8];
                fifth[6] = second[0];
                fifth[7] = second[3];
                fifth[8] = second[6];
                second[0] = fourth[2];
                second[3] = fourth[1];
                second[6] = fourth[0];
                fourth[0] = third[2];
                fourth[1] = third[5];
                fourth[2] = third[8];
                third[2] = temp1;
                third[5] = temp2;
                third[8] = temp3;
                rotate_Clock(sixth);
            }
            else
            {
                temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
            }
            show();
        }

        #endregion

        #region LEFT_BUTTONS

        //Function called when left top is clicked
        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
            }
            else if (radioButton2.Checked)
            {
                temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
            }
            else if (radioButton3.Checked)
            {
                temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
            }
            else if (radioButton4.Checked)
            {
                temp1 = fourth[0];
                temp2 = fourth[1];
                temp3 = fourth[2];
                fourth[0] = third[2];
                fourth[1] = third[5];
                fourth[2] = third[8];
                third[2] = fifth[8];
                third[5] = fifth[7];
                third[8] = fifth[6];
                fifth[6] = second[0];
                fifth[7] = second[3];
                fifth[8] = second[6];
                second[0] = temp3;
                second[3] = temp2;
                second[6] = temp1;
                rotate_Clock(sixth);
            }
            else if (radioButton5.Checked)
            {
                temp1 = fifth[0];
                temp2 = fifth[1];
                temp3 = fifth[2];
                fifth[0] = third[0];
                fifth[1] = third[3];
                fifth[2] = third[6];
                third[0] = fourth[6];
                third[3] = fourth[7];
                third[6] = fourth[8];
                fourth[6] = second[8];
                fourth[7] = second[5];
                fourth[8] = second[2];
                second[2] = temp1;
                second[5] = temp2;
                second[8] = temp3;
                rotate_Clock(first);
            }
            else
            {
                temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
            }
            show();
        }

        //Function called when left bottom is clicked
        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = third[6];
                temp2 = third[7];
                temp3 = third[8];
                third[6] = sixth[6];
                third[7] = sixth[7];
                third[8] = sixth[8];
                sixth[6] = second[6];
                sixth[7] = second[7];
                sixth[8] = second[8];
                second[6] = first[6];
                second[7] = first[7];
                second[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_CounterClock(fifth);
            }
            else if (radioButton2.Checked)
            {
                temp1 = third[6];
                temp2 = third[7];
                temp3 = third[8];
                third[6] = sixth[6];
                third[7] = sixth[7];
                third[8] = sixth[8];
                sixth[6] = second[6];
                sixth[7] = second[7];
                sixth[8] = second[8];
                second[6] = first[6];
                second[7] = first[7];
                second[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_CounterClock(fifth);
            }
            else if (radioButton3.Checked)
            {
                temp1 = third[6];
                temp2 = third[7];
                temp3 = third[8];
                third[6] = sixth[6];
                third[7] = sixth[7];
                third[8] = sixth[8];
                sixth[6] = second[6];
                sixth[7] = second[7];
                sixth[8] = second[8];
                second[6] = first[6];
                second[7] = first[7];
                second[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_CounterClock(fifth);
            }
            else if (radioButton4.Checked)
            {
                temp1 = fourth[6];
                temp2 = fourth[7];
                temp3 = fourth[8];
                fourth[6] = third[0];
                fourth[7] = third[3];
                fourth[8] = third[6];
                third[0] = fifth[2];
                third[3] = fifth[1];
                third[6] = fifth[0];
                fifth[0] = second[2];
                fifth[1] = second[5];
                fifth[2] = second[8];
                second[8] = temp3;
                second[5] = temp2;
                second[2] = temp1;
                rotate_CounterClock(first);
            }
            else if (radioButton5.Checked)
            {
                temp1 = fifth[6];
                temp2 = fifth[7];
                temp3 = fifth[8];
                fifth[6] = third[8];
                fifth[7] = third[5];
                fifth[8] = third[2];
                third[2] = fourth[0];
                third[5] = fourth[1];
                third[8] = fourth[2];
                fourth[0] = second[6];
                fourth[1] = second[3];
                fourth[2] = second[0];
                second[0] = temp1;
                second[3] = temp2;
                second[6] = temp3;
                rotate_CounterClock(sixth);
            }
            else
            {
                temp1 = third[6];
                temp2 = third[7];
                temp3 = third[8];
                third[6] = sixth[6];
                third[7] = sixth[7];
                third[8] = sixth[8];
                sixth[6] = second[6];
                sixth[7] = second[7];
                sixth[8] = second[8];
                second[6] = first[6];
                second[7] = first[7];
                second[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_CounterClock(fifth);
            }
            show();
        }

        #endregion

        #region TOP_BUTTONS

        //Function called when top left is clicked
        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fifth[0];
                first[3] = fifth[3];
                first[6] = fifth[6];
                fifth[0] = sixth[8];
                fifth[3] = sixth[5];
                fifth[6] = sixth[2];
                sixth[2] = fourth[6];
                sixth[5] = fourth[3];
                sixth[8] = fourth[0];
                fourth[0] = temp1;
                fourth[3] = temp2;
                fourth[6] = temp3;
                rotate_CounterClock(second);
            }
            else if (radioButton2.Checked)
            {
                temp1 = second[0];
                temp2 = second[3];
                temp3 = second[6];
                second[0] = fifth[6];
                second[3] = fifth[7];
                second[6] = fifth[8];
                fifth[6] = third[8];
                fifth[7] = third[5];
                fifth[8] = third[2];
                third[2] = fourth[0];
                third[5] = fourth[1];
                third[8] = fourth[2];
                fourth[0] = temp3;
                fourth[1] = temp2;
                fourth[2] = temp1;
                rotate_CounterClock(sixth);
            }
            else if (radioButton3.Checked)
            {
                temp1 = third[0];
                temp2 = third[3];
                temp3 = third[6];
                third[0] = fifth[2];
                third[3] = fifth[1];
                third[6] = fifth[0];
                fifth[0] = second[2];
                fifth[1] = second[5];
                fifth[2] = second[8];
                second[2] = fourth[8];
                second[5] = fourth[7];
                second[8] = fourth[6];
                fourth[6] = temp1;
                fourth[7] = temp2;
                fourth[8] = temp3;
                rotate_CounterClock(first);
            }
            else if (radioButton4.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fifth[0];
                first[3] = fifth[3];
                first[6] = fifth[6];
                fifth[0] = sixth[8];
                fifth[3] = sixth[5];
                fifth[6] = sixth[2];
                sixth[2] = fourth[6];
                sixth[5] = fourth[3];
                sixth[8] = fourth[0];
                fourth[0] = temp1;
                fourth[3] = temp2;
                fourth[6] = temp3;
                rotate_CounterClock(second);
            }
            else if (radioButton5.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fifth[0];
                first[3] = fifth[3];
                first[6] = fifth[6];
                fifth[0] = sixth[8];
                fifth[3] = sixth[5];
                fifth[6] = sixth[2];
                sixth[2] = fourth[6];
                sixth[5] = fourth[3];
                sixth[8] = fourth[0];
                fourth[0] = temp1;
                fourth[3] = temp2;
                fourth[6] = temp3;
                rotate_CounterClock(second);
            }
            else
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fourth[2];
                first[5] = fourth[5];
                first[8] = fourth[8];
                fourth[2] = sixth[6];
                fourth[5] = sixth[3];
                fourth[8] = sixth[0];
                sixth[0] = fifth[8];
                sixth[3] = fifth[5];
                sixth[6] = fifth[2];
                fifth[2] = temp1;
                fifth[5] = temp2;
                fifth[8] = temp3;
                rotate_CounterClock(third);
            }
            show();
        }

        //function called when top right is clicked
        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third);
            }
            else if (radioButton2.Checked)
            {
                temp1 = second[2];
                temp2 = second[5];
                temp3 = second[8];
                second[2] = fifth[0];
                second[5] = fifth[1];
                second[8] = fifth[2];
                fifth[0] = third[6];
                fifth[1] = third[3];
                fifth[2] = third[0];
                third[0] = fourth[6];
                third[3] = fourth[7];
                third[6] = fourth[8];
                fourth[6] = temp3;
                fourth[7] = temp2;
                fourth[8] = temp1;
                rotate_Clock(first);
            }
            else if (radioButton3.Checked)
            {
                temp1 = third[2];
                temp2 = third[5];
                temp3 = third[8];
                third[2] = fifth[8];
                third[5] = fifth[7];
                third[8] = fifth[6];
                fifth[6] = second[0];
                fifth[7] = second[3];
                fifth[8] = second[6];
                second[0] = fourth[2];
                second[3] = fourth[1];
                second[6] = fourth[0];
                fourth[0] = temp1;
                fourth[1] = temp2;
                fourth[2] = temp3;
                rotate_CounterClock(sixth);
            }
            else if (radioButton4.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third);
            }
            else if (radioButton5.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third);
            }
            else
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
            }
            show();
        }

        #endregion

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                short_solve_1();
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                short_solve_2();
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                short_solve_3();
        }


        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                solve();
        }
        #region BOTTOM_BUTTONS

        //function called when bottom left is clicked
        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
            }
            else if (radioButton2.Checked)
            {
                temp1 = second[0];
                temp2 = second[3];
                temp3 = second[6];
                second[0] = fourth[2];
                second[3] = fourth[1];
                second[6] = fourth[0];
                fourth[0] = third[2];
                fourth[1] = third[5];
                fourth[2] = third[8];
                third[2] = fifth[8];
                third[5] = fifth[7];
                third[8] = fifth[6];
                fifth[6] = temp1;
                fifth[7] = temp2;
                fifth[8] = temp3;
                rotate_Clock(sixth);
            }
            else if (radioButton3.Checked)
            {
                temp1 = second[2];
                temp2 = second[5];
                temp3 = second[8];
                second[2] = fifth[0];
                second[5] = fifth[1];
                second[8] = fifth[2];
                fifth[0] = third[6];
                fifth[1] = third[3];
                fifth[2] = third[0];
                third[0] = fourth[6];
                third[3] = fourth[7];
                third[6] = fourth[8];
                fourth[6] = temp3;
                fourth[7] = temp2;
                fourth[8] = temp1;
                rotate_Clock(first);
            }
            else if (radioButton4.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
            }
            else if (radioButton5.Checked)
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
            }
            else
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third);
            }
            show();
        }

        //function called when bottom right is clicked
        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fourth[2];
                first[5] = fourth[5];
                first[8] = fourth[8];
                fourth[2] = sixth[6];
                fourth[5] = sixth[3];
                fourth[8] = sixth[0];
                sixth[0] = fifth[8];
                sixth[3] = fifth[5];
                sixth[6] = fifth[2];
                fifth[2] = temp1;
                fifth[5] = temp2;
                fifth[8] = temp3;
                rotate_CounterClock(third);
            }
            else if (radioButton2.Checked)
            {
                temp1 = third[0];
                temp2 = third[3];
                temp3 = third[6];
                third[0] = fifth[2];
                third[3] = fifth[1];
                third[6] = fifth[0];
                fifth[0] = second[2];
                fifth[1] = second[5];
                fifth[2] = second[8];
                second[2] = fourth[8];
                second[5] = fourth[7];
                second[8] = fourth[6];
                fourth[6] = temp1;
                fourth[7] = temp2;
                fourth[8] = temp3;
                rotate_CounterClock(first);
            }
            else if (radioButton3.Checked)
            {
                temp1 = second[0];
                temp2 = second[3];
                temp3 = second[6];
                second[0] = fifth[6];
                second[3] = fifth[7];
                second[6] = fifth[8];
                fifth[6] = third[8];
                fifth[7] = third[5];
                fifth[8] = third[2];
                third[2] = fourth[0];
                third[5] = fourth[1];
                third[8] = fourth[2];
                fourth[0] = temp3;
                fourth[1] = temp2;
                fourth[2] = temp1;
                rotate_CounterClock(sixth);
            }
            else if (radioButton4.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fourth[2];
                first[5] = fourth[5];
                first[8] = fourth[8];
                fourth[2] = sixth[6];
                fourth[5] = sixth[3];
                fourth[8] = sixth[0];
                sixth[0] = fifth[8];
                sixth[3] = fifth[5];
                sixth[6] = fifth[2];
                fifth[2] = temp1;
                fifth[5] = temp2;
                fifth[8] = temp3;
                rotate_CounterClock(third);
            }
            else if (radioButton5.Checked)
            {
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fourth[2];
                first[5] = fourth[5];
                first[8] = fourth[8];
                fourth[2] = sixth[6];
                fourth[5] = sixth[3];
                fourth[8] = sixth[0];
                sixth[0] = fifth[8];
                sixth[3] = fifth[5];
                sixth[6] = fifth[2];
                fifth[2] = temp1;
                fifth[5] = temp2;
                fifth[8] = temp3;
                rotate_CounterClock(third);
            }
            else
            {
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fifth[0];
                first[3] = fifth[3];
                first[6] = fifth[6];
                fifth[0] = sixth[8];
                fifth[3] = sixth[5];
                fifth[6] = sixth[2];
                sixth[2] = fourth[6];
                sixth[5] = fourth[3];
                sixth[8] = fourth[0];
                fourth[0] = temp1;
                fourth[3] = temp2;
                fourth[6] = temp3;
                rotate_CounterClock(second);
            }
            show();
        }

        #endregion

        #region SHUFFLE_FUNCTIONS

        void shuffle()
        {
            int num;
            if(radioButton7.Checked)
            {
                solve();
                num = ran.Next(4);
                if (num == 0)
                    shuffle_1a();
                else if (num == 1)
                    shuffle_1b();
                else if (num == 2)
                    shuffle_1c();
                else
                    shuffle_1d();
            }
            else if(radioButton8.Checked)
            {
                solve();
                num = ran.Next(2);
                if (num == 0)
                    shuffle_2a();
                else
                    shuffle_2b();
            }

            else
            {
                num=ran.Next(3);
                if(num==0)
                {
                    shuffle_3a();
                }
                else if(num==1)
                {
                    shuffle_3b();
                }
                else
                {
                    shuffle_3c();
                }
            }

        }

        void shuffle_full()
        {
            random();
            first[4] = 0;
            second[4] = 1;
            third[4] = 2;
            fourth[4] = 3;
            fifth[4] = 4;
            sixth[4] = 5;
            for (int i = 0; i < 8; i++)
            {
                if (i < 4)
                    first[i] = arr[i];
                else
                    first[i + 1] = arr[i];
            }
            for (int i = 8; i < 16; i++)
            {
                if (i - 8 < 4)
                    second[i - 8] = arr[i];
                else
                    second[i - 8 + 1] = arr[i];
            }
            for (int i = 16; i < 24; i++)
            {
                if (i - 16 < 4)
                    third[i - 16] = arr[i];
                else
                    third[i - 16 + 1] = arr[i];
            }
            for (int i = 24; i < 32; i++)
            {
                if (i - 24 < 4)
                    fourth[i - 24] = arr[i];
                else
                    fourth[i - 24 + 1] = arr[i];
            }
            for (int i = 32; i < 40; i++)
            {
                if (i - 32 < 4)
                    fifth[i - 32] = arr[i];
                else
                    fifth[i - 32 + 1] = arr[i];
            }
            for (int i = 40; i < 48; i++)
            {
                if (i - 40 < 4)
                    sixth[i - 40] = arr[i];
                else
                    sixth[i - 40 + 1] = arr[i];
            }
            show(); 
        }

        //shuffle-3a;
       void shuffle_3a()
        { //R
           temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third); 
            //U
                
            temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
              //L  
            temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
            //D
                
            temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
                //R
                temp1 = first[2];
                temp2 = first[5];
                temp3 = first[8];
                first[2] = fifth[2];
                first[5] = fifth[5];
                first[8] = fifth[8];
                fifth[2] = sixth[6];
                fifth[5] = sixth[3];
                fifth[8] = sixth[0];
                sixth[0] = fourth[8];
                sixth[3] = fourth[5];
                sixth[6] = fourth[2];
                fourth[2] = temp1;
                fourth[5] = temp2;
                fourth[8] = temp3;
                rotate_Clock(third);
                //U

                temp1 = third[0];
                temp2 = third[1];
                temp3 = third[2];
                third[0] = sixth[0];
                third[1] = sixth[1];
                third[2] = sixth[2];
                sixth[0] = second[0];
                sixth[1] = second[1];
                sixth[2] = second[2];
                second[0] = first[0];
                second[1] = first[1];
                second[2] = first[2];
                first[0] = temp1;
                first[1] = temp2;
                first[2] = temp3;
                rotate_Clock(fourth);
                //L  
                temp1 = first[0];
                temp2 = first[3];
                temp3 = first[6];
                first[0] = fourth[0];
                first[3] = fourth[3];
                first[6] = fourth[6];
                fourth[0] = sixth[8];
                fourth[3] = sixth[5];
                fourth[6] = sixth[2];
                sixth[2] = fifth[6];
                sixth[5] = fifth[3];
                sixth[8] = fifth[0];
                fifth[0] = temp1;
                fifth[3] = temp2;
                fifth[6] = temp3;
                rotate_Clock(second);
                //D

                temp1 = second[6];
                temp2 = second[7];
                temp3 = second[8];
                second[6] = sixth[6];
                second[7] = sixth[7];
                second[8] = sixth[8];
                sixth[6] = third[6];
                sixth[7] = third[7];
                sixth[8] = third[8];
                third[6] = first[6];
                third[7] = first[7];
                third[8] = first[8];
                first[6] = temp1;
                first[7] = temp2;
                first[8] = temp3;
                rotate_Clock(fifth);
        }
        
        //shuffle-3b;
        void shuffle_3b()
        {
            //ULDRULDR

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);
            //L
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fourth[0];
            first[3] = fourth[3];
            first[6] = fourth[6];
            fourth[0] = sixth[8];
            fourth[3] = sixth[5];
            fourth[6] = sixth[2];
            sixth[2] = fifth[6];
            sixth[5] = fifth[3];
            sixth[8] = fifth[0];
            fifth[0] = temp1;
            fifth[3] = temp2;
            fifth[6] = temp3;
            rotate_Clock(second);
            //D

            temp1 = second[6];
            temp2 = second[7];
            temp3 = second[8];
            second[6] = sixth[6];
            second[7] = sixth[7];
            second[8] = sixth[8];
            sixth[6] = third[6];
            sixth[7] = third[7];
            sixth[8] = third[8];
            third[6] = first[6];
            third[7] = first[7];
            third[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_Clock(fifth);
            //R
            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
            //U

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);
            //L  
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fourth[0];
            first[3] = fourth[3];
            first[6] = fourth[6];
            fourth[0] = sixth[8];
            fourth[3] = sixth[5];
            fourth[6] = sixth[2];
            sixth[2] = fifth[6];
            sixth[5] = fifth[3];
            sixth[8] = fifth[0];
            fifth[0] = temp1;
            fifth[3] = temp2;
            fifth[6] = temp3;
            rotate_Clock(second);
            //D

            
            temp1 = second[6];
            temp2 = second[7];
            temp3 = second[8];
            second[6] = sixth[6];
            second[7] = sixth[7];
            second[8] = sixth[8];
            sixth[6] = third[6];
            sixth[7] = third[7];
            sixth[8] = third[8];
            third[6] = first[6];
            third[7] = first[7];
            third[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_Clock(fifth);

            //R

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
        }
        

        //shuffle-3c;
        void shuffle_3c()
        {
           
            //L  
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fourth[0];
            first[3] = fourth[3];
            first[6] = fourth[6];
            fourth[0] = sixth[8];
            fourth[3] = sixth[5];
            fourth[6] = sixth[2];
            sixth[2] = fifth[6];
            sixth[5] = fifth[3];
            sixth[8] = fifth[0];
            fifth[0] = temp1;
            fifth[3] = temp2;
            fifth[6] = temp3;
            rotate_Clock(second);
            //D

            temp1 = second[6];
            temp2 = second[7];
            temp3 = second[8];
            second[6] = sixth[6];
            second[7] = sixth[7];
            second[8] = sixth[8];
            sixth[6] = third[6];
            sixth[7] = third[7];
            sixth[8] = third[8];
            third[6] = first[6];
            third[7] = first[7];
            third[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_Clock(fifth);
            //R
            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
            //U

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);
            //L  
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fourth[0];
            first[3] = fourth[3];
            first[6] = fourth[6];
            fourth[0] = sixth[8];
            fourth[3] = sixth[5];
            fourth[6] = sixth[2];
            sixth[2] = fifth[6];
            sixth[5] = fifth[3];
            sixth[8] = fifth[0];
            fifth[0] = temp1;
            fifth[3] = temp2;
            fifth[6] = temp3;
            rotate_Clock(second);
            //D

            
            temp1 = second[6];
            temp2 = second[7];
            temp3 = second[8];
            second[6] = sixth[6];
            second[7] = sixth[7];
            second[8] = sixth[8];
            sixth[6] = third[6];
            sixth[7] = third[7];
            sixth[8] = third[8];
            third[6] = first[6];
            third[7] = first[7];
            third[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_Clock(fifth);

            //R

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
         
          //U

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);
      
        }

        //shuffle 2a
        void shuffle_2a()
        {
            //R

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);

            //L'
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fifth[0];
            first[3] = fifth[3];
            first[6] = fifth[6];
            fifth[0] = sixth[8];
            fifth[3] = sixth[5];
            fifth[6] = sixth[2];
            sixth[2] = fourth[6];
            sixth[5] = fourth[3];
            sixth[8] = fourth[0];
            fourth[0] = temp1;
            fourth[3] = temp2;
            fourth[6] = temp3;
            rotate_CounterClock(second);
           
            
            //U

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);

            //D
            temp1 = third[6];
            temp2 = third[7];
            temp3 = third[8];
            third[6] = sixth[6];
            third[7] = sixth[7];
            third[8] = sixth[8];
            sixth[6] = second[6];
            sixth[7] = second[7];
            sixth[8] = second[8];
            second[6] = first[6];
            second[7] = first[7];
            second[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_CounterClock(fifth);

            //taking blue as centre
            temp1 = second[0];
            temp2 = second[3];
            temp3 = second[6];
            second[0] = fourth[2];
            second[3] = fourth[1];
            second[6] = fourth[0];
            fourth[0] = third[2];
            fourth[1] = third[5];
            fourth[2] = third[8];
            third[2] = fifth[8];
            third[5] = fifth[7];
            third[8] = fifth[6];
            fifth[6] = temp1;
            fifth[7] = temp2;
            fifth[8] = temp3;
            rotate_Clock(sixth);

            //blue as 
            temp1 = third[0];
            temp2 = third[3];
            temp3 = third[6];
            third[0] = fifth[2];
            third[3] = fifth[1];
            third[6] = fifth[0];
            fifth[0] = second[2];
            fifth[1] = second[5];
            fifth[2] = second[8];
            second[2] = fourth[8];
            second[5] = fourth[7];
            second[8] = fourth[6];
            fourth[6] = temp1;
            fourth[7] = temp2;
            fourth[8] = temp3;
            rotate_CounterClock(first);

            //Top-left

            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fifth[0];
            first[3] = fifth[3];
            first[6] = fifth[6];
            fifth[0] = sixth[8];
            fifth[3] = sixth[5];
            fifth[6] = sixth[2];
            sixth[2] = fourth[6];
            sixth[5] = fourth[3];
            sixth[8] = fourth[0];
            fourth[0] = temp1;
            fourth[3] = temp2;
            fourth[6] = temp3;
            rotate_CounterClock(second);
            //top-right

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
            
            

        }

        //shuffle-2b
        void shuffle_2b()
        { 
        
           //L2
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fifth[0];
            first[3] = fifth[3];
            first[6] = fifth[6];
            fifth[0] = sixth[8];
            fifth[3] = sixth[5];
            fifth[6] = sixth[2];
            sixth[2] = fourth[6];
            sixth[5] = fourth[3];
            sixth[8] = fourth[0];
            fourth[0] = temp1;
            fourth[3] = temp2;
            fourth[6] = temp3;
            rotate_CounterClock(second);

            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fifth[0];
            first[3] = fifth[3];
            first[6] = fifth[6];
            fifth[0] = sixth[8];
            fifth[3] = sixth[5];
            fifth[6] = sixth[2];
            sixth[2] = fourth[6];
            sixth[5] = fourth[3];
            sixth[8] = fourth[0];
            fourth[0] = temp1;
            fourth[3] = temp2;
            fourth[6] = temp3;
            rotate_CounterClock(second);

            //R2

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);

            //U2

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);

            temp1 = third[0];
            temp2 = third[1];
            temp3 = third[2];
            third[0] = sixth[0];
            third[1] = sixth[1];
            third[2] = sixth[2];
            sixth[0] = second[0];
            sixth[1] = second[1];
            sixth[2] = second[2];
            second[0] = first[0];
            second[1] = first[1];
            second[2] = first[2];
            first[0] = temp1;
            first[1] = temp2;
            first[2] = temp3;
            rotate_Clock(fourth);

            //D2
            temp1 = third[6];
            temp2 = third[7];
            temp3 = third[8];
            third[6] = sixth[6];
            third[7] = sixth[7];
            third[8] = sixth[8];
            sixth[6] = second[6];
            sixth[7] = second[7];
            sixth[8] = second[8];
            second[6] = first[6];
            second[7] = first[7];
            second[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_CounterClock(fifth);

            temp1 = third[6];
            temp2 = third[7];
            temp3 = third[8];
            third[6] = sixth[6];
            third[7] = sixth[7];
            third[8] = sixth[8];
            sixth[6] = second[6];
            sixth[7] = second[7];
            sixth[8] = second[8];
            second[6] = first[6];
            second[7] = first[7];
            second[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_CounterClock(fifth);

            //R2-Blue

            temp1 = second[2];
            temp2 = second[5];
            temp3 = second[8];
            second[2] = fifth[0];
            second[5] = fifth[1];
            second[8] = fifth[2];
            fifth[0] = third[6];
            fifth[1] = third[3];
            fifth[2] = third[0];
            third[0] = fourth[6];
            third[3] = fourth[7];
            third[6] = fourth[8];
            fourth[6] = temp3;
            fourth[7] = temp2;
            fourth[8] = temp1;
            rotate_Clock(first);

            temp1 = second[2];
            temp2 = second[5];
            temp3 = second[8];
            second[2] = fifth[0];
            second[5] = fifth[1];
            second[8] = fifth[2];
            fifth[0] = third[6];
            fifth[1] = third[3];
            fifth[2] = third[0];
            third[0] = fourth[6];
            third[3] = fourth[7];
            third[6] = fourth[8];
            fourth[6] = temp3;
            fourth[7] = temp2;
            fourth[8] = temp1;
            rotate_Clock(first);

            //L2-Blue

            temp1 = second[0];
            temp2 = second[3];
            temp3 = second[6];
            second[0] = fifth[6];
            second[3] = fifth[7];
            second[6] = fifth[8];
            fifth[6] = third[8];
            fifth[7] = third[5];
            fifth[8] = third[2];
            third[2] = fourth[0];
            third[5] = fourth[1];
            third[8] = fourth[2];
            fourth[0] = temp3;
            fourth[1] = temp2;
            fourth[2] = temp1;
            rotate_CounterClock(sixth);

            temp1 = second[0];
            temp2 = second[3];
            temp3 = second[6];
            second[0] = fifth[6];
            second[3] = fifth[7];
            second[6] = fifth[8];
            fifth[6] = third[8];
            fifth[7] = third[5];
            fifth[8] = third[2];
            third[2] = fourth[0];
            third[5] = fourth[1];
            third[8] = fourth[2];
            fourth[0] = temp3;
            fourth[1] = temp2;
            fourth[2] = temp1;
            rotate_CounterClock(sixth);
        }

        //SHUFFLE   1a;
        void shuffle_1a()
        {
            temp1 = second[0];
            temp2 = second[3];
            temp3 = second[6];
            second[0] = fifth[6];
            second[3] = fifth[7];
            second[6] = fifth[8];
            fifth[6] = third[8];
            fifth[7] = third[5];
            fifth[8] = third[2];
            third[2] = fourth[0];
            third[5] = fourth[1];
            third[8] = fourth[2];
            fourth[0] = temp3;
            fourth[1] = temp2;
            fourth[2] = temp1;
            rotate_CounterClock(sixth);

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
        }

        //1b 
        void shuffle_1b()
        {
            temp1 = first[0];
            temp2 = first[3];
            temp3 = first[6];
            first[0] = fourth[0];
            first[3] = fourth[3];
            first[6] = fourth[6];
            fourth[0] = sixth[8];
            fourth[3] = sixth[5];
            fourth[6] = sixth[2];
            sixth[2] = fifth[6];
            sixth[5] = fifth[3];
            sixth[8] = fifth[0];
            fifth[0] = temp1;
            fifth[3] = temp2;
            fifth[6] = temp3;
            rotate_Clock(second);

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fourth[2];
            first[5] = fourth[5];
            first[8] = fourth[8];
            fourth[2] = sixth[6];
            fourth[5] = sixth[3];
            fourth[8] = sixth[0];
            sixth[0] = fifth[8];
            sixth[3] = fifth[5];
            sixth[6] = fifth[2];
            fifth[2] = temp1;
            fifth[5] = temp2;
            fifth[8] = temp3;
            rotate_CounterClock(third);

            temp1 = third[6];
            temp2 = third[7];
            temp3 = third[8];
            third[6] = sixth[6];
            third[7] = sixth[7];
            third[8] = sixth[8];
            sixth[6] = second[6];
            sixth[7] = second[7];
            sixth[8] = second[8];
            second[6] = first[6];
            second[7] = first[7];
            second[8] = first[8];
            first[6] = temp1;
            first[7] = temp2;
            first[8] = temp3;
            rotate_CounterClock(fifth);
        }

        //1c
        void shuffle_1c()
        {
            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);

            temp1 = second[2];
            temp2 = second[5];
            temp3 = second[8];
            second[2] = fifth[0];
            second[5] = fifth[1];
            second[8] = fifth[2];
            fifth[0] = third[6];
            fifth[1] = third[3];
            fifth[2] = third[0];
            third[0] = fourth[6];
            third[3] = fourth[7];
            third[6] = fourth[8];
            fourth[6] = temp3;
            fourth[7] = temp2;
            fourth[8] = temp1;
            rotate_Clock(first);
        }

        //1d
        void shuffle_1d()
        {

            temp1 = fourth[0];
            temp2 = fourth[1];
            temp3 = fourth[2];
            fourth[0] = third[2];
            fourth[1] = third[5];
            fourth[2] = third[8];
            third[2] = fifth[8];
            third[5] = fifth[7];
            third[8] = fifth[6];
            fifth[6] = second[0];
            fifth[7] = second[3];
            fifth[8] = second[6];
            second[0] = temp3;
            second[3] = temp2;
            second[6] = temp1;
            rotate_Clock(sixth);

            temp1 = first[2];
            temp2 = first[5];
            temp3 = first[8];
            first[2] = fifth[2];
            first[5] = fifth[5];
            first[8] = fifth[8];
            fifth[2] = sixth[6];
            fifth[5] = sixth[3];
            fifth[8] = sixth[0];
            sixth[0] = fourth[8];
            sixth[3] = fourth[5];
            sixth[6] = fourth[2];
            fourth[2] = temp1;
            fourth[5] = temp2;
            fourth[8] = temp3;
            rotate_Clock(third);
        }

        #endregion
    }
}