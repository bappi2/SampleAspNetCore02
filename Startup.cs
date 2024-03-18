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
            await context.Response.WriteAsync("Hello from Use-1 1 \n");
            await next();
            await context.Response.WriteAsync("Hello from Use-1 2 \n");
            
        });
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Hello from Use-2 1 \n");
            await next();
            await context.Response.WriteAsync("Hello from Use-2 2 \n");
            
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