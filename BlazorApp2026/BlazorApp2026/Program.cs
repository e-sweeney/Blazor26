using Blazor26.DataAccess.DataAccess;
using Blazor26.Services;
using Blazor26.Services.BusinessModels;
using BlazorApp2026.Components;
using Syncfusion.Blazor;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2026
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //adding the trial license key
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JHaF1cXmhMYVB3WmFZfVhgdVdMZV5bRHNPIiBoS35RcEVmWX5fc3VQQ2ZYVkByVEFe");
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();
            builder.Services.AddSingleton<MLService>();
            builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IFileMgt, FileMgt>();
            
            //adding Syncfusion DI
            builder.Services.AddSyncfusionBlazor();
            var app = builder.Build();
            
            using (var scope = app.Services.CreateScope())
            {
                var mlService = scope.ServiceProvider.GetRequiredService<MLService>();
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                var sales = unitOfWork.SalesRepo.ListOfSalesDataAsync().Result;

                if (sales.Any())
                {
                    var monthMap = new Dictionary<string, float>
                    {
                        { "January", 1 },
                        { "February", 2 },
                        { "March", 3 },
                        { "April", 4 },
                        { "May", 5 },
                        { "June", 6 },
                        { "July", 7 },
                        { "August", 8 },
                        { "September", 9 },
                        { "October", 10 },
                        { "November", 11 },
                        { "December", 12 }
                    };

                    var data = sales.Select(s => new SalesData
                    {
                        Month = monthMap[s.MonthName],
                        SalesAmount = (float)s.SalesAmount
                    }).ToList();

                    mlService.Train(data);
                    Console.WriteLine("✅ Model trained at startup");
                }
                else
                {
                    Console.WriteLine("❌ No data available for training");
                }
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
