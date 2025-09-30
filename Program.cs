var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Configure default files (index.html)
app.UseDefaultFiles();

// Fallback to serve index.html for SPA-like behavior
app.MapFallbackToFile("index.html");

app.Run();