using System;
using NUnit.Framework;
using ServiceStack.Logging.Elmah;
using ServiceStack.Logging.Log4Net;

namespace ServiceStack.Logging.Tests.UnitTests
{
	[TestFixture]
	public class ElmahLogFactoryTests
	{
		[Test]
		public void ElmahLogFactoryTest()
		{
			ElmahLogFactory factory = new ElmahLogFactory(new Log4NetFactory());
			ILog log = factory.GetLogger(GetType());
			Assert.IsNotNull(log);
			Assert.IsNotNull(log as ElmahInterceptingLogger);
		}
	}
}