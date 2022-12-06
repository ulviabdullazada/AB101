using System.Diagnostics;

namespace ThreadAsynchronous
{
    internal class Program
    {
        static string[] sites = {
            "https://docs.microsoft.com",
            "https://docs.microsoft.com/aspnet/core",
            "https://docs.microsoft.com/azure",
            "https://docs.microsoft.com/azure/devops",
            "https://docs.microsoft.com/dotnet",
            "https://docs.microsoft.com/dynamics365",
            "https://docs.microsoft.com/education",
            "https://docs.microsoft.com/enterprise-mobility-security",
            "https://docs.microsoft.com/gaming",
            "https://docs.microsoft.com/graph",
            "https://docs.microsoft.com/microsoft-365",
            "https://docs.microsoft.com/office",
            "https://docs.microsoft.com/powershell"
        };
        static void Main(string[] args)
        {
            #region Thread, Race Condition
            //Loop();
            //Loop2();
            //Thread t1 = new Thread(Loop);
            //Thread t2 = new Thread(Loop2);
            //t1.Start();
            //t2.Start();
            //Console.WriteLine("Salam");
            //t1.Join();
            //t2.Join();
            //Console.WriteLine("Salam");
            //Thread t1 = new Thread(Increase);
            //Thread t2 = new Thread(Decrease);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            //Console.WriteLine(Count);
            #endregion
            Stopwatch sw = Stopwatch.StartNew();
            //Task.WhenAll(Loop(), Loop2()).Wait();
            //Loop().Wait();
            //Loop2().Wait();
            //SeherYemeyi();
            //SeherYemeyiAsync().Wait();
            Console.WriteLine("Synchronous");
            GetData();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Asynchronous");
            GetDataAsync().Wait();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        static void GetData()
        {
            HttpClient client = new HttpClient();
            foreach (var item in sites)
            {
                var a = client.GetStringAsync(item).Result;
            }
        }

        static async Task GetDataAsync()
        {
            HttpClient client = new HttpClient();
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (var item in sites)
            {
                tasks.Add(client.GetStringAsync(item));
            }
            await Task.WhenAll(tasks);
        }
        static async Task SeherYemeyiAsync()
        {
            await Task.WhenAll(CayAsync(),YumurtaAsync(),SufreHazirlaAsync());
            Console.WriteLine("Nush olsun");
        }
        static async Task CayAsync()
        {
            Console.WriteLine("Qazin alti yandi");
            Console.WriteLine("Caydan uste qoyuldu");
            await Task.Delay(8000);
            Console.WriteLine("Caydan qaynadi");
        }
        static async Task YumurtaAsync()
        {
            Console.WriteLine("Yumurta qirildi");
            Console.WriteLine("Tavaya tokuldu");
            await Task.Delay(4000);
            Console.WriteLine("Yumurta bisdi");
        }
        static async Task SufreHazirlaAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Sufre hazirdir");
        }
        static void SeherYemeyi()
        {
            Cay();
            Yumurta();
            SufreHazirla();
            Console.WriteLine("Nush olsun");
        }
        static void Cay()
        {
            Console.WriteLine("Qazin alti yandi");
            Console.WriteLine("Caydan uste qoyuldu");
            Thread.Sleep(8000);
            Console.WriteLine("Caydan qaynadi");
        }
        static void Yumurta()
        {
            Console.WriteLine("Yumurta qirildi");
            Console.WriteLine("Tavaya tokuldu");
            Thread.Sleep(4000);
            Console.WriteLine("Yumurta bisdi");
        }
        static void SufreHazirla()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sufre hazirdir");
        }
        static async Task Loop()
        {
            Console.WriteLine("Loop");
            await Task.Run(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
        static async Task Loop2()
        {
            Console.WriteLine("Loop2");
            await Task.Run(() =>
            {
                for (int i = 500; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
        #region Thread, Race Condition
        static int Count { get; set; }
        static object lockObj = new object();
        static void Increase()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (lockObj)
                {
                    Count++;
                }
            }
        }
        static void Decrease()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (lockObj)
                {
                    Count--;
                }
            }
        }
        //static void Loop()
        //{
        //    for (int i = 0; i < 500; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //static void Loop2()
        //{
        //    for (int i = 500; i < 1000; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion
    }
}