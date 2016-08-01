using Topshelf;

namespace MonoTest {
   public class Program {
      public static void Main() {
         HostFactory.Run(config => {
            config.Service<TestService>(x => {
               x.ConstructUsing(() => new TestService());
               x.WhenStarted(s => s.Start());
               x.WhenStopped(s => s.Stop());
            });

            config.RunAsLocalService();
            config.SetDescription("MonoTest with Nancy/Topshelf");
            config.SetDisplayName("MonoTest");
            config.SetServiceName("MonoTest");
         });
      }
   }
}

