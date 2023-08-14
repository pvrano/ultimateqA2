namespace UltimateQA
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            Employee obj = new Employee(01, "Priyanka", "Yadav");
            String fullName = obj.fullNameOfEmployee();
            String fullNameInRevere = obj.returnFormattableNameOfEmployee();
            StringAssert.AreEqualIgnoringCase("Priyanka Yadav", fullName);
            StringAssert.Contains(fullNameInRevere, "Yadav, Priyanka");
        }
    }
}