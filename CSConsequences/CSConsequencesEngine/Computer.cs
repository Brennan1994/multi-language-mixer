namespace CSConsequencesEngine
{
    public class Computer
    {
        // reciving and returning primitives.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // recieving object input. return primitive type.
        public static int Add(ComplexInput input)
        {
            return input.A + input.B;
        }

        //recieve struct input. return primitive type.
        public static int Add(ComplexInputStruct input)
        {
            return input.A + input.B;
        }

        //recieve object, modify and return.
        public static ComplexInput AddAndSetSum(ComplexInput input)
        {
            input.Sum = input.A + input.B;
            return input;
        }

        //recieve struct, modify and return.
        public static ComplexInputStruct AddAndSetSum(ComplexInputStruct input)
        {
            input.Sum = input.A + input.B;
            return input;
        }
    }
}
