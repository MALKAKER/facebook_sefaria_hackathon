using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for GetPhraseNLP
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class GetPhraseNLP : System.Web.Services.WebService
{
    [WebMethod]
    public string ManipulatePhrase(string phrase2Search)
    {
        //NPL CALL

        return "Hello World";
    }

}
