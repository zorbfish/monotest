using Nancy;

namespace Monotest {
   public class TestModule : NancyModule {
      public TestModule() {
         Get["/"] = parameters => "Hello World!";
      }
   };
}
