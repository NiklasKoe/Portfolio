using Backend;
using Backend.Models.DB;
using System.Diagnostics;

string text = "";
for (long i = 0; i < long.MaxValue; i++) {
    text = text += "h";
    if (i % 10000 == 0) {
        Console.WriteLine("still doing");
    }
}

var sw = Stopwatch.StartNew();
//
var blo = text.Contains("g");
//
sw.Stop();
//
Console.WriteLine("Contains: " + sw.ElapsedMilliseconds);
//
var sw2 = Stopwatch.StartNew();
//
var ble = text.IndexOf("g") > -1;
//
sw2.Stop();
//
Console.WriteLine("IndexOf: " + sw2.ElapsedMilliseconds);




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddCors(options => {
    //
    options.AddPolicy("CORSPolicy",
        builder => builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .SetIsOriginAllowed(( hosts ) => true));
});




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RatingContext>();


var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CORSPolicy");

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
    endpoints.MapHub<BroadcastHub>("/offers");
    endpoints.MapHub<BroadcastHub>("chat");
});

app.UseHttpsRedirection();





app.MapControllers();

app.Run();
