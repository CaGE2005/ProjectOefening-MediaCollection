using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MediaCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    //public class ConvertFileToImage 
    //{
    //    private byte[] ConvertToBytes (IFormFile image)
    //    {
    //        byte[] CoverImageBytes = null;
    //        BinaryReader reader = new BinaryReader(image.OpenReadStream());
    //        CoverImageBytes = reader.ReadBytes((int)image.Length);
    //        return CoverImageBytes;
    //    }
    //}
}
