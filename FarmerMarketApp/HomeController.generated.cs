// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace FarmerMarketApp.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ShowResults()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShowResults);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ShowSingleResult()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShowSingleResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Search = "Search";
            public readonly string ShowResults = "ShowResults";
            public readonly string ShowSingleResult = "ShowSingleResult";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Search = "Search";
            public const string ShowResults = "ShowResults";
            public const string ShowSingleResult = "ShowSingleResult";
        }


        static readonly ActionParamsClass_ShowResults s_params_ShowResults = new ActionParamsClass_ShowResults();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ShowResults ShowResultsParams { get { return s_params_ShowResults; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ShowResults
        {
            public readonly string distance = "distance";
            public readonly string x = "x";
            public readonly string y = "y";
        }
        static readonly ActionParamsClass_ShowSingleResult s_params_ShowSingleResult = new ActionParamsClass_ShowSingleResult();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ShowSingleResult ShowSingleResultParams { get { return s_params_ShowSingleResult; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ShowSingleResult
        {
            public readonly string x = "x";
            public readonly string y = "y";
        }
        static readonly ActionParamsClass_Search s_params_Search = new ActionParamsClass_Search();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Search SearchParams { get { return s_params_Search; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Search
        {
            public readonly string model = "model";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
                public readonly string Search = "Search";
                public readonly string ShowResults = "ShowResults";
            }
            public readonly string Index = "~/Views/Home/Index.cshtml";
            public readonly string Search = "~/Views/Home/Search.cshtml";
            public readonly string ShowResults = "~/Views/Home/ShowResults.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : FarmerMarketApp.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        partial void SearchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Search()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
            SearchOverride(callInfo);
            return callInfo;
        }

        partial void ShowResultsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, double distance, double x, double y);

        public override System.Web.Mvc.ActionResult ShowResults(double distance, double x, double y)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShowResults);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "distance", distance);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "x", x);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "y", y);
            ShowResultsOverride(callInfo, distance, x, y);
            return callInfo;
        }

        partial void ShowSingleResultOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, double x, double y);

        public override System.Web.Mvc.ActionResult ShowSingleResult(double x, double y)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShowSingleResult);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "x", x);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "y", y);
            ShowSingleResultOverride(callInfo, x, y);
            return callInfo;
        }

        partial void SearchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, FarmerMarketApp.Models.SearchInput model);

        public override System.Web.Mvc.ActionResult Search(FarmerMarketApp.Models.SearchInput model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SearchOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591