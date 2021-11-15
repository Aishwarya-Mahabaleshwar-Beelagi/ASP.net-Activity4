using DepartmentBAL;
using DepartmentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DepartmentWebApp.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage AddNewDepartment(DepDTO newDeptObj)
        {
            try
            {
                if (newDeptObj != null)
                {
                    DepBL blObj = new DepBL();
                    int result = blObj.AddNewDepartment(newDeptObj);
                    if (result == 1)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Department added successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Department not added");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for department");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
    }
}
