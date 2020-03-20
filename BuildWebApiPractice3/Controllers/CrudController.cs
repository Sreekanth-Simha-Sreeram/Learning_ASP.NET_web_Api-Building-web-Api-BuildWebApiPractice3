using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuildWebApiPractice3.Controllers
{
    public class CrudController : ApiController
    {
       

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {

            //code here to update existing resources
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            //code here to delete resources
        }

        [HttpPatch]
        public void Patch(int id, [FromBody]string value)
        {
           //code here to update some specific values in the existing resource.
        }

    }
}
