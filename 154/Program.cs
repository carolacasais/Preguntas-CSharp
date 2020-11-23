using System;
using System.Threading.Tasks;
using System.Threading;

namespace _154
{
    class Program
    {
        async task Main(string[] args)
        {
            await StartTask();

            await GetData();
        }

        protected async void StartTask()
        {
            string result = await GetData();
            // ...
        }
        public async Task<string> GetData()
        {

        }
    }
}
