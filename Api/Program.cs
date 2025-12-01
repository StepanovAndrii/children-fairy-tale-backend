using Api.Endpoints.Stories;
using Application.Interfaces.Internal;
using Application.Interfaces.Internal.Repositories;
using Application.Services;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IStoryRepository, StoryRepository>();
builder.Services.AddScoped<IStoryService, StoryService>();

var app = builder.Build();


if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

CreateStory.Map(app);
GetStorySummaries.Map(app);
GetChaptersSummary.Map(app);
GetParagraphs.Map(app);
DeleteStory.Map(app);

app.Run();
