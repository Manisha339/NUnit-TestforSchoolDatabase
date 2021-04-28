using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_TestforSchoolDatabase
{
    class AddTestData
    {
        public static List<TestCaseData> Get()
        {
            var list1 = new List<TestCaseData>();
            list1 = new List<TestCaseData>();
            list1.Add(new TestCaseData(1, "Jithin Allu","VIII").Returns("Jithin Allu"));
            list1.Add(new TestCaseData(2, "Manisha Allu", "VII").Returns("Manisha Allu"));
            list1.Add(new TestCaseData(3, "Naresh Allu", "VI").Returns("Naresh Allu"));
            list1.Add(new TestCaseData(4, "Jamuna Allu", "V").Returns("Jamuna Allu"));

           
            return list1;
           
        }
        public static List<TestCaseData> Get1()
        {
            var list = new List<TestCaseData>();
            list.Add(new TestCaseData(1, "Divya", "VIII").Returns("Divya"));
            list.Add(new TestCaseData(2, "Drivitha", "VII").Returns("Drivitha"));
            list.Add(new TestCaseData(3, "Madhu", "VI").Returns("Madhu"));
            list.Add(new TestCaseData(4, "Gnanesh", "V").Returns("Gnanesh"));


            return list;
            
        }
        public static List<TestCaseData> Get2()
        {
            var list = new List<TestCaseData>();
            list.Add(new TestCaseData(1, "Maths").Returns("Maths"));
            list.Add(new TestCaseData(2, "Social").Returns("Social"));
            list.Add(new TestCaseData(3, "Science").Returns("Science"));
            list.Add(new TestCaseData(4, "English").Returns("English"));


            return list;
        }
    }
}
