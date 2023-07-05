namespace Wyzwanie21.Tests
{
    public class Tests
    {
        [Test]
        public void ScoresOfEmployees()
        {
            // Arrange
            var employee_1 = new Employee("Radek");
            var employee_2 = new Employee("Dagara");
           
            employee_1.AddScore(5);
            employee_1.AddScore(6);
            employee_2.AddScore(8);
            employee_2.AddScore(-8);
            // Act
            var result_1 = employee_1.Result;
            var result_2 = employee_2.Result;
            // Assert
            Assert.AreEqual(11, result_1);
            Assert.AreEqual(0, result_2);
        }



    }
}