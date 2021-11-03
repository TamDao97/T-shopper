using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tshopper.Business;
using Tshopper.Infrastructure;

namespace Tshopper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        [HttpPost, Route("")]
        public async Task<Response> Insert(ProductCreateModel model)
        {
            return await _productBusiness.Insert(model);
        }

        //[HttpGet]
        //public async Task<IActionResult> Test()
        //{
        //    bool isResult = false;
        //    try
        //    {
        //        Stopwatch stopwatch = new Stopwatch();
        //        stopwatch.Start();
        //        var parallelLoopResult = Parallel.For(1, 50001, j =>
        //          {
        //              using (var context = new TshopperContext(ServiceRegister._contextOptions))
        //              {
        //                  context.Database.SetCommandTimeout(TimeSpan.FromMinutes(30.0));
        //                  StringBuilder sqlQueryBuilder = new StringBuilder();
        //                  sqlQueryBuilder.Append("INSERT INTO Province VALUES ");
        //                  Guid userId = Guid.NewGuid();
        //                  for (int i = ((j - 1) * 200) + 1; i <= j * 200; i++)
        //                  {
        //                      sqlQueryBuilder.Append($"('{Guid.NewGuid()}','Code-{i}','Name-{i}',{i},'{userId}','{DateTime.Now.ToString()}','{userId}','{DateTime.Now.ToString()}',1),");
        //                  }

        //                  string textCmd = sqlQueryBuilder.ToString().TrimEnd(',');

        //                  try
        //                  {
        //                      context.Database.ExecuteSqlRaw(textCmd);
        //                  }
        //                  finally
        //                  {
        //                      context.Database.CloseConnection();
        //                  }
        //              }
        //          });

        //        isResult = parallelLoopResult.IsCompleted;
        //        stopwatch.Stop();
        //        Debug.WriteLine($"Time Excute = {stopwatch.ElapsedMilliseconds}");
        //    }
        //    catch (Exception ex)
        //    {
        //        StreamWriter streamWriter = new StreamWriter(@"D://log.txt");
        //        streamWriter.WriteLine(ex.ToString());
        //    }

        //    return Ok(isResult);
        //}

        //[HttpPost, Route("download-file")]
        //public async Task<FileStreamResult> DownloadFile()
        //{
        //    MemoryStream memoryStream = null;

        //    try
        //    {
        //        string base64Certificate = "U2F2aXMgVGVjaG9sb2d5IQVGVzdCBkb3dubG9hZEZpbGVTdHJlYW0";
        //        byte[] bytes = Encoding.ASCII.GetBytes(base64Certificate);
        //        memoryStream = new MemoryStream(bytes);
        //    }
        //    catch
        //    {

        //    }

        //    return File(memoryStream, "application/octet-stream", "certificate.cer");
        //}
    }
}
