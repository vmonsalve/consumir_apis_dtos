using CONSUMIR_API_DTOs.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var baseUrlPosts = builder.Configuration["BaseUrlPosts"] ?? throw new InvalidOperationException("Configuracion no encontrada.");
builder.Services.AddHttpClient<IPostsService, PostsService>(c => 
{
    c.BaseAddress = new Uri(baseUrlPosts);
});
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
