using Microsoft.EntityFrameworkCore;

namespace PeliculasAPI.Utilidades
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosPaginacionEnCabecera<T>(this HttpContext httpcontext,
            IQueryable<T> queryable) 
        {
            if (httpcontext == null) { throw new ArgumentNullException(nameof(httpcontext)); }

            double cantidad = await queryable.CountAsync();
            httpcontext.Response.Headers.Add("cantidadTotalRegistros", cantidad.ToString());
        } 
    }
}
