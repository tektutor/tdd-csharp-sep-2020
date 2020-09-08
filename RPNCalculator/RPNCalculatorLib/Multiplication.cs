namespace TekTutor
{
    public class Multiplication : IMathOperation
    {
        public double evaluate(double firstInput, double secondInput)
        {
            return firstInput * secondInput;
        }
    }
}