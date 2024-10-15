using System;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    internal class GregoryLeibnizGetPIJob : IComputePiJob
    {
        public Task ComputePyAsync(string name, int iterrations, CancellationToken token)
        {

            var startTime = DateTime.Now;

            long sum = 1;
            long a=1;

            var iterrationsToCheck = 1000;
            var iterrationCurrent = 0;

            for (int i = 0; i < iterrations; i++)
            {
                sum = sum + sum;

                Console.WriteLine($"{DateTime.Now}: Compute task: {name}, %: {sum}");
                Console.WriteLine(sum);
            }


            Console.WriteLine($"GetSTEPEN: {name}, Iterrations: {iterrations}, STEPEN={a}");

            return Task.CompletedTask;
        }
    }
}
