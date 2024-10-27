using Microsoft.EntityFrameworkCore;
using ApiEmpresa2.models;
using Microsoft.Build.Framework;
// Add services to the container.


builder.Services.AddControllers();
builder.Services.AddDbContext<Conexiones>(opt =>
    opt.MySQL(Builder.Configuration.getconeccionString"DefaultConnection"));
    //opt.useSqlServer(Builder.Configuration.getconeccionString"DefaultConnection"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
bui+lder.Services.AddSwaggerGen();

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
