using System;

namespace methods_classes
{
    //Method One
    class Math
    {
        public int resultOne;
        public int resultTwo;
        public int resultThree;

        public Math(int userInput)
        {
            resultOne = userInput + 12;
            resultTwo = userInput * 7;
            resultThree = (userInput * 5) / 2;
        }

    }

    ////Method Two
    //class Math2
    //{
    //    public int resultTwo;

    //    public Math2(int userInput)
    //    {
    //        resultTwo = userInput * 8;
    //    }
    //}

    ////Method Three
    //class Math3
    //{
    //    public int resultThree;

    //    public Math3(int userInput)
    //    {
    //        resultThree = (userInput * 16) / 3;
    //    }
    //}
}
