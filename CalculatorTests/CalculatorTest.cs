using net_calculator_tester;
namespace CalculatorTests
{
    public class Tests
    {
        public Calculator Calc { get; set; }
        public float Num1 { get; set; }
        public float Num2 { get; set; }
        public float Res { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Num1 = 5;
            Num2 = 10;
            Calc = new Calculator();
        
        }

        [SetUp]
        public void Setup()
        {
            Res = 0;
        }

        [Test]
        public void AddTest()
        {
           Res = Calc.Add(Num1, Num2);
            Assert.IsTrue(Res==(Num1+Num2));
        }

        [Test]
        public void SubstractTest()
        {
            Res = Calc.Subtract(Num1, Num2);
            Assert.IsTrue(Res == (Num1 - Num2));
        }

        [Test]
        public void DivideTest()
        {
            Res = Calc.Divide(Num1, Num2);
            Assert.IsTrue(Res == (Num1 / Num2));
        }

        [Test]
        public void Multiply()
        {
            Res = Calc.Multiply(Num1, Num2);
            Assert.IsTrue(Res == (Num1 * Num2));
        }
        [Test]
        public void Exponentiation()
        {
            int num1 = 2;
            int num2 = -4;
            double res = Calc.Exponentiation(num1, num2);
            Assert.IsTrue(res == (Math.Pow(num1,num2)));

        }
    }
}