using TeamVoting.Modules.Administration;
using TeamVoting.Modules.Communication;
using TeamVoting.Modules.Identity;
using TeamVoting.Modules.Room;
using TeamVoting.Modules.TeamGeneration;
using TeamVoting.Modules.Voting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy => policy
        .WithOrigins("http://localhost:5173")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()));

builder.Services
    .AddIdentityModule(builder.Configuration)
    .AddRoomModule(builder.Configuration)
    .AddCommunicationModule(builder.Configuration)
    .AddVotingModule(builder.Configuration)
    .AddTeamGenerationModule(builder.Configuration)
    .AddAdministrationModule(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors();

app.MapGet("/health", () => Results.Ok("healthy"));

app.MapIdentityEndpoints();
app.MapRoomEndpoints();
app.MapCommunicationEndpoints();
app.MapVotingEndpoints();
app.MapTeamGenerationEndpoints();
app.MapAdministrationEndpoints();

app.Run();