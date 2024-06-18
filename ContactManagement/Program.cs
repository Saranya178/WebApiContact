using ContactManagement.ContactService;
using ContactManagement.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowSpecificOrigin",
			builder => builder
					.WithOrigins("http://localhost:4200") // The Angular app's address
					.AllowAnyMethod()
					.AllowAnyHeader());
});
builder.Services.AddSingleton<IContactService, ContactService>();

var app = builder.Build();

app.UseMiddleware<CustomExceptionMiddleware>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors("AllowSpecificOrigin");

app.MapControllers();

app.Run();
