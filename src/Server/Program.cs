// Minimal starting shell for the workshop. Right now it only serves the static UI
// and proves your setup works — run it and open http://localhost:5000.
//
// During the workshop this grows into the real composition root: register the write
// side (builder.Services.AddFocument(...)) and map the /api/* endpoints.

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Server;

var builder = WebApplication.CreateBuilder(args);

// Compact one-line console logs (format + which categories show: appsettings.json).
builder.Logging.AddConsoleFormatter<WorkshopConsoleFormatter, WorkshopFormatterOptions>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// TODO (workshop): wire the domain and the API here, e.g.
//   builder.Services.AddFocument(connectionString);   // before Build()
//   app.MapGet("/api/documents", ...);
//   app.MapPost("/api/document", ...);

app.Run();
