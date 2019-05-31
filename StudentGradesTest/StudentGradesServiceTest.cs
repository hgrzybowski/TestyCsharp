using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsGrades.Models;
using StudentsGrades.Services;
using System.Collections.Generic;

namespace StudentGradesTest
{
    [TestClass]
    public class StudentGradesServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturnCorrectResult()
        {
            var list = new List<Grade>
            {
                new Grade {Value=5,Weight=2},
                new Grade {Value=4,Weight=3}
            };
            var result = serviceUnderTests.Calculate(list);

            Assert.AreEqual(4.4M, result);
        }
        
            #region CONFIGURATION
            StudentGradesService serviceUnderTests;

            public StudentGradesServiceTest()
            {
                serviceUnderTests = new StudentGradesService();
            }
            #endregion
        
    }
}
