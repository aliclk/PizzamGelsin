using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace PizzamGelsin.Classes.ModelBinders
{
    public class PizzaModelBinder : IModelBinder
    {

        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = modelBindingExecutionContext.HttpContext.Request;

            string title = request.Form.Get("Title");
            string day = request.Form.Get("Day");
            string month = request.Form.Get("Month");
            string year = request.Form.Get("Year");
            return true;
        }
    }
}


