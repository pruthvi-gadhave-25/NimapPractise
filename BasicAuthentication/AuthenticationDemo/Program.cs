using AuthenticationDemo.Models;
using AuthenticationDemo.Repository;
using Microsoft.AspNetCore.Authentication;

//Basic authentication is only secure over HTTPS.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// JSON property name to be displayed as it is
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // This will use the property names as defined in the C# model
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    }); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//This method is used to add and configure a specific authentication scheme. 
//Here, it adds a scheme named “BasicAuthentication”. 
//This method takes the following two Generic Parameters
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
    ("BasicAuthentication", options => { });

//register services 
builder.Services.AddSingleton<IUserRepository, UserRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
