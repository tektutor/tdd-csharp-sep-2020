using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TekTutor
{
    public class RPNCalculator
    {
        private Stack<double> numberStack;
        private double firstNumber, secondNumber, result;

        public RPNCalculator()
        {
            numberStack = new Stack<double>();
            firstNumber = secondNumber = result = 0.0;
        }

        public double evaluate(string rpnMathExpression)
        {
            string[] rpnMathTokens = rpnMathExpression.Split(' ');
            IMathOperation mathOperation = null;

            foreach( string rpnToken in rpnMathTokens )
            {
                if ( isMathOperator( rpnToken) )
                {
                    extractInputs();
                    mathOperation = MathFactory.getObject(rpnToken);
                    result = mathOperation.evaluate(firstNumber, secondNumber);
                    numberStack.Push(result);
                }
                else
                {
                    numberStack.Push(Convert.ToDouble(rpnToken));
                }
            }

            return numberStack.Pop();
        }

        private bool isMathOperator(string rpnToken)
        {
            string mathOperators = "+-*/";
            return mathOperators.Contains(rpnToken);
        }

        private void extractInputs()
        {
            secondNumber = numberStack.Pop();
            firstNumber = numberStack.Pop();
        }
    }

}
