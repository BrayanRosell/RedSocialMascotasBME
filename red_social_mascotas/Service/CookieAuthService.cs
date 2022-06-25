using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Models;
using red_social_mascotas.Repository;

namespace red_social_mascotas.Service
{
    public interface ICookieAuthService
    {
        void SetHttpContext(HttpContext httpContext);
        public void Login(ClaimsPrincipal claim);
        public Claim ObtenerClaim();
        Usuario LoggedUser();
    }


    public class CookieAuthService : ICookieAuthService
    {
        private HttpContext httpContext;
        private IRSMascotasContext context;
      
        public CookieAuthService(IRSMascotasContext context)
        {
  
            this.context = context;
        }
        public void SetHttpContext(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }

        public void Login(ClaimsPrincipal claim)
        {
            httpContext.SignInAsync(claim);

        }

        public Claim ObtenerClaim()
        {
            var claim = httpContext.User.Claims.FirstOrDefault();
            return claim;
        }
        public Usuario LoggedUser()
        {
            
            var claim = httpContext.User.Claims.FirstOrDefault();

            var user = context._Usuarios.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}