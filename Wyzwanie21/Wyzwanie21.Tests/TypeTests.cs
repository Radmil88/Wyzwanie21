namespace Wyzwanie21.Tests
{
    public class TypeTests
    {
        [Test]
        public void String()
        {
            // Arrange

            string name1 = "Radek";
            string name2 = "Ewelina";


            // Act

            // Assert
            Assert.AreNotSame(name1, name2);
        }

            [Test]
        public void Float()
        {
            // Arrange

            float number1 = number1 = 3.14f;
            float number2 = number2 = 3.14f;


            // Act

            // Assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void Int()
        {
            // Arrange

            int number1 = 1;
            int number2 = 2;


            // Act

            // Assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TypeReferent1()
        {
            // Arrange

            var employee1 = GetEmployee("Radek");
            var employee2 = GetEmployee("Radek");


            // Act

            // Assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        [Test]
        public void TypeReferent2()
        {
            // Arrange

            var employee1 = GetEmployee("Radek");
            var employee2 = GetEmployee("Radek");


            // Act

            // Assert
            Assert.AreNotEqual(employee1, employee2);
        }



        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

    }
}
