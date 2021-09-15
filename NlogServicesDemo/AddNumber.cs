using System;
using System.Collections.Generic;
using System.Text;


namespace NlogServicesDemo
{
    public class AddNumber
    {
        Nlog nlog = new Nlog();
        public int Sum(int FirstNumber, int SecondNumber)
        {
            //Checking Value eqaul to zero
            if (FirstNumber == 0 || SecondNumber == 0)
            {
                nlog.LogDebug("Debug Unsuccessful : Sum()");
                nlog.LogError("Expecting null Values");
                nlog.LogWarn("FirstNumber and SecondNumber should not equal to zero");
            }
            int result = FirstNumber + SecondNumber;
            nlog.LogDebug("Debug Unsuccessful : Sum()");
            nlog.LogInfo("Sum Method Passed, Result : " + result);
            return result;
        }
    }
}