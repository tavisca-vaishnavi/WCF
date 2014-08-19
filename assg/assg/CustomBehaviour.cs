using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace assg
{
    public class CustomBehaviour:BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ValidationBehaviour); }
        }

        protected override object CreateBehavior()
        {
            return new ValidationBehaviour();
        }
    }
    }