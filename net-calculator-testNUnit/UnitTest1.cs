namespace net_calculator_testNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1.0f, 2.0f)]
        public void AddTest(float num1, float num2)
        {
            try
            {
                Calcolatrice calcolatrice = new Calcolatrice();
                float somma = num1 + num2;
                float result = Calcolatrice.Add(num1, num2);

                Assert.AreEqual(somma, result, $"La somma di {num1} e {num2} deve essere uguale a {somma}");
            }
            catch (Exception e)
            {
                Assert.Fail("Excepction: " + e.Message);
            }
        }


        [Test]
        // se si inserisce il n2 maggiore darà errore
        [TestCase(4.0f, 0.0f)]
        public void SubstractTest(float num1, float num2)
        {
            try
            {
                float differenza = num1 - num2;
                float result = Calcolatrice.Substract(num1, num2);

                Assert.GreaterOrEqual(result, 0, $"La differenza tra {num1} e {num2} deve essere positiva");
                Assert.AreEqual(differenza, result, $"La differenza di {num1} e {num2} deve essere uguale a {differenza}");
            }
            catch (Exception e)
            {
                Assert.Fail("Eccezione: " + e.Message);
            }
        }

        [Test]
        [TestCase(9.0f, 3.0f)]
        public void DivideTest(float num1, float num2)
        {
            try
            {

                float risultato = 6.0f;
                float divisione = Calcolatrice.Divide(num1, num2);

                //Assert.NotZero(num2, $"Impossibile dividere per zero.");
                Assert.AreEqual(risultato, divisione, $"Il risultato della divisione deve essere {risultato}");

            }
            catch (Exception e)
            {
                Assert.Fail("Eccezione: " + e.Message);
            }
        }


        [Test]
        [TestCase(3.0f, 4.0f)]
        [TestCase(0.0f, 5.0f)]
        [TestCase(5.0f, 1.0f)]
        public void MultiplyTest(float num1, float num2)
        {
            try
            {
                float moltiplicazione = num1 * num2;
                float risultato = Calcolatrice.Multiply(num1, num2);

                Assert.AreEqual(moltiplicazione, risultato, $"Il risultato della moltiplicazione di {num1} per {num2} deve essere uguale a {moltiplicazione}");
            }
            catch (Exception e)
            {
                Assert.Fail("Exception: " + e.Message);
            }
        }
    }
}