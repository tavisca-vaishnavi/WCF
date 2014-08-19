using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace assg
{
    public class InputValidation :IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (operationName == "AddEmployee")
            {
                string id = (string)inputs[0];
                id = id.Trim();
                if (id == null || id == "")
                {
                    throw new FaultException(new FaultReason("Id Null Not Allowed"), new FaultCode("104"));
                }
                string name = (string)inputs[1];
                name = name.Trim();
                if (name == null || name == "")
                {
                    throw new FaultException(new FaultReason("Name Null Not Allowed"), new FaultCode("106"));
                }
            }
            if (operationName == "AddRemarks")
            {
                string id = (string)inputs[0];
                id = id.Trim();
                if (id == null || id == "")
                {
                    throw new FaultException(new FaultReason("Id Null Not Allowed"), new FaultCode("104"));
                }
                string remark = (string)inputs[1];
                remark = remark.Trim();
                if (remark == null || remark == "")
                {
                    throw new FaultException(new FaultReason("Remark Null Not Allowed"), new FaultCode("107"));
                }
            }
            if (operationName == "Search")
            {
                string id = (string)inputs[0];
                id = id.Trim();
                if (id == null || id == "")
                {
                    throw new FaultException(new FaultReason("Id Null Not Allowed"), new FaultCode("108"));
                }
            }
            return null;
        }
    }
}