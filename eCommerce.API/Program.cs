using eCommerce.API.Middleware;
using eCommerce.Core;
using eCommerce.InfraStructure;
var builder = WebApplication.CreateBuilder(args);
// Add Infrastructure Services
builder.Services.AddInfraStructure();
// Add Core Services
builder.Services.AddCore();
// Add Controllers
builder.Services.AddControllers();
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
