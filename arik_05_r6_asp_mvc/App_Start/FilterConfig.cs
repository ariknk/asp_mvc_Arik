﻿using System.Web;
using System.Web.Mvc;

namespace arik_05_r6_asp_mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
