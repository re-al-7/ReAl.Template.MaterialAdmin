// // <copyright file="CMenus.cs" company="INTEGRATE - Soluciones Informaticas">
// // Copyright (c) 2016 Todos los derechos reservados
// // </copyright>
// // <author>re-al </author>
// // <date>2017-11-17 23:18</date>

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using ReAl.Template.MaterialAdmin.Dal.Entidades;

namespace ReAl.Template.MaterialAdmin.Helpers
{
    public static class CMenus
    {
        public static List<EntSegAplicaciones> GetAplicaciones()
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
        
        public static List<EntSegPaginas> GetPages(HttpContext miContexto)
        {
            List<EntSegPaginas> lstPaginas = new List<EntSegPaginas>();

            EntSegPaginas obj = null;
            if (miContexto.Session.GetString("currentApp") == "CLA")
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