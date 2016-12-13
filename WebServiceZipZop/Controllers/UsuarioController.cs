using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebServiceZipZop.Controllers
{
    public class UsuarioController : ApiController
    {
        Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
        private string foto_path = String.Empty;
        public IEnumerable<Models.Usuario> Get()
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            var r = from f in dc.Usuarios select f;
            return r.ToList();
        }

        // GET api/values/5
        public Models.Usuario Get(int id)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            var r = from f in dc.Usuarios where id == f.Id select f;
            return r as Models.Usuario;
        }

        // POST api/values
        public void Post([FromBody]Models.Usuario usuario)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            dc.Usuarios.InsertOnSubmit(new Models.Usuario() { Nome = usuario.Nome, Foto = usuario.Foto, Uri = usuario.Uri });
            dc.SubmitChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Models.Usuario usuario)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            Models.Usuario user = (from f in dc.Usuarios where f.Id == id select f).Single();
            user.Nome = usuario.Nome;
            user.Foto = usuario.Foto;
            user.Uri = usuario.Uri;
            dc.SubmitChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Models.ZipZopDataContext dc = new Models.ZipZopDataContext();
            Models.Usuario usu = (from f in dc.Usuarios where f.Id == id select f).Single();
            dc.Usuarios.DeleteOnSubmit(usu);
            dc.SubmitChanges();
        }

        private async Task<HttpResponseMessage> PostFormData()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/Fotos");
            var provider = new MultipartFormDataStreamProvider(root);
            //provider.GetLocalFileName(file.Headers)
            try
            {
                // Read the form data.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the file names.
                foreach (MultipartFileData file in provider.FileData)
                {
                    Trace.WriteLine(file.Headers.ContentDisposition.FileName);
                    Trace.WriteLine("Server file path: " + provider.GetLocalFileName(file.Headers));
                    foto_path = provider.GetLocalFileName(file.Headers);
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

    }
}
