using NUnit.Framework;
using NUnit_TestforSchoolDatabase;
using SchoolDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDatabase.Tests
{
    [TestFixture()]
    public class StudentsTests
    {
        private Students students;
        static  List<TestCaseData> TestCases
        {
            get
            {
                return AddTestData.Get();
            }
            
        }

        [SetUp]
        public void Setup()
        {
            students = new Students();
        }
        [Test()]
        [TestCaseSource("TestCases")]
        public String InsertTest(int StudentID, String Name, String Grade)
        {
            return students.Insert(StudentID, Name, Grade);
        }
        
    }
}