using System;

namespace SingleResponsibility
{
    // The class belows breaks SRP by summing areas and providing an output.
    public class CalculateArea
    {
        public double SumAreas()
        {
            //...

            return 0;
        }

        public void Output()
        {
            Console.WriteLine("output");
        }
    }
}
