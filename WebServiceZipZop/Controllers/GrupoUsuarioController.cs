using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebServiceZipZop.Controllers
{
    public class GrupoUsuarioController : ApiController
    {
        public IEnumerable<Models.GrupoUsuario> Get()
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            var r = from f in dc.GrupoUsuarios select f;
            return r.ToList();
        }

        // GET api/values/5
        public Models.GrupoUsuario Get(int id)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            var r = from f in dc.GrupoUsuarios where id == f.Id select f;
            return r as Models.GrupoUsuario;
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Models.GrupoUsuario grupousuario)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            dc.GrupoUsuarios.InsertOnSubmit(new Models.GrupoUsuario() { Descricao = grupousuario.Descricao, idAdm = grupousuario.idAdm });
            dc.SubmitChanges();

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent(grupousuario.Id.ToString(), Encoding.Unicode);
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Models.GrupoUsuario grupousuario)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            Models.GrupoUsuario user = (from f in dc.GrupoUsuarios where f.Id == id select f).Single();
            user.Descricao = grupousuario.Descricao;
            user.idAdm = grupousuario.idAdm;
            dc.SubmitChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();

            Models.GrupoUsuario grupoUsuario = (from f in dc.GrupoUsuarios where f.Id == id select f).Single();

            dc.GrupoUsuarios.DeleteOnSubmit(grupoUsuario);

            dc.SubmitChanges();
        }

    }
}
