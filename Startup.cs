namespace SampleAspNetCore02;

public class Startup 
{
    public IConfiguration Configuration { get;  }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration; 
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
    {
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Hello from Use \n");
            await next();
            
        });
        app.Run(async context => await context.Response.WriteAsync("Hello from Run\n"));
        
        if (environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseRouting();
        app.UseAuthorization();
        
        /*app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync(("Hello from new Web Api app"));
            });
            
            endpoints.MapGet("/test", async context =>
            {
                await context.Response.WriteAsync(("Hello from new Web Api app test"));
            });
        });*/
        app.UseEndpoints(endpoint => endpoint.MapControllers());

    } 
}