using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderingSample.Business.Abstract;
using OrderingSample.Business.Concrete;
using OrderingSample.DataAccess.Abstract;
using OrderingSample.DataAccess.Concrete;
using OrderingSample.DataAccess.Context;

namespace OrderingSample.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<DbContext,OrderDbContext>();
            services.AddTransient<OrderManager>();
            services.AddTransient<OrderRepository>();
            services.AddTransient<ICustomerService, CustomerManager>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            //services.AddEntityFrameworkSqlServer()
            //        .AddDbContext<OrderDbContext>
            //        (option => option.UseSqlServer(Configuration["database:connection"]));
            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
