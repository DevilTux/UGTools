using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;
using UGTools.Entity;


namespace UGTools.BusinessLogic
{
    public class CheckAccountBll
    {
        public static CheckAccountBll Intance
        {
            get { return new CheckAccountBll(); }
        }

        private static bool AllowSsl(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
        #region AE

        public bool CheckAe(Account account)
        {
            var request =
                (HttpWebRequest)
                WebRequest.Create("https://m.ae.com/web/flat/account_login.jsp?");

            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.Host = "m.ae.com";
            request.Referer = "	https://m.ae.com/web/flat/account_login.jsp";
            request.UserAgent = "Mozilla/5.0 (iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en-us) AppleWebKit/528.18 (KHTML, like Gecko) Version/4.0 Mobile/7A341 Safari/528.16";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Method = "POST";
            //request.Headers.Add("X-Requested-With","XMLHttpRequest");

            /*var rparam = new StringBuilder();
            rparam.AppendFormat("{0}={1}&", "/atg/userprofiling/ProfileFormHandler.ajaxErrorURL",
                                "/profile/login_status.jsp");
            rparam.AppendFormat("{0}={1}&", "/atg/userprofiling/ProfileFormHandler.ajaxSuccessURL",
                                "/profile/login_status.jsp");
            rparam.AppendFormat("{0}={1}&", "/atg/userprofiling/ProfileFormHandler.login", "Sign In");
            rparam.AppendFormat("{0}={1}&", "/atg/userprofiling/ProfileFormHandler.loginErrorURL",
                                "https://m.ae.com/web/flat/account_login.jsp?");
            rparam.AppendFormat("{0}={1}&", "/atg/userprofiling/ProfileFormHandler.loginSuccessURL",
                                "	https://m.ae.com/web/myaccount/account_home.jsp");
            rparam.AppendFormat("{0}={1}&", "/atg/userprofiling/ProfileFormHandler.mobileAppLogin", "false");
            rparam.AppendFormat("{0}={1}&", "77kidsFan", "");
            rparam.AppendFormat("{0}={1}&", "_D:/atg/userprofiling/ProfileFormHandler.ajaxErrorURL", "");
            rparam.AppendFormat("{0}={1}&", "_D:/atg/userprofiling/ProfileFormHandler.ajaxSuccessURL", "");
            rparam.AppendFormat("{0}={1}&", "_D:/atg/userprofiling/ProfileFormHandler.login", "");
            rparam.AppendFormat("{0}={1}&", "_D:/atg/userprofiling/ProfileFormHandler.loginErrorURL", "");
            rparam.AppendFormat("{0}={1}&", "_D:/atg/userprofiling/ProfileFormHandler.loginSuccessURL", "");
            rparam.AppendFormat("{0}={1}&", "_D:/atg/userprofiling/ProfileFormHandler.mobileAppLogin", "");
            rparam.AppendFormat("{0}={1}&", "_D:77kidsFan", "");
            rparam.AppendFormat("{0}={1}&", "_D:aeAccountPass", "");
            rparam.AppendFormat("{0}={1}&", "_D:aerieFan", "");
            rparam.AppendFormat("{0}={1}&", "_D:email", "");
            rparam.AppendFormat("{0}={1}&", "_D:uid", "");
            rparam.AppendFormat("{0}={1}&", "_D:webFan", "");
<<<<<<< HEAD
            rparam.AppendFormat("{0}={1}&", "_DARGS","/web/modals/account_login.jsp.loginForm");
            rparam.AppendFormat("{0}={1}&", "_dynSessConf", "");
=======
            rparam.AppendFormat("{0}={1}&", "_DARGS", "/web/modals/account_login.jsp.loginForm");
            rparam.AppendFormat("{0}={1}&", "_dynSessConf", "-4569140505887473964");
>>>>>>> 11062013
            rparam.AppendFormat("{0}={1}&", "_dyncharset", "UTF-8");
            rparam.AppendFormat("{0}={1}&", "aeAccountPass", account.Password);
            rparam.AppendFormat("{0}={1}&", "aerieFan", "");
            rparam.AppendFormat("{0}={1}&", "email", account.Username);
            rparam.AppendFormat("{0}={1}&", "uid", "");
            rparam.AppendFormat("{0}={1}&", "validationFormSelector", "#loginForm");
            rparam.AppendFormat("{0}={1}", "webFan", "");*/

            var rparam = new StringBuilder();
            //rparam.AppendFormat(
            //    "_dyncharset=UTF-8&_dynSessConf=-3338567754042778951&%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginErrorURL=https%3A%2F%2Fm.ae.com%2Fweb%2Fflat%2Faccount_login.jsp%3F&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginErrorURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginSuccessURL=https%3A%2F%2Fm.ae.com%2Fweb%2Fmyaccount%2Faccount_home.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginSuccessURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxErrorURL=%2Fprofile%2Flogin_status.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxErrorURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxSuccessURL=%2Fprofile%2Flogin_status.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxSuccessURL=+&uid=&_D%3Auid=+&webFan=&_D%3AwebFan=+&aerieFan=&_D%3AaerieFan=+&77kidsFan=&_D%3A77kidsFan=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.mobileAppLogin=false&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.mobileAppLogin=+&email={0}&_D%3Aemail=+&aeAccountPass={1}&_D%3AaeAccountPass=+&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.login=+&_DARGS=%2Fweb%2Fmodals%2Faccount_login.jsp.loginForm&%2Fatg%2Fuserprofiling%2FProfileFormHandler.login=Sign+In&validationFormSelector=%23loginForm",account.Username,account.Password);
            //dadasdasd%40asdasd.com
            //adsadadasd
            rparam.Append(
                "_dyncharset=UTF-8&_dynSessConf=-3338567754042778951&%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginErrorURL=https%3A%2F%2Fm.ae.com%2Fweb%2Fflat%2Faccount_login.jsp%3F&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginErrorURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginSuccessURL=https%3A%2F%2Fm.ae.com%2Fweb%2Fmyaccount%2Faccount_home.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginSuccessURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxErrorURL=%2Fprofile%2Flogin_status.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxErrorURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxSuccessURL=%2Fprofile%2Flogin_status.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxSuccessURL=+&uid=&_D%3Auid=+&webFan=&_D%3AwebFan=+&aerieFan=&_D%3AaerieFan=+&77kidsFan=&_D%3A77kidsFan=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.mobileAppLogin=false&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.mobileAppLogin=+&email={0}&_D%3Aemail=+&aeAccountPass=qwer1234&_D%3AaeAccountPass=+&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.login=+&_DARGS=%2Fweb%2Fmodals%2Faccount_login.jsp.loginForm&%2Fatg%2Fuserprofiling%2FProfileFormHandler.login=Sign+In&validationFormSelector=%23loginForm");
            request.Credentials = CredentialCache.DefaultCredentials;
            ServicePointManager.ServerCertificateValidationCallback += AllowSsl;

            var buffer = Encoding.UTF8.GetBytes(rparam.ToString());
            request.ContentLength = buffer.Length;
            var stream = request.GetRequestStream();
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                stream = response.GetResponseStream();
                var responseStr = string.Empty;
                using (var reader = new StreamReader(stream))
                {
                    responseStr = reader.ReadToEnd();
                }

                var resultStr = Regex.Match(responseStr, @"(?<=""errorList"":\[)(.*)(?=\])").Value;
                var result = string.IsNullOrEmpty(resultStr);
                return result;
            }
            catch (WebException exception)
            {
                using (WebResponse response = exception.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (Stream data = response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                        var resultStr = Regex.Match(text, @"(?<=""errorList"":\[)(.*)(?=\])").Value;
                        var result = string.IsNullOrEmpty(resultStr);
                        return result;
                    }
                }
            }
            
        }

