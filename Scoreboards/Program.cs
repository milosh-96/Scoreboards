using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.ResponseCompression;
using Scoreboards.Features.Baseball;
using Scoreboards.Features.Football;

namespace Scoreboards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
            builder.Services.AddScoped<BaseballScoreboardViewModel>();
            builder.Services.AddScoped<FootballScoreboardViewModel>();
            var app = builder.Build();
            //added for signalr
            app.UseResponseCompression();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();

           
            app.MapHub<FootballScoreboardHub>("/scoreboards/football");
            app.MapHub<BaseballScoreboardHub>("/scoreboards/baseball");
            app.MapFallbackToPage("/_Host");
            app.MapRazorPages();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
            app.Run();
        }
    }
}