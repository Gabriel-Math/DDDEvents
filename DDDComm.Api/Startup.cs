using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Repositories;
using DDDEvents.Infra.Contexts;
using DDDEvents.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DDDEvents.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<DDDEvents_EventsAlternativo, DDDEvents_EventsAlternativo>();

            services.AddTransient<IUserRepository, UserRepositoryPersistence2>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
