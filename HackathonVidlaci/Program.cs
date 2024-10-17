using HackathonVidlaci.Classes;
using HackathonVidlaci.Components;
using Microsoft.EntityFrameworkCore;

namespace HackathonVidlaci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddDbContext<HradyContext>(options => options.UseSqlite("Data Source=./Database/Hrady.geodatabase"));
            builder.Services.AddDbContext<HrobyContext>(options => options.UseSqlite("Data Source=./Database/Váleèné_hroby.geodatabase"));
            builder.Services.AddDbContext<DivadlaContext>(options => options.UseSqlite("Data Source=./Database/Divadla_a_filharmonie.geodatabase"));
            builder.Services.AddDbContext<ZamkyContext>(options => options.UseSqlite("Data Source=./Database/Zámky.geodatabase"));
            builder.Services.AddDbContext<KulturniDomyContext>(options => options.UseSqlite("Data Source=./Database/Kulturní_domy.geodatabase"));
            builder.Services.AddDbContext<TechnickePamatkyContext>(options => options.UseSqlite("Data Source=./Database/Technické_památky.geodatabase"));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
