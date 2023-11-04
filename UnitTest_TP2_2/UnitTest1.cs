using TP2_2_JFB;

namespace UnitTest_TP2_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrenge
            Persona persona1 = new Persona("Mauricio Giudicce", 17, 46789123, 'H', 90, 171);
            Persona persona2 = new Persona("Rocio Tana", 21, 45123456, 'M', 80, 170);
            Persona persona3 = new Persona("Ignacio Rodriguez", 20, 45456789, 'N', 70, 175);
            Persona persona4 = new Persona("Edgar Gomez", 21, 45123456, 'X', 20, 120);

            //act
            bool mayordeedad1 = persona1.MayordeEdad();
            bool mayordeedad2 = persona2.MayordeEdad();
            bool mayordeedad3 = persona3.MayordeEdad();

            int pesoimc1 = persona1.IMC();
            int pesoimc4 = persona4.IMC();
            int pesoimc3 = persona3.IMC();

            char validarsexo1 = persona1.ValidarSexo();
            char validarsexo2 = persona2.ValidarSexo();
            char validarsexo3 = persona3.ValidarSexo();
            char validarsexo4 = persona4.ValidarSexo();

            //assert
            Assert.IsFalse(mayordeedad1);
            Assert.IsTrue(mayordeedad2);
            Assert.IsTrue(mayordeedad3);
            Assert.AreEqual(1, pesoimc1);
            Assert.AreEqual(-1, pesoimc4);
            Assert.AreEqual(0, pesoimc3);
            Assert.AreEqual('H', validarsexo1);
            Assert.AreEqual('M', validarsexo2);
            Assert.AreEqual('N', validarsexo3);
            Assert.AreEqual('H', validarsexo4);

        }
    }
}