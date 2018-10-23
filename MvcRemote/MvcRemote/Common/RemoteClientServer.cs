using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MvcRemote.Common
{
    public class RemoteClientServerArrtibute : RemoteAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Type controller = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(type => type.Name.ToLower() == string.Format("{0}Controller", this.RouteData["controller"].ToString()).ToLower());
            if(controller !=null)
            {
                MethodInfo action = controller.GetMethods().FirstOrDefault(method => method.Name.ToLower() == this.RouteData["action"].ToString().ToLower());
                if(action!=null)
                {
                    object instance = Activator.CreateInstance(controller);
                    object response =  action.Invoke(instance, new object[] { value });
                    if(response is JsonResult)
                    {
                        object Jasondata = ((JsonResult)response).Data;
                        if(Jasondata is bool)
                        {
                            return (bool)Jasondata ? ValidationResult.Success :new ValidationResult(this.ErrorMessage) ;
                        }
                    }
                }
            }
            return ValidationResult.Success;
        }

        public RemoteClientServerArrtibute(string routeName) : base(routeName)
        {

        }
        public RemoteClientServerArrtibute(string action, string controller) : base(action, controller)
        {

        }
        public RemoteClientServerArrtibute(string action, string controller, string areaName) : base(action, controller, areaName)
        {

        }

    }
}