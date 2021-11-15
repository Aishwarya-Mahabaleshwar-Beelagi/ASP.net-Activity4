using DepartmentDAL;
using DepartmentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBAL
{
   public class DepBL
    {
        public int AddNewDepartment(DepDTO newObj)
        {
            try
            {
                DepDAL dalObj = new DepDAL();
                int result = dalObj.InsertNewDataIntoDepartment(newObj);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
