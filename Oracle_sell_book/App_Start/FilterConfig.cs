﻿using System.Web;
using System.Web.Mvc;

namespace Oracle_sell_book
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
