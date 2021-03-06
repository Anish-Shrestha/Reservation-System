﻿using System.Web.Optimization;
using System.Web.UI;

namespace ReservationSystem.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));
            //typehead
            bundles.Add(new ScriptBundle("~/bundles/typehead").Include("~/Scripts/typeahead.bundle.min.js"));
            //Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/BootStrapJs").Include("~/Scripts/bootstrap.js"));
            //jQuery
            bundles.Add(new ScriptBundle("~/bundles/JQuery").Include("~/Scripts/jquery-1.10.2.js"));
            //jQueryValidate
            bundles.Add(new ScriptBundle("~/bundles/JQueryValidate").Include("~/Scripts/jquery.validate.js"));
            //datePicker
            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include("~/Scripts/bootstrap-datepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/searchPage").Include("~/Scripts/ReservationScripts/search.js"));

            bundles.Add(new Bundle("~/bundles/searchPageStyle").Include(
                         "~/Content/reservation.css",
                         "~/Content/bootstrap.css",
                         "~/Content/datepicker.css"
                         ));
            BundleTable.EnableOptimizations = true;
            // Order is very important for these files to work, they have explicit dependencies
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Use the Development version of Modernizr to develop with and learn from. Then, when you’re
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));

            ScriptManager.ScriptResourceMapping.AddDefinition(
                "respond",
                new ScriptResourceDefinition
                {
                    Path = "~/Scripts/respond.min.js",
                    DebugPath = "~/Scripts/respond.js",
                });
        }
    }
}