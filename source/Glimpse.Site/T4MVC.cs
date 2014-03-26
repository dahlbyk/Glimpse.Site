﻿// <auto-generated />
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
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly apiClass s_api = new apiClass();
    public static apiClass api { get { return s_api; } }
    static readonly VersionClass s_Version = new VersionClass();
    public static VersionClass Version { get { return s_Version; } }
    public static Glimpse.Site.Controllers.CommunityController Community = new Glimpse.Site.Controllers.T4MVC_CommunityController();
    public static Glimpse.Site.Controllers.ErrorController Error = new Glimpse.Site.Controllers.T4MVC_ErrorController();
    public static Glimpse.Site.Controllers.ExtensionsController Extensions = new Glimpse.Site.Controllers.T4MVC_ExtensionsController();
    public static Glimpse.Site.Controllers.GettingStartedController GettingStarted = new Glimpse.Site.Controllers.T4MVC_GettingStartedController();
    public static Glimpse.Site.Controllers.HelpController Help = new Glimpse.Site.Controllers.T4MVC_HelpController();
    public static Glimpse.Site.Controllers.HomeController Home = new Glimpse.Site.Controllers.T4MVC_HomeController();
    public static Glimpse.Site.Controllers.InstallController Install = new Glimpse.Site.Controllers.T4MVC_InstallController();
    public static Glimpse.Site.Controllers.StatusController Status = new Glimpse.Site.Controllers.T4MVC_StatusController();
    public static T4MVC.DocsController Docs = new T4MVC.DocsController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class apiClass
    {
        public readonly string Name = "api";
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class VersionClass
    {
        public readonly string Name = "Version";
        public Glimpse.Site.Areas.Version.Controllers.AdminController Admin = new Glimpse.Site.Areas.Version.Controllers.T4MVC_AdminController();
        public Glimpse.Site.Areas.Version.Controllers.CheckController Check = new Glimpse.Site.Areas.Version.Controllers.T4MVC_CheckController();
        public Glimpse.Site.Areas.Version.Controllers.InstallController Install = new Glimpse.Site.Areas.Version.Controllers.T4MVC_InstallController();
        public T4MVC.Version.SharedController Shared = new T4MVC.Version.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_2_1_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.0.intellisense.min.js") ? Url("jquery-2.1.0.intellisense.min.js") : Url("jquery-2.1.0.intellisense.js");
        public static readonly string jquery_2_1_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.0.min.js") ? Url("jquery-2.1.0.min.js") : Url("jquery-2.1.0.js");
        public static readonly string jquery_2_1_0_min_js = Url("jquery-2.1.0.min.js");
        public static readonly string jquery_2_1_0_min_map = Url("jquery-2.1.0.min.map");
        public static readonly string site_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/site.min.js") ? Url("site.min.js") : Url("site.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Contributors {
            private const string URLPATH = "~/Content/Contributors";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string pic1_jpg = Url("pic1.jpg");
            public static readonly string pic10_jpg = Url("pic10.jpg");
            public static readonly string pic11_jpg = Url("pic11.jpg");
            public static readonly string pic12_jpg = Url("pic12.jpg");
            public static readonly string pic2_jpg = Url("pic2.jpg");
            public static readonly string pic3_jpg = Url("pic3.jpg");
            public static readonly string pic4_jpg = Url("pic4.jpg");
            public static readonly string pic5_jpg = Url("pic5.jpg");
            public static readonly string pic6_jpg = Url("pic6.jpg");
            public static readonly string pic7_jpg = Url("pic7.jpg");
            public static readonly string pic8_jpg = Url("pic8.jpg");
            public static readonly string pic9_jpg = Url("pic9.jpg");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Fonts {
            private const string URLPATH = "~/Content/Fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string ArchitectsDaughter_ttf = Url("ArchitectsDaughter.ttf");
            public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
            public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
            public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
            public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
        }
    
        public static readonly string footer_mountains_png = Url("footer-mountains.png");
        public static readonly string footer_tower_build_png = Url("footer-tower-build.png");
        public static readonly string footer_tower_png = Url("footer-tower.png");
        public static readonly string founders_png = Url("founders.png");
        public static readonly string glimpseTeam_json = Url("glimpseTeam.json");
        public static readonly string home_plugins_jpg = Url("home-plugins.jpg");
        public static readonly string logo_long_white_png = Url("logo-long-white.png");
        public static readonly string packages_json = Url("packages.json");
        public static readonly string pager_sprite_png = Url("pager-sprite.png");
        public static readonly string screenshot_hud_ajax_gif = Url("screenshot-hud-ajax.gif");
        public static readonly string screenshot_hud_http_gif = Url("screenshot-hud-http.gif");
        public static readonly string screenshot_hud_server_gif = Url("screenshot-hud-server.gif");
        public static readonly string screenshot_hud_gif = Url("screenshot-hud.gif");
        public static readonly string screenshot_hud_png = Url("screenshot-hud.png");
        public static readonly string screenshot_preview_gif = Url("screenshot-preview.gif");
        public static readonly string screenshot_wing_data_gif = Url("screenshot-wing-data.gif");
        public static readonly string screenshot_wing_data_png = Url("screenshot-wing-data.png");
        public static readonly string screenshot_wing_timeline_gif = Url("screenshot-wing-timeline.gif");
        public static readonly string screenshot_wing_timeline_png = Url("screenshot-wing-timeline.png");
        public static readonly string screenshot_jpg = Url("screenshot.jpg");
        public static readonly string screenshot_bar_gif = Url("screenshot_bar.gif");
        public static readonly string screenshot_main_jpg = Url("screenshot_main.jpg");
        public static readonly string screenshot_panel_gif = Url("screenshot_panel.gif");
        public static readonly string screenshot_popup_gif = Url("screenshot_popup.gif");
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
        public static readonly string whats_new_1_jpg = Url("whats-new-1.jpg");
        public static readonly string whats_new_2_jpg = Url("whats-new-2.jpg");
        public static readonly string whats_new_3_jpg = Url("whats-new-3.jpg");
        public static readonly string whats_new_4_jpg = Url("whats-new-4.jpg");
        public static readonly string whats_new_5_jpg = Url("whats-new-5.jpg");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


