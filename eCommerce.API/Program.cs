using System.Text.Json.Serialization;
using eCommerce.API.Middleware;
using eCommerce.Core;
using eCommerce.Core.Mappers;
using eCommerce.InfraStructure;
var builder = WebApplication.CreateBuilder(args);
// Add Infrastructure Services
builder.Services.AddInfraStructure();
// Add Core Services
builder.Services.AddCore();
// Add Controllers
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);
var app = builder.Build();

//Exception Handling 
app.UseExceptionHandlingMiddleware();
//Route
app.UseRouting();
//Auth
app.UseAuthentication();
app.UseAuthorization();
//Controllers Route
app.MapControllers();
app.Run();
