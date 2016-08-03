using Nancy;

namespace MonoTest {
   public class TestModule : NancyModule {
      public TestModule() {
         Get["/"] = parameters => "Hello World!";
      }
   };
}
