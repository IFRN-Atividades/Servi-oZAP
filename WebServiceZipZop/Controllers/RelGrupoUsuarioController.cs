using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebServiceZipZop.Controllers
{
    public class RelGrupoUsuarioController : ApiController
    {
        public IEnumerable<Models.RelGrupoUsuario> Get()
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            var r = from f in dc.RelGrupoUsuarios select f;
            return r.ToList();
        }

        // POST api/values
        public void Post([FromBody]Models.RelGrupoUsuario relgrupousuario)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            dc.RelGrupoUsuarios.InsertOnSubmit(new Models.RelGrupoUsuario() { Usuario_Id = relgrupousuario.Usuario_Id, GrupoUsuario_Id = relgrupousuario.GrupoUsuario_Id });
            dc.SubmitChanges();

            
        }


        // DELETE api/values/5
        public void Delete(int usuario_id, int grupousuario_id)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            Models.RelGrupoUsuario RelgrupoUsuario = (from f in dc.RelGrupoUsuarios where f.Usuario_Id == usuario_id && f.GrupoUsuario_Id == grupousuario_id select f).Single();
            dc.RelGrupoUsuarios.DeleteOnSubmit(RelgrupoUsuario);
            dc.SubmitChanges();
        }

    }
}
