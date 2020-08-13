using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCusipTestor
{
    public partial class Form1 : Form
    {
        public static string validChars = ("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ*@#");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuNum = "";

            cuNum += tbFirstSix.Text + tbNextTwo.Text + tbSum.Text;
            cuNum = cuNum.ToUpper();
            lblCusip.Text = tbFirstSix.Text + "-" + tbNextTwo.Text + "-" + tbSum.Text;
            lblText.Text = "The givin test number is " + tbSum.Text;

            if (validate.isValid(cuNum))
            {
                lblCusip.Text += " is a valid CUSIP.";
                lblCusip.ForeColor = Color.Green;
                //lblCusip.Font.Bold = true;
            }
            else
            {
                lblCusip.Text += " is a not valid CUSIP.";
                lblCusip.ForeColor = Color.Red;
                //myCusip.Text += " is not a valid CUSIP.";
            }
            lblText.Text += " then the calculated number is " + validate.testNumber.ToString();
            /*** for testing ***/
            lblCharNums.Text = validate.charVal[0].ToString();
            for(int tx = 1; tx <= 8; tx++)
            {
                lblCharNums.Text += " - " + validate.charVal[tx].ToString() + " - ";
            }
            /********************/
        }
    

        public static int doPos(string cuChars)
        {
            int strPos = -1;

            do
            {
                strPos++;
            } while (cuChars != validChars.Substring(strPos, 1) && (strPos < validChars.Length -1));

            return strPos;
        }

    }

    public static class validate
    {
        public static int testNumber;
        public static int[] charVal = new int[9];
        public static bool isValid(string cusipNum)
        {
            int[] multiplier = new int[8];
            multiplier[0] = 1;
            multiplier[1] = 2;
            multiplier[2] = 1;
            multiplier[3] = 2;
            multiplier[4] = 1;
            multiplier[5] = 2;
            multiplier[6] = 1;
            multiplier[7] = 2;
            
            int checkSum = 0;
            //int quo, rem;

            if (cusipNum == "36200*AA0" || cusipNum == "31340*AA2" || cusipNum == "31358*AA1")
                return false; //specific invalid cusips
            else
            {
                if (cusipNum.Length == 9) //do the work here...
                {
                    for (int x = 0; x < 9; x++)
                    {
                        charVal[x] = Form1.doPos(cusipNum.Substring(x, 1));
                        if (charVal[x] > Form1.validChars.Length) { return false; }
                    }
                    Divc dv = new Divc(); //To use my C# replacement for the C struct div_t in <stdlib.h>
                    Divc a = new Divc();
                    Divc b = new Divc();

                    for (int y = 0; y < 8; y++)
                    {
                        dv.myDiv(charVal[y] * multiplier[y], 10);
                        checkSum += dv.quot + dv.rem;
                    }
                    a.myDiv(checkSum, 10);
                    b.myDiv(a.rem, 10);
                    checkSum = 10 - b.rem;
                    if (checkSum == 10) { checkSum = 0; }
                    /*******FOR TESTING*******/
                    testNumber = checkSum;
                    if (checkSum == charVal[8])
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }

    }


    public class Divc  // My C# replacement for the C struct div_t in <stdlib.h>
    {
        public int quot, rem;

        public void myDiv(int num, int divisor)
        {
            quot = num / divisor;
            rem = num % divisor;
        }
    }

}
