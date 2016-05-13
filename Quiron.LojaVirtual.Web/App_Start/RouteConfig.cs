using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Primeira pagina exibida - first route
            routes.MapRoute(null,
               "",
               new
               {
                   controller = "Vitrine"
               ,
                   action = "ListaProdutos"
               ,
                   categoria = (string)null
               ,
                   pagina = 1
               }
               );

            // second Route
            routes.MapRoute(null,
                "Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    Action = "ListaProdutos",
                    categoria = (string)null
                },
                new { pagina = @"\d+" });


            // terceira  route for put the url categoria 
            routes.MapRoute(null, "{categoria}",
                new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    pagina = 1
                });

            //quarta Route
            routes.MapRoute(null,
                "{categoria}Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    Action = "ListaProdutos"
                },
                new { pagina = @"\d+" });


            routes.MapRoute(null, "{controller}/{action}");


        }
    }
}
