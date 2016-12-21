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
            dc.RelGrupoUsuarios.InsertOnSubmit(relgrupousuario);
            dc.SubmitChanges();
        }

        // DELETE api/values/5
        [Route("api/relgrupousuario/{usuarioId}/{grupoUsuarioId}")]
        public void Delete(int usuarioId, int grupoUsuarioId)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            Models.RelGrupoUsuario RelgrupoUsuario = (from f in dc.RelGrupoUsuarios where f.Usuario_Id == usuarioId && f.GrupoUsuario_Id == grupoUsuarioId select f).Single();
            dc.RelGrupoUsuarios.DeleteOnSubmit(RelgrupoUsuario);
            dc.SubmitChanges();
        }
    }
}