        public bool CheckAe2(Account account)
        {
            var request = WebRequest.Create("https://mc.ae.com/web/flat/account_login.jsp") as HttpWebRequest;
            if (request!=null)
            {
                request.Accept = "application/json, text/javascript, */*; q=0.01";
                //request.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.3");
                //request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                //request.Headers.Add("Accept-Language", "en-US,en;q=0.8");
                //request.Headers.Add("Origin", "https://mc.ae.com");
                //request.Headers.Add("X-Requested-With", "XMLHttpRequest");

                request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                //contentlength
                //cookie
                request.Host = "mc.ae.com";

                request.Referer = "https://mc.ae.com/web/flat/account_login.jsp";
                request.UserAgent =
                    "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.31 (KHTML, like Gecko) Chrome/26.0.1410.64 Safari/537.31";

                var param =
                    string.Format(
                        "_dyncharset=UTF-8&_dynSessConf=-5897317348448775144&%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginErrorURL=https%3A%2F%2Fmc.ae.com%2Fweb%2Fflat%2Faccount_login.jsp%3F&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginErrorURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginSuccessURL=https%3A%2F%2Fmc.ae.com%2Fweb%2Fmyaccount%2Faccount_home.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.loginSuccessURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxErrorURL=%2Fprofile%2Flogin_status.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxErrorURL=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxSuccessURL=%2Fprofile%2Flogin_status.jsp&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.ajaxSuccessURL=+&uid=&_D%3Auid=+&webFan=&_D%3AwebFan=+&aerieFan=&_D%3AaerieFan=+&77kidsFan=&_D%3A77kidsFan=+&%2Fatg%2Fuserprofiling%2FProfileFormHandler.mobileAppLogin=false&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.mobileAppLogin=+&email={0}&_D%3Aemail=+&aeAccountPass={1}&_D%3AaeAccountPass=+&_D%3A%2Fatg%2Fuserprofiling%2FProfileFormHandler.login=+&_DARGS=%2Fweb%2Fmodals%2Faccount_login.jsp.loginForm&%2Fatg%2Fuserprofiling%2FProfileFormHandler.login=Sign+In&validationFormSelector=%23loginForm", HttpUtility.UrlEncode(account.Username),HttpUtility.UrlEncode(account.Password));
                var buffer = Encoding.UTF8.GetBytes(param);
                //var buffer = GetBytes(param);
                request.ContentLength = buffer.Length;

                var requestStream = request.GetRequestStream();
                requestStream.Write(buffer,0,buffer.Length);

                var response = request.GetResponse();
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream!=null)
                    {
                        var reader = new StreamReader(responseStream);
                        var responseString = reader.ReadToEnd();
                    }

                }



            }
            return true;
        }
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        #endregion

        #region BedBath
