using Handlers;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var env = app.Environment;
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions() {
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, @"../vite-client/dist"))
});
app.MapGet("/test", () => "All I want is to be a monkey of moderate intelligence who wears a suit… that's why I'm transferring to business school! Oh Leela! You're the only person I could turn to; you're the only person who ever loved me. Wow! A superpowers drug you can just rub onto your skin? You'd think it would be something you'd have to freebase. Guards! Bring me the forms I need to fill out to have her taken away!");
app.MapGet("/", () => "Hello World!");

app.MapGroup("/vessels").MapVesselEndpoints();

// app.UseSpa(builder => {
//     // if (env.IsDevelopment()) {
//     //     builder.UseProxyToSpaDevelopmentServer("http://localhost:5173/");
//     // }
// });

app.Run();

