using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MultipleFileUpload.Controllers
{
    public class UploadMultipleController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public UploadMultipleController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(IList<IFormFile> files)
        {
            foreach (IFormFile item in files)
            {
                string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                filename = this.EnsureFileName(filename);
                using (FileStream filesteream = System.IO.File.Create(this.Getpath(filename)))
                {

                }
            }

            return this.Content("Success");
        }

        private string EnsureFileName(string filename)
        {
            //throw new NotImplementedException();
            if (filename.Contains("\\"))
            {
                filename = filename.Substring(filename.LastIndexOf("\\" + 1));
            }
            return filename;
        }

        private string Getpath(string filename)
        {
            //throw new NotImplementedException();
            string path = _hostingEnvironment.WebRootPath+ "\\Upload\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path + filename;
        }


    }
}