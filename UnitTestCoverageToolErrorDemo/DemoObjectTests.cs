using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCoverageToolErrorDemo
{
    public class DemoObjectTests
    {
        [Test]
        public void T01_AddMethod_Returns_Result()
        {
            var a = 2;
            var b = 3;
            var expected = a + b;
            var sut = new DemoObject();

            var result = sut.TestedMethod_Add(a, b);

            Assert.AreEqual(expected, result);            
        }

        [Test]
        public async Task T02_AddMethodAsync_Returns_Result()
        {
            var a = 2;
            var b = 3;
            var expected = a + b;
            var sut = new DemoObject();

            var result = await sut.TestedMethod_AddAsync(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void T03_Simulate_ExceptionInAsyncTask_FromVoid()
        {
            var sut = new DemoObject();
            sut.SimulateExceptionInAsyncTask_FromVoid();

            Assert.Pass();
        }

        [Test]
        //[Ignore("Execution of test results in no test code coverage.")]
        public async Task T04_Simulate_ExceptionInAsyncTask_FromAsyncVoid()
        {
            var sut = new DemoObject();

            sut.SimulateExceptionInAsyncTask_FromAsyncVoid();

            Assert.Pass();
        }
    }
}
