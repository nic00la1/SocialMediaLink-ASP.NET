using SocialMediaLink_ASP.NET;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.Configure<
    SocialMediaLinksOptions>(
    builder.Configuration.GetSection("SocialMediaLinks"));

WebApplication app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
