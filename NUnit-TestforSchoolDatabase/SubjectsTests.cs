using NUnit.Framework;
using NUnit_TestforSchoolDatabase;
using SchoolDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDatabase.Tests
{
    [TestFixture()]
    public class SubjectsTests
    {
        private Subjects subjects;
        static List<TestCaseData> TestCases
        {
            get
            {
                return AddTestData.Get2();
            }
        }

        [SetUp]
        public void Setup()
        {
            subjects = new Subjects();
        }
        [Test()]
        [TestCaseSource("TestCases")]
        public String InsertTest(int SubjectID, String SubjectName)
        {
            return subjects.Insert(SubjectID, SubjectName);
        }
    }
}