using FifaLeague.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace FifaLeague.Data
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterData(this IServiceCollection services)
        {
            services.AddScoped<DbContext, FifaLeagueContext>();
            services.AddScoped<IMatchesRepository, MatchesRepository>();
            services.AddScoped<ITournamentsRepository, TournamentsRepository>();
        }
    }
}
