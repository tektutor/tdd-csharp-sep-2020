using System;
using System.Collections.Generic;
using System.Text;

namespace TekTutor
{
    public class MathFactory
    {

        public static IMathOperation getObject( string mathOperator )
        {
            IMathOperation mathOperation = null;

            if (mathOperator.Equals("+"))
                mathOperation = new Addition();
            else if (mathOperator.Equals("-"))
                mathOperation = new Subtraction();
            else if (mathOperator.Equals("*"))
                mathOperation = new Multiplication();
            else if (mathOperator.Equals("/"))
                mathOperation = new Division();

            return mathOperation;

        }

    }
}
