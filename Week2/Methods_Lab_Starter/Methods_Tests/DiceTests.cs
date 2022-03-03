using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {    


        //Did not finish got it from Ned
         [TestCase]
         public void GivenANumberTheValueIsCorrect()
         {
             Random answer =  new Random(92);//Random here
             Assert.That(answer, Is.EqualTo(Methods.RollDice(answer)));

         }

    }
}
