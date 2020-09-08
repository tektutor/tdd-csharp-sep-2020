namespace TekTutor
{
    public class Addition : IMathOperation
    {
        public double evaluate(double firstInput, double secondInput)
        {
            return firstInput + secondInput;
        }
    }
}