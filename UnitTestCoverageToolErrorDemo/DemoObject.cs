using System;
using System.Threading.Tasks;

namespace UnitTestCoverageToolErrorDemo
{
    public class DemoObject
    {
        public int TestedMethod_Add(int A, int B)
        {
            return A + B;
        }

        public Task<int> TestedMethod_AddAsync(int a, int b)
        {
            var result = Task.Run(()=>TestedMethod_Add(a, b));
            return result;
        }

        public void SimulateExceptionInAsyncTask_FromVoid()
        {
            Task.Run(() =>
            {
                throw new Exception();
            });
        }

        public async void SimulateExceptionInAsyncTask_FromAsyncVoid()
        {
            await Task.Run(() => 
            {
                throw new Exception();
            });
        }

    }
}
