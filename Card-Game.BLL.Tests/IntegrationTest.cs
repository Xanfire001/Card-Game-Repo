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
    //public class IntegrationTest : IClassFixture<WebApplicationFactory<Card_Game.ASP.Startup>>
    //{
    //    private readonly WebApplicationFactory<Card_Game.ASP.Startup> _factory;

    //    protected IntegrationTest(WebApplicationFactory<Card_Game.ASP.Startup> factory)
    //    {
    //        _factory = factory;
            
    //    }

    //    public async Task Get_TestName(string url)
    //    {
    //        //Arrange
    //        var client = _factory.CreateClient();

    //    }

        //[Fact]
        //public async Task AuthenticateAsync()
        //{
        //    var appFactory = new WebApplicationFactory<Startup>();
        //    //.WithWebHostBuilder(builder => 
        //    //{
        //    //    builder.ConfigureServices(services =>
        //    //    {
        //    //        services.RemoveAll(typeof(DatabaseContext));
        //    //        services.AddDbContext<DatabaseContext>(options =>
        //    //        {

        //    //        });
        //    //    });
        //    //});
        //    TestClient = appFactory.CreateClient();
        //}

        //private async Task<string> GetJwtAsync()
        //{

        //}
    //}
}
