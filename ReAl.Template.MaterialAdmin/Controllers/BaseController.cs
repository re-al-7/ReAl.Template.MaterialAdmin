using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.MaterialAdmin.Dal.Entidades;
using ReAl.Template.MaterialAdmin.Helpers;

namespace ReAl.Template.MaterialAdmin.Controllers
{
    public class BaseController : Controller
    {
        public string getLogin()
        {
            if (User.Identity.IsAuthenticated)
                return User.Identity.Name;
            return null;
        }

        public string getUserName()
        {
            if (User.Identity.IsAuthenticated)
                return User.Identity.GetGivenName();
            return null;
        }

        public EntSegUsuario getUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                return new EntSegUsuario();
            }
            else
                return null;
        }

        public List<EntSegAplicaciones> getAplicaciones()
        {
            List<EntSegAplicaciones> lista = new List<EntSegAplicaciones>();

            var obj = new EntSegAplicaciones();
            obj.aplicacionsap = "CLA";
            obj.descripcionsap = "CLASIFICADORES";
            lista.Add(obj);

            obj = new EntSegAplicaciones();
            obj.aplicacionsap = "SEG";
            obj.descripcionsap = "SEGURIDAD";
            lista.Add(obj);

            return lista;
        }

        public List<EntSegPaginas> getPages()
        {
            List<EntSegPaginas> lstPaginas = new List<EntSegPaginas>();

            EntSegPaginas obj = null;
            if (HttpContext.Session.GetString("currentApp") == "CLA")
            {
                obj = new EntSegPaginas();
                obj.descripcionspg = "Hijo CLA";
                obj.nombrespg = "dashboard";
                obj.nombremenuspg = "index";
                lstPaginas.Add(obj);
            }
            obj = new EntSegPaginas();
            obj.descripcionspg = "Hijo normal";
            obj.nombrespg = "segusuario";
            obj.nombremenuspg = "index";
            lstPaginas.Add(obj);

            return lstPaginas;
        }
    }
}