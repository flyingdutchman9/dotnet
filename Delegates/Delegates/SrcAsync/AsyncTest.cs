using System;
using System.Text;

namespace Delegates.SrcAsync
{
    public class AsyncTest
    {
        public async Task StartAsyncTest()
        {
            try
            {
                "Random...".Output();
                new Random().Next(1, 10).Output();
                string response = await GetUrlContentLengthAsync();
                response.Output();

                var someTask = await Task.Run(() => GetTestResult());
            }
            catch (Exception ex)
            {
                ex.Message.Output();
            }

            Console.ReadLine();
        }

        private string GetTestResult()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.AppendLine($"Some result {i+1}");
            }

            return sb.ToString();
        }

        public async Task<string> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com");

            DoIndependentWork();

            string contents = await getStringTask;

            return contents;
        }

        void DoIndependentWork()
        {
            //Thread.Sleep(2000);
            Console.WriteLine("Working...");
        }

    }
}