/*

        public bool CheckBedBath(Account account)
        {
            var request = (HttpWebRequest) WebRequest.Create("https://www.bedbathandbeyond.com/login.asp?bvprodurl=&");

            request.Host = "www.bedbathandbeyond.com";
            request.Referer = "https://www.bedbathandbeyond.com/Login.asp?";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:20.0) Gecko/20100101 Firefox/20.0";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,#1#*;q=0.8";
            request.Method = "POST";

            var rparam = new StringBuilder();
            var random = new Random();
            var xtoken = string.Empty;
            var cookieCollection = GetBedBathToken(out xtoken);
            //var cookie = new CookieContainer();
            //cookie.Add(new Uri("www.bedbathandbeyond.com"),new Cookie("xtoken",xtoken));
            var cookie = new CookieContainer();

            cookie.Add(cookieCollection);
            request.CookieContainer = cookie;

            rparam.AppendFormat("{0}={1}&", "Submit.x", random.Next(1, 69));
            rparam.AppendFormat("{0}={1}&", "Submit.y", random.Next(1, 24));
            rparam.AppendFormat("{0}={1}&", "email", account.Username);
            rparam.AppendFormat("{0}={1}&", "loginType", "");
            rparam.AppendFormat("{0}={1}&", "mode", "submitLogin");
            rparam.AppendFormat("{0}={1}&", "password", account.Password);
            rparam.AppendFormat("{0}={1}&", "ret", "default.asp");
            rparam.AppendFormat("{0}={1}&", "retarg", "");
            rparam.AppendFormat("{0}={1}", "xtoken", xtoken);

            var buffer = Encoding.UTF8.GetBytes(rparam.ToString());
            request.ContentLength = buffer.Length;
            var stream = request.GetRequestStream();
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();

            var response = (HttpWebResponse) request.GetResponse();
            stream = response.GetResponseStream();
            var responseStr = string.Empty;
            using (var reader = new StreamReader(stream))
            {
                responseStr = reader.ReadToEnd();
            }
            if (response.StatusCode == HttpStatusCode.MovedPermanently)
            {
                return true;
            }

            return false;
        }

        private string GetBedBathToken()
        {
            var httpRequest = (HttpWebRequest) WebRequest.Create("https://www.bedbathandbeyond.com/login.asp");

            var token = string.Empty;
            var httpResponse = (HttpWebResponse) httpRequest.GetResponse();
            var responseStream = httpResponse.GetResponseStream();

            if (responseStream != null)
            {
                var result = new StringBuilder();
                const int bufferSize = 16384;

                var fileContents = new byte[bufferSize];
                var count = bufferSize;

                while (count > 0)
                {
                    count = responseStream.Read(fileContents, 0, bufferSize);
                    result.Append(Encoding.UTF8.GetString(fileContents));
                }
                //token = Regex.Match(result.ToString(), "(?<=<input *type=\"hidden\" *value=\")(.*)(?=\" *name=\"xtoken\">)").Value;
                token =
                    Regex.Match(result.ToString(), "(?<=<input.*name=\"xtoken\".*value=\")(.*)(?=\"></input>)").Value;
            }
            return token;
        }

        private CookieCollection GetBedBathToken(out string xtoken)
        {
            var httpRequest = (HttpWebRequest) WebRequest.Create("https://www.bedbathandbeyond.com/login.asp");
            httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,#1#*;q=0.8";
            httpRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            httpRequest.Headers.Add("Accept-Language", "en-US,en;q=0.5");
            httpRequest.Host = "www.bedbathandbeyond.com";
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:20.0) Gecko/20100101 Firefox/20.0";
            //httpRequest.Connection = "keep-alive";
            httpRequest.Method = "GET";
            httpRequest.CookieContainer = new CookieContainer();

            xtoken = string.Empty;
            var httpResponse = (HttpWebResponse) httpRequest.GetResponse();

            var cookieCollection = httpResponse.Cookies;
            if (cookieCollection.Count > 0)
            {
                if (cookieCollection["xtoken"] != null)
                {
                    xtoken = cookieCollection["xtoken"].Value;
                }
            }
            return cookieCollection;
        }
*/

        #endregion

    }
}
