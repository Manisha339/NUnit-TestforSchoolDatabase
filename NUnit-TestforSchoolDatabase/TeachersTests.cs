using NUnit.Framework;
using NUnit_TestforSchoolDatabase;
using SchoolDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDatabase.Tests
{
    
    [TestFixture()]
    public class TeachersTests
    {
        private Teachers teachers;

        static List<TestCaseData> TestCases
        {
            get
            {
                return AddTestData.Get1();
            }
        }
        [SetUp]
        public void Setup()
        {
            teachers = new Teachers();
        }
        [Test()]
        [TestCaseSource("TestCases")]
        public String InsertTest(int TeacherID, String Name, String Grade)
        {
            return teachers.Insert(TeacherID, Name, Grade);
        }
}
}