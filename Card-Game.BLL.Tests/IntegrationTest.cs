using Card_Game.ASP;
using Card_Game.DAL;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace Card_Game.BLL.Tests
{  
    public class IntegrationTest
    {
        protected readonly HttpClient TestClient;

        protected IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
                //.WithWebHostBuilder(builder => 
                //{
                //    builder.ConfigureServices(services =>
                //    {
                //        services.RemoveAll(typeof(DatabaseContext));
                //        services.AddDbContext<DatabaseContext>(options =>
                //        {
                            
                //        });
                //    });
                //});
            TestClient = appFactory.CreateClient();
        }

        [Fact]
        public async Task AuthenticateAsync()
        {
            var response = await TestClient.GetAsync("/counter/SampleMethod");
        }

        //private async Task<string> GetJwtAsync()
        //{

        //}
    }
}
