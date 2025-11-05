using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SISPAE.Business;
using SISPAE.Model;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Query; 
using ElmahCore; using ElmahCore;
using ElmahCore;

namespace SISPAE.WebAPI.Controllers.ControllersPartial
{
    //[SwaggerTag("Web API para CRUD de TS_TipoServicio .")]
    //[Route("api/[controller]")]
    //[ApiController] 
    public partial class TP_EnumController: ControllerBase
    {

        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        [Route("[action]")]
        public IActionResult GetEnum(string v)
        {
            try
            {
                TP_Enum result = new TP_Enum();


                if (v.Contains("?") && (v.Contains("=") || v.Contains("%")))
                {
                    var j = v.Substring(0, v.IndexOf("?"));
                    var p = v.Substring(v.IndexOf("?") + 1, (v.Length - v.IndexOf("?") - 1));
                    var va = v.Contains("=") ? (p.Substring(p.IndexOf("=") + 1, p.Length - p.IndexOf("=") - 1)) :
                        (v.Contains("%") ? (p.Substring(p.IndexOf("%") + 1, p.Length - p.IndexOf("%") - 1)) : string.Empty);

                    var c = v.Contains("=") ? p.Substring(0, p.IndexOf("=")) : (v.Contains("%") ? p.Substring(0, p.IndexOf("%")) : string.Empty);


                    if (!string.IsNullOrEmpty(c) && !string.IsNullOrEmpty(va))
                    {
                        result = new TP_EnumMs().GetAllFull().Cast<TP_Enum>().AsQueryable().Where(r => r.Enum.ToLower() == j.ToLower()).FirstOrDefault();

                        if (result != null)
                        {

                            var resParse = JValue.Parse(result.Listado);
                            List<JToken> tokens = resParse.Children().ToList();

                            if (v.Contains("%"))
                            {
                                if (tokens.Any(each => each[c].ToString().ToLower().Contains(va.ToLower())))
                                {
                                    List<JToken> t = tokens.Where(each => each[c.ToLower()].ToString().ToLower().Contains(va.ToLower())).ToList();
                                    return Ok(t);
                                }
                            }

                            if (v.Contains("="))
                            {
                                if (tokens.Any(each => each[c].ToString().ToLower().Equals(va.ToLower())))
                                {
                                    List<JToken> t = tokens.Where(each => each[c].ToString().ToLower().Equals(va.ToLower())).ToList();
                                    return Ok(t);
                                }
                            }
                        }
                        return Ok("[]");
                    }


                    return Ok("[]");
                }
                else
                {
                    result = new TP_EnumMs().GetAllFull().Cast<TP_Enum>().AsQueryable().Where(r => r.Enum.ToLower() == v.ToLower()).FirstOrDefault();
                    if (result != null)
                        return Ok(JValue.Parse(result.Listado));
                    else
                        return Ok("[]");
                }
                //var jsonD = JValue.Parse(result.Listado);
                //return Ok(jsonD);

            }
            catch (System.Exception ex)
            {
                HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }
    }
}
