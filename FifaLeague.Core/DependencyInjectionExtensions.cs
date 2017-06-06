using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterCore(this IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IFileStorage, FileStorage>();

            unityContainer.RegisterType<ITableCalculator, TableCalculator>();
            unityContainer.RegisterType<ITournamentService, TournamentService>();
            unityContainer.RegisterType<IMatchService, MatchService>();
        }
    }
}
