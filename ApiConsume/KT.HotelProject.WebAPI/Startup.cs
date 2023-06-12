using KT.HotelProject.Business.Abstract;
using KT.HotelProject.Business.Concrete;
using KT.HotelProject.DataAccess.Abstract;
using KT.HotelProject.DataAccess.Concrete;
using KT.HotelProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KT.HotelProject.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HotelContext>();

            services.AddScoped<IStaffService, StaffManager>();
            services.AddScoped<IStaffRepository, EfStaffRepository>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceRepository, EfServiceRepository>();

            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IRoomRepository, EfRoomRepository>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialRepository, EfTestimonialRepository>();

            services.AddScoped<ISubscribeService, SubscribeManager>();
            services.AddScoped<ISubscribeRepository, EfSubscribeRepository>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutRepository, EfAboutRepository>();

            services.AddScoped<IBookingService, BookingManager>();
            services.AddScoped<IBookingRepository, EfBookingRepository>();

            services.AddAutoMapper(typeof(Startup));

            services.AddCors(opt =>
            {
                opt.AddPolicy("HotelApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KT.HotelProject.WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "KT.HotelProject.WebAPI v1"));
            }

            app.UseRouting();
            app.UseCors("HotelApiCors");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
