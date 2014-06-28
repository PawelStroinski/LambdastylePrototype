using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using NUnit.Framework;

namespace Test
{
    class FacadeExceptionTest
    {
        [Test]
        public void NoStackTrace()
        {
            var exception = new Exception("no stack trace");
            Assert.IsNull(exception.StackTrace);
            var sut = new OtherFacadeException(exception);
            Assert.IsNotEmpty(sut.ToString());
        }
    }
}
