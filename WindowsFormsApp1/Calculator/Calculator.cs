using System;

namespace WindowsFormsApp1
{
    public class Calculator
    {
        //Used to remember the previous number for each calculation
        private double lastNumber;
        //Used to keep the current number for each calculation
        private double currentNumber;
        //Used to find the result of each calculation
        private double result;
        //Used to keep the latest operator to use
        private String lastOperator;
        //Used to keep if the current number has a decimal
        private bool dot;
        //Used to keep track if it is the first number after the dot function
        private bool firstDotNumber;


        /// <summary>
        /// Constructor for a simple Calculator
        /// </summary>
        public Calculator()
        {
            lastNumber = 0;
            currentNumber = 0;
            result = 0;
            dot = false;
            firstDotNumber = false;
        }

        /// <summary>
        /// Operation to determine the result of an operation
        /// </summary>
        /// <returns> Returns the result of each operation </returns>
        public double Operation()
        {
            switch (lastOperator)
            {
                case "+":
                    lastNumber = Add();
                    return lastNumber;
                case "-":
                    lastNumber = Subtract();
                    return lastNumber;
                case "x":
                    lastNumber = Multiply();
                    return lastNumber;
                case "÷":
                    lastNumber = Divide();
                    return lastNumber;
                default:
                    return lastNumber;
            }
        }

        /// <summary>
        /// Basic plus operation
        /// </summary>
        /// <returns> The result of addition</returns>
        public double Add()
        {
            result = lastNumber + currentNumber;
            return result;
        }
        /// <summary>
        /// Basic subtraction operation
        /// </summary>
        /// <returns> The reult of the subtraction </returns>
        public double Subtract()
        {
            result = lastNumber - currentNumber;
            return result;
        }
        /// <summary>
        /// Basic multiplication operation
        /// </summary>
        /// <returns> The result of the multiplication</returns>
        public double Multiply()
        {
            result = lastNumber * currentNumber;
            return result;
        }
        /// <summary>
        /// Basic division operation
        /// </summary>
        /// <returns> The result of the division</returns>
        public double Divide()
        {
            result = lastNumber / currentNumber;
            return result;
        }

        /// <summary>
        /// Clears the current values stored in each variable
        /// </summary>
        public void Clear()
        {
            lastNumber = 0;
            currentNumber = 0;
            result = 0;
            dot = false;
            firstDotNumber = false;
        }

        /// <summary>
        /// Negates the currentNumber variable
        /// </summary>
        public void Negate()
        {
            currentNumber = currentNumber * -1;
        }

        /// <summary>
        /// Multiplies the currentNumber by 0.01
        /// </summary>
        public void Percent()
        {
            if(currentNumber == 0)
            {
                lastNumber = lastNumber * 0.01;
            }
            else
            {
                currentNumber = currentNumber * 0.01;
            }
        }

        /// <summary>
        /// Shifts the current number in order to make room for another number to display correctly on the screen
        /// </summary>
        /// <param name="addingnumber"> Number used to ones'th place after the shift has happened </param>
        /// <returns> returns the new current number after the shift</returns>
        public double Shift(double addingnumber)
        {
            currentNumber = currentNumber * 10;
            currentNumber += addingnumber;
            return currentNumber;
        }

        #region Getters

        /// <summary>
        /// Basic getter for lastNumber variable
        /// </summary>
        /// <returns>lastNumber variable</returns>
        public double getLastNumber()
        {
            return lastNumber;
        }

        /// <summary>
        /// Basic getter for the currentNumber variable
        /// </summary>
        /// <returns> currentNumber variable</returns>
        public double getCurrentNumber()
        {
            return currentNumber;
        }

        /// <summary>
        /// Basic getter for the last operator used
        /// </summary>
        /// <returns> The last operator used</returns>
        public String getLastOperator()
        {
            return lastOperator;
        }


        public double getResult()
        {
            return result;
        }

        #endregion

        #region Setters

        /// <summary>
        /// Basic setter for the lastNumber variable
        /// </summary>
        /// <param name="newLeftNumber"> The new last?Number variable</param>
        public void setLastNumber(double newLeftNumber)
        {
            lastNumber = newLeftNumber;

        }

        /// <summary>
        /// Basic setter for the currentNumber variable
        /// </summary>
        /// <param name="newCurrentNumber"> The new currentNumber variable</param>
        public void setCurrentNumber(double newCurrentNumber)
        {
            currentNumber = newCurrentNumber;
        }

        /// <summary>
        /// Basic setter for the last operator used
        /// </summary>
        /// <param name="newLastOperator"> The new lastOperator used</param>
        public void setLastOperation(String newLastOperator)
        {
            lastOperator = newLastOperator;
        }

        #endregion


        /// <summary>
        /// Changes the boolean variable of dot to True
        /// </summary>
        public void changeDot()
        {
            dot = true;
        }

        /// <summary>
        /// Changes the boolean variable of dot to False
        /// </summary>
        public void negateDot()
        {
            dot = false;
        }

        /// <summary>
        /// Basic getter for the boolean variable of dot
        /// </summary>
        /// <returns> the boolean of dot</returns>
        public bool getDot()
        {
            return dot;
        }

        public bool getFirstDotNumber()
        {
            return firstDotNumber;
        }

        public void changeFirstDotNumber()
        {
            if(firstDotNumber == true)
            {
                firstDotNumber = false;
            }
            else
            {
                firstDotNumber = true;
            }
        }
    }
}

   


