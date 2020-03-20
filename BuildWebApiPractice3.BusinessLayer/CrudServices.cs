using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BuildWebApiPractice3.BusinessLayer
{
   public class CrudServices
    { // PUT api/values/5
        [HttpPut]
        public void Put(int id, string value)
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
        public void Patch(int id,string value)
        {
            //code here to update some specific values in the existing resource.
        }

    }
}
