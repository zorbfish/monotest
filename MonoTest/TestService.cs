using System;
using Nancy.Hosting.Self;

namespace MonoTest {
   public class TestService {
      private NancyHost _host;

      public void Start() {
         _host = new NancyHost(new Uri("http://localhost:5000"));
         _host.Start();
      }

      public void Stop() {
         _host.Stop();
      }
   }
}
