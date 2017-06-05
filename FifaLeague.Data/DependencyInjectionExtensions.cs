using Microsoft.Practices.Unity;
using FifaLeague.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Data
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterData(this IUnityContainer container)
        {
            container.RegisterType<DbContext, FifaLeagueContext>();
            container.RegisterType<IMatchesRepository, MatchesRepository>();
        }
    }
}
