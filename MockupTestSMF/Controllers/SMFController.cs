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
            string _responseContent = @"<?xml version=""1.0"" standalone="""" ?>
<Session-Id value=""usmp-4-13-0.LKSGG1.PS.TOT3G.NET;1317981590;57"" />
<Origin-Realm value=""sand.ais.co.th"" />
<Origin-State-Id value=""0"" />
<Origin-Host value=""PBESRFC801.sand.ais.co.th"" />
<Result-Code value=""2000"" />";


            response.Content = new StringContent(_responseContent, Encoding.UTF8, "text/xml");

            return response;
        }
    }
}