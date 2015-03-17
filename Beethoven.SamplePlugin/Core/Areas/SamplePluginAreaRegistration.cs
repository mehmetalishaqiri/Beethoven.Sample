/*
 * DeepThought.SamplePlugin
 * 
 * Written for .NET 4.0 in C#
 * 
 * Copyright (C) 2009, 2010, 2011. All Right Reserved, Spartansoft L.L.C.
 * http://spartansoft.org
 * 
 * Proprietary and Confidential information of Spartansoft L.L.C. 
 * Redistribution and use in source and binary forms, with or without modification, 
 * without the authorization of Spartansoft L.L.C.  is prohibited. * 
 * 
 * "Whatever happens SPARTAN's code must stand ... or at least crash responsibly."
 *  
 * File Name: SamplePluginAreaRegistration.cs
 * 
 * File Authors:
 * 		Mehmetali N. Shaqiri, m.shaqiri@spartansoft.org
 * 
 * Date Created:
 *      31.07.2011 06:32 PM
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.Composition;

namespace Beethoven.SamplePlugin.Core.Areas
{
    [Export(typeof(AreaRegistration))]
    public class SamplePluginAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SamplePlugin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            
            context.MapRoute(
                "SamplePlugin_default",
                "SamplePlugin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
            
            
        }
    }
}