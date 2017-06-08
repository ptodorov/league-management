using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterCore(this IServiceCollection services)
        {
            services.AddSingleton<IFileStorage, FileStorage>();

            services.AddScoped<ITableCalculator, TableCalculator>();
            services.AddScoped<ITournamentService, TournamentService>();
            services.AddScoped<IMatchService, MatchService>();
        }
    }
}
