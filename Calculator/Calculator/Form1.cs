using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        #region Constructor
            /// <summary>
            /// Default Constructor
            /// </summary>
             public Form1()
             {
                 InitializeComponent();
             }
        #endregion

        #region Clearing Method
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument </param>

        private void CEbutton_Click(object sender, EventArgs e)
        {
            // Clears the user input text box
            this.UserInputText.Clear();
        }
        /// <summary>
        /// Delete the first character in front of the cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DELbutton_Click(object sender, EventArgs e)
        {
            //Delete the value after the cursor 
            DeleteInputText();
            //Focus the user input text
            FocusInputText();
        }


        #endregion


        #region Private Helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        /// <summary>
        /// Inserts the text into the user input text
        /// </summary>
        /// <param name="v"></param>

        private void InsertTextValue(string v)
        {
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, v);

            //Restore the selectionstart
            this.UserInputText.SelectionStart = selectionStart + v.Length;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;

        }

        private void DeleteInputText()
        {
            //If we dont have anything to delete, return nothing
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Delete the characters to the right of the selection

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selectionstart
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }
        #endregion

        #region Numbers Methods
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("0");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("3");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("2");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("1");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("6");
            //Focuses on the userinput.
            FocusInputText();

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("5");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("4");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("9");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("8");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("7");
            //Focuses on the userinput.
            FocusInputText();
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue(".");
            //Focuses on the userinput.
            FocusInputText();
        }


        #endregion


        #region Operator Methods
       
        /// <summary>
        /// Calculates the expression given in the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
            //Calculates the equation
            CalculateEquation();
            //Focuses on the userinput.
            FocusInputText();
        }

        /// <summary>
        /// Adds the times character to the text at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultipleButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("*");
            //Focuses on the userinput.
            FocusInputText();
        }
        
        /// <summary>
        /// Adds the subtraction character to the text at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubButton_Click(object sender, EventArgs e)
            
        {
            //Inserts the value in the user input text
            InsertTextValue("-");
            //Focuses on the userinput.
            FocusInputText();
        }
       
        /// <summary>
        /// Adds the plus character to the text at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("+");
            //Focuses on the userinput.
            FocusInputText();
        }
        
        /// <summary>
        /// Adds the division character to the text at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentageButton_Click(object sender, EventArgs e)
        {
            //Inserts the value in the user input text
            InsertTextValue("/");
            //Focuses on the userinput.
            FocusInputText();
        }

        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void CalculateEquation()
        {
            
            this.CalculationResultText.Text = ParseOperation();
            //Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Parses the users equation and calculates the results. 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string ParseOperation()
        {
            eh:
            try
            {
                //Get the user input equation
                var input = this.UserInputText.Text;
                //Remove all uneccessary spacing
                input = input.Replace(" ", "");
                // Create a new top level operation
                var operation = new Operation();
                var leftSide= true;
                //Loop through each and every character of input
                //starting from the left working to right
                for (int i = 0; i < input.Length; i++)
                {
                    var myStringNumber = "0123456789.";
                    var myStringOperation = "+-/*";
                    //Check if the current character is a number
                    if (myStringNumber.Any(c=> input[i]==c))
                    {
                        if (leftSide)
                        {
                            operation.leftSise = AddNumberPart(operation.leftSise, input[i]);
                        }
                        else
                        {
                            operation.rightSise = AddNumberPart(operation.rightSise, input[i]);
                        }

                    }
                    //Check if its an operator (+-/*),if it is then we set the operator
                    else if (myStringOperation.Any(c=> input[i] == c))
                    {
                        //If we on the right side already, we now need to calculate our current operation
                        //and set the results to the left side of the next operation
                        if (!leftSide)
                        {
                            //Get the operator type
                            var operatorType = GetOperatorType(input[i]);
                            if (operation.rightSise.Length == 0)
                            {
                                //Check the operator is a minus(as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)

                                    throw new InvalidOperationException($"Operator (+/* or mor than one - ) specified without an right side number");
                                //If we got here, the operator type is a minus, and there is no left number currently, so add the number to the minus
                                operation.rightSise += input[i];

                            }
                            else
                            {
                                //Calculate previous equation and set to leftside
                                operation.leftSise = CalculateOperation(operation);

                                //set new operator
                                operation.OperationType = operatorType;
                                //clear the previous right number
                                operation.rightSise = String.Empty;
                            }
                        }
                        else
                        {
                            //Get the operator type
                            var operatorType = GetOperatorType(input[i]);

                            //Check if we actuallly have a left side number
                            if (operation.leftSise.Length==0)
                            {
                                //Check the operator is a minus(as they could be creating a negative number)
                                if (operatorType!= OperationType.Minus)
                                
                                    throw new InvalidOperationException ($"Operator (+/* or more than one - ) specified without an right number");
                                //If we got here, the operator type is a minus, and there is no left number currently, so add the number to the minus
                                operation.leftSise += input[i];
                                
                            }
                            else
                            {
                                //If we get here, we have a left number and now an operator, so we want to move to the right side

                                //Set the operation type
                                operation.OperationType = operatorType;

                                //Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }
                //If we are done parsing and there were no exceptions
                //Calculate the current operation

                return CalculateOperation(operation);
            }
            catch (Exception ex)
            {

                return $"Invalid equation. {ex.Message}";
                goto eh;
            }
        }

        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the results
        /// </summary>
        /// <param name="operation"> The operation to calculate</param>
        /// <exception cref="NotImplementedException"></exception>
        private string CalculateOperation(Operation operation)
        {
            //store the number values of the string representation
            double left = 0;
            double right= 0;
            //Check if we actually have a valid left side number
            if (string.IsNullOrEmpty(operation.leftSise) || !double.TryParse(operation.leftSise,out left))
            {
                throw new InvalidOperationException($"Left side of the operation was not a number {operation.leftSise}");
            }

            //Check if we actually have a valid right side number
            if (string.IsNullOrEmpty(operation.rightSise) || !double.TryParse(operation.rightSise, out right))
            {
                throw new InvalidOperationException($"Right side of the operation was not a number {operation.rightSise}");
            }

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException($"Failed to calculate the operation. {operation.leftSise} {operation.OperationType} {operation.rightSise} : {ex.Message}");
            }
         
        }

        /// <summary>
        /// Accepts a character and return the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private OperationType GetOperatorType(char character)
        {
            switch (character)
            {
                case '+':
                    //
                    return OperationType.Add;
                case '-':
                    //
                    return OperationType.Minus;
                case '/':
                    //
                    return OperationType.Divide;
                case '*':
                    //
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Invalid operator type: {character}");

               
            }
            


        }

        /// <summary>
        /// Attempts to add new character to the current number, checking for valid character as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">new character to append to the string</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // check if there is already a "." in the number
            if (newCharacter=='.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a '.' and another cannot be added");
            }
            return currentNumber + newCharacter;

           
            
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Clear();
        }
    }
}
