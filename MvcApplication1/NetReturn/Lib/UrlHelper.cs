using System;
using System.Web;
using System.Web.Routing;
using System.Collections.Specialized;
using System.IO;
using System.Web.Mvc;

namespace NetReturn.Lib
{
    public static class UrlHelper
    {
        public static string GetURLRoot()
        {
            string host = (HttpContext.Current.Request.Url.IsDefaultPort) ?
                HttpContext.Current.Request.Url.Host :
                HttpContext.Current.Request.Url.Authority;
            host = String.Format("{0}://{1}", HttpContext.Current.Request.Url.Scheme, host);
            return host;
        }

        public static string GetURLAppPath()
        {
            string host = GetURLRoot();
            if (HttpContext.Current.Request.ApplicationPath == "/")
                return host;
            else
                return host + HttpContext.Current.Request.ApplicationPath;
        }

        // Example: Url.Action("action", "controller", Request.QueryString.ToRouteValues(new { id = 0 }));
        public static RouteValueDictionary ToRouteValues(this NameValueCollection col, Object obj)
        {
            var values = obj == null ? new RouteValueDictionary() : new RouteValueDictionary(obj);
            if (col != null)
            {
                foreach (string key in col)
                {
                    // values passed in object override those already in collection
                    if (!values.ContainsKey(key))
                    {
                        values[key] = col[key];
                    }
                }
            }
            return values;
        }

        public static RouteValueDictionary ToRouteValues(this NameValueCollection col)
        {
            return col.ToRouteValues((Object)null);
        }

        public static RouteValueDictionary ToRouteValuesWithCacheBuster(this NameValueCollection col)
        {
            return col.ToRouteValues(new { _dc = Guid.NewGuid().ToString() });
        }

        public static RouteValueDictionary ToRouteValuesWithCacheBuster(this NameValueCollection col, Object obj)
        {
            // NOTE: Your Object must have Properties, NOT fields e.g. with {get;set;} afterwards - see C:\netreturn.co.za\NetReturn\NetReturn\Models\Output\PriceInputsVM.cs
            var ret = col.ToRouteValues(obj);
            ret["_dc"] = Guid.NewGuid().ToString();
            return ret;
        }

        public static string JSScriptWithFileModTime(string src, bool srcHasQueryString)
        {
            string file = HttpContext.Current.Server.MapPath(src);
            FileInfo i = new FileInfo(file);
            if (srcHasQueryString)
            {
                return src + "&_dc=" + i.LastWriteTime.Ticks;
            }
            else
            {
                return src + "?_dc=" + i.LastWriteTime.Ticks;
            }
        }

        public static string JSScriptWithFileModTime(this HtmlHelper h, string src, bool srcHasQueryString)
        {
            return JSScriptWithFileModTime(src, srcHasQueryString);
        }            
    }
}
