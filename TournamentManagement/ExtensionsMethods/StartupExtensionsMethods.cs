using Microsoft.EntityFrameworkCore;
using TournamentManagement.Repository.Implementations;
using TournamentManagement.Repository.Interfaces;
using TournamentManagement.Services.Implementations;
using TournamentManagement.Services.Interfaces;

namespace TournamentManagement.ExtensionsMethods
{
    public static class StartupExtensionsMethods
    {
        public static void AddApplicationDbContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITournamentRepository, TournamentRepository>();
            services.AddScoped<IParticipantRepository, ParticipantRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IMatchRepository, MatchRepository>();
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITournamentService, TournamentService>();
            services.AddScoped<IParticipantService, ParticipantService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IMatchService, MatchService>();
        }
    }
}
