using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Tshopper.Infrastructure;

namespace Tshopper.Api.Extension
{
    public static class BulkInitData
    {
        public static void BulkInsertProvince()
        {
            bool isResult = false;
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var parallelLoopResult = Parallel.For(1, 50001, j =>
                {
                    using (var context = new TshopperContext(ServiceRegister._contextOptions))
                    {
                        context.Database.SetCommandTimeout(TimeSpan.FromMinutes(30.0));
                        StringBuilder sqlQueryBuilder = new StringBuilder();
                        sqlQueryBuilder.Append("INSERT INTO Province VALUES ");
                        Guid userId = Guid.NewGuid();
                        for (int i = ((j - 1) * 200) + 1; i <= j * 200; i++)
                        {
                            sqlQueryBuilder.Append($"('{Guid.NewGuid()}','Code-{i}','Name-{i}',{i},'{userId}','{DateTime.Now.ToString()}','{userId}','{DateTime.Now.ToString()}',1),");
                        }

                        string textCmd = sqlQueryBuilder.ToString().TrimEnd(',');

                        try
                        {
                            context.Database.ExecuteSqlRaw(textCmd);
                        }
                        finally
                        {
                            context.Database.CloseConnection();
                        }
                    }
                });

                isResult = parallelLoopResult.IsCompleted;
                stopwatch.Stop();
                Debug.WriteLine($"Time Excute = {stopwatch.ElapsedMilliseconds}");
            }
            catch (Exception ex)
            {
                StreamWriter streamWriter = new StreamWriter(@"D://log.txt");
                streamWriter.WriteLine(ex.ToString());
            }

        }
    }
}
