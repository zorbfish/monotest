using Xunit;
using Nancy.Testing;
using MonoTest;
using System.Net;

namespace MonoTest.Tests {
   public class AtTheIndex {
      [Fact]
      public void ItReturnsOk() {
         var browser = new Browser(with => with.Module(new TestModule()));

         var response = browser.Get("/", with => {
            with.HttpRequest();
         });

         Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)response.StatusCode);
      }
  }
}
