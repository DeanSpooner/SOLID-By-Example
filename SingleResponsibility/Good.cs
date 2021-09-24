using System;

namespace SingleResponsibility
{
    // A class should only have one reason to change.
    // If the description of a method includes the word 'And' then you could be breaking SRP.
    // Here we have refactored the calculate areas class to be inline with SRP.
    public class Area
    {
        public double SumAreas()
        {
            //...

            return 0;
        }
    }

    public class Output
    {
        public void OutputTxt()
        {
            Console.WriteLine("output");
        }

        public void OutputHtml()
        {
            Console.WriteLine("<p>output</p>");
        }
    }
}
