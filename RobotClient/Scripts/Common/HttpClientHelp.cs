using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;


public class HttpClientHelper
{
    private static readonly object LockObj = new object();
    private static HttpClient client = null;
    public HttpClientHelper()
    {
        GetClienInstance();
    }

    private static HttpClient GetClienInstance()
    {

        if (client == null)
        {
            lock (LockObj)
            {
                if (client == null)
                {
                    client = new HttpClient();

                    ServicePointManager.SecurityProtocol |=
                    SecurityProtocolType.Tls12 |
                    SecurityProtocolType.Tls11 |
                    SecurityProtocolType.Tls; // comparable to modern browsers

                    //超时时间10秒
                    client.Timeout = TimeSpan.FromSeconds(10);
                }
            }
        }
        return client;
    }
    public async Task<string> PostAsync(string url, string strJson)//post异步请求方法
    {
        try
        {
            HttpContent content = new StringContent(strJson);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //由HttpClient发出异步Post请求
            HttpResponseMessage res = await client.PostAsync(url, content);
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string str = res.Content.ReadAsStringAsync().Result;
                return str;
            }
            else
                return null;
        }
        catch (Exception ex)
        {
            GameLog.Log("-- HttpClientHelper.PostAsync ---ex:" + ex);
            return null;
        }
    }

    public string Post(string url, string strJson)//post同步请求方法
    {
        try
        {
            HttpContent content = new StringContent(strJson);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //client.DefaultRequestHeaders.Connection.Add("keep-alive");
            //由HttpClient发出Post请求
            Task<HttpResponseMessage> res = client.PostAsync(url, content);
            if (res.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string str = res.Result.Content.ReadAsStringAsync().Result;
                return str;
            }
            else
                return null;
        }
        catch (Exception ex)
        {
            GameLog.Log("-- HttpClientHelper.Post ---ex:" + ex);
            return null;
        }
    }

    public string Get(string url) //get同步方法
    {
        try
        {
            var responseString = client.GetStringAsync(url);
            return responseString.Result;
        }
        catch (Exception ex)
        {
            GameLog.Log("-- HttpClientHelper.Get ---ex:" + ex);
            return null;
        }
    }

    public async Task<string> GetAsync(string url)//get异步请求方法
    {
        try
        {
            //由HttpClient发出异步Get请求
            HttpResponseMessage res = await client.GetAsync(url);
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string str = res.Content.ReadAsStringAsync().Result;
                return str;
            }
            else
                return null;
        }
        catch (Exception ex)
        {
            GameLog.Log("-- HttpClientHelper.GetAsync ---ex:" + ex);
            return null;
        }
    }
}

