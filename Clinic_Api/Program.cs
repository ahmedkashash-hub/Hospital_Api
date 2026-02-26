using Hospital.Application;
using Hospital.Infrastructure.Persistence.Database;
using Hospital.Infrastructure.Persistence.Extensions;
using Hospital.Infrastructure.Server;
using Hospital_Api.Extentions;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Phoenix.Mediator.Extensions;
using Phoenix.Mediator.Web;
using Scalar.AspNetCore;



var builder = WebApplication.CreateBuilder(args);
builder.AddLogging();
builder.Services.AddOpenApi();

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddPersistenceServices(connectionString: builder.Configuration.GetConnectionString("Hospital") ?? throw new KeyNotFoundException("dbConnection was not found"),
                                        enableSensitiveLogging: true,
                                        ignoreModelWarnings: true);

builder.Services.AddWebapiServices(builder.Configuration);

var app = builder.Build();
using (IServiceScope scope = app.Services.CreateScope())
{
    var dbcontext = scope.ServiceProvider.GetRequiredService<HospitalDbContex>();
#if DEBUG
    dbcontext.Database.EnsureDeleted();
#endif
    if (dbcontext.Database.GetPendingMigrations().Any())
    {
        dbcontext.Database.Migrate();
    }
}
if (builder.Configuration.GetValue<bool>("isScalarEnabled"))
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "uploads")),
    RequestPath = "/uploads"
});
app.UseRateLimiter();
app.UseHttpsRedirection();
app.UseCors("cors-policy");
app.UseAuthentication();
app.UseAuthorization();

app.MapEndpoints();
app.Run();

