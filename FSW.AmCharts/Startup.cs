﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;

namespace FSW.AmCharts
{
    public class Startup : Core.StartupBase
    {
        public override void ConfigureMvc(IMvcBuilder mvc)
        {
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public override void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            RegisterFiles(new[]
            {
                "wwwroot.lib.amcharts.amcharts.js",
                "wwwroot.lib.amcharts.serial.js",
                "wwwroot.lib.amcharts.themes.light.js",
                "wwwroot.js.AmCharts.controls.AmCharts.js",
            });
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new EmbeddedFileProvider(typeof(Startup).Assembly, "FSW.AmCharts.wwwroot")
            });
        }
    }
}
