using System.Threading;
using NUnit.Framework;

namespace nunit_bug
{
    public class Tests
    {
        [Test, Timeout(1000)]
        public void Test1()
        {
            Thread.Sleep(2000);
        }
    }
}