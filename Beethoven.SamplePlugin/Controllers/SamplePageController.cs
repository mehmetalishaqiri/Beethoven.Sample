using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beethoven.Plugins;
using System.ComponentModel.Composition;
using Beethoven.Plugins.MetaData;

namespace DeepThought.SamplePlugin.Controllers
{
    [Export(typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PluginMetadata(PluginID = "SamplePlugin", PluginName = "Sample Plugin", Version = "1.0", Controller = "SamplePage", OrderNumber = 0)]
    public class SamplePageController : Controller
    {
               
        public ActionResult Index()
        {
            return View();
        }
    }
}
