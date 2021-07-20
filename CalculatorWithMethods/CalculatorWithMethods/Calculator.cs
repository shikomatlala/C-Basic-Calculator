using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithMethods
{
    //My programming rules
    /// <summary>
    /// 1 Every object component should work with methods only.
    /// </summary>
    public partial class Calculator : Form
    {
        bool operatorClicked = false;
        char operatorUsed;
        string leftOperand = "0";
        string righOperand = "0";
        string finalAnswer = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            NumberClicked(btn0, lblEditCalculation);
        }

        private void PnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //lblEditCalculation.Text = 
            NumberClicked(btn1, lblEditCalculation);
        }

        //This method operands that are clicked 
        private void NumberClicked(Button tbnNumber, Label lblCE)
        {
            lblCE.Text += tbnNumber.Text;
            if (!operatorClicked)
                leftOperand += tbnNumber.Text;
            else
                righOperand += tbnNumber.Text;

           /// LeftOperand()
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            NumberClicked(btn2, lblEditCalculation);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            NumberClicked(btn3, lblEditCalculation);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            NumberClicked(btn4, lblEditCalculation);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            NumberClicked(btn5, lblEditCalculation);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            NumberClicked(btn6, lblEditCalculation);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            NumberClicked(btn7, lblEditCalculation);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            NumberClicked(btn8, lblEditCalculation);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            NumberClicked(btn9, lblEditCalculation);
        }

        private void BtnDevision_Click(object sender, EventArgs e)
        {
            
            OperatorInExpression(btnDevision, lblEditCalculation);
            operatorClicked = true;

        }
        // answer = y + x //This is an expression.
        //Moving forward we are going to create an expression class and we will use this object to create mathematical expressions.
        //This methods defines chooses the operator to use in an expression
        //This functions holds the operator that is to be used in the expression
        private void OperatorInExpression(Button btnOperator, Label lblDisplay)
        {
            //Check if lblDisplay contains an operator
            if(!operatorClicked)
            {
                lblDisplay.Text += btnOperator.Text;
                operatorUsed = Convert.ToChar(btnOperator.Text);
                //Convert.ToChar()
            }


        }
        //This functions returns the operator in the expression


        //This function returns the left operand in the exrpession
        /// <summary>
        /// Returns the left value of the left operand
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        private int LeftOperand(int y)
        {
            return y;
        }
        private double LeftOperand(double y)
        {
            return y;
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            
            OperatorInExpression(btnMultiplication, lblEditCalculation);
            operatorClicked = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            OperatorInExpression(btnAdd, lblEditCalculation);
            operatorClicked = true;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            
            OperatorInExpression(btnSubtract, lblEditCalculation);
            operatorClicked = true;

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearExpression();
            operatorClicked = false;

        }

        //This function clears the expression on the screen
        private void ClearExpression()
        {
            lblEditCalculation.Text = "";
            operatorUsed = ' ';
            leftOperand = "0";
            righOperand = "0";
        }

        private void BtnClearEdit_Click(object sender, EventArgs e)
        {
            operatorClicked = false;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            //lblEditCalculation


            AnswerCalculation.Text = Convert.ToDouble(leftOperand) + " " + operatorUsed + " " + Convert.ToDouble(righOperand) + " = " + FinalAnswer(leftOperand, righOperand, operatorUsed);
            //ClearExpression();

        }
        private string FinalAnswer( string leftOperand, string rightOperand, char operation)
        {
            double x = Convert.ToDouble(leftOperand);//Ensure that the operands are not empty
            double y = Convert.ToDouble(rightOperand);
            double answer = 0;
            //double answer = 0;
            //string answer = "0";

            switch(operation)
            {
                case '+': answer =  x + y;
                    break;
                case '-': answer =  x - y;
                    break;
                case '/':
                    if (y == 0)
                    {
                        return "Invalid";
                    }
                    else
                        answer = x / y;
                    break;
                case '*': answer =  x * y;
                    break;
            }
           
            return answer.ToString();

        }
    }
}
