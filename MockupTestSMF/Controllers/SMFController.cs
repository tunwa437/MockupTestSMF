using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MockupTestSMF.Controllers
{
    public class SMFController : ApiController
    {
        [System.Web.Http.HttpPost]
        public HttpResponseMessage SendCommandToND()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            string _responseContent = @"Result is HTTP/1.1 200 OK
Pragma: hop=93:SMFKaraoke.ES05.USMP.0; end=
Set-Cookie: host=0.0.0.0; port=1520; via=SMFKaraoke.E11.0;
session=93
Content-Type: text/xml
Content-Length: 255

<?xml version=""1.0"" standalone="""" ?>
<Session-Id value=""usmp-4-13-0.LKSGG1.PS.TOT3G.NET;1317981590;57"" />
<Origin-Realm value=""sand.ais.co.th"" />
<Result-Code value=""2000"" />
<Origin-Host value=""PBESRFC801.sand.ais.co.th"" />
<Origin-State-Id value=""0"" />

Result-Code value=""2000"" ";


            response.Content = new StringContent(_responseContent, Encoding.UTF8, "text/xml");

            return response;
        }
    }
}