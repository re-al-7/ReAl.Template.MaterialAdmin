using System.Collections.Generic;
using ReAl.Template.MaterialAdmin.Dal.Entidades;
using ReAl.Template.MaterialAdmin.Models;

namespace ReAl.Template.MaterialAdmin.Pages.Template
{
    public class IndexModel: BasePageModel
    {
        public List<EntSegAplicaciones> ListApp { get; private set; }
        public List<EntSegPaginas> ListPages { get; private set; }
        public string Usuario { get; private set; }

        public void OnGet()
        {
            ListApp = this.GetAplicaciones();
            ListPages = this.GetPages();
            Usuario = this.getUserName();
        }
    }
}