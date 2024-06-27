    var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
/*builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();*/

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/
app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();

//app.UseAuthentication();

//app.UseAuthorization();

app.MapControllers();

//app.MapGet("/shirts", () => { });
/***
app.MapGet("/shirts", () => { return "Reading All the shirts"; });

app.MapGet("/shirts/{id}", (int id ) => { return $"Reading shirt with ID: {id} "; });

app.MapPost("/shirts", () => { return "Creating Short."; });

app.MapPut("/shirts/{id}", (int id ) => { return $"Update Shirts with ID: {id} "; });

app.MapDelete("/shirts/{id}", (int id) => { return $"Delete Shirts with ID: {id} "; });
*///
app.Run();
