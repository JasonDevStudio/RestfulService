/*----------------------------------------------------------------
* 项目名称 ：RestfulConsoleService
* 项目描述 ：
* 类 名 称 ：RestDemoService
* 类 描 述 ：
* 所在的域 ：JASONPC
* 命名空间 ：RestfulConsoleService
* 机器名称 ：JASONPC 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：jiedev
* 创建时间 ：2018-02-11 14:56:21
* 更新时间 ：2018-02-11 14:56:21
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ jiedev 2018. All rights reserved.
*******************************************************************
-----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RestfulConsoleService
{
    /// <summary>
    /// RestDemoService
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestDemoService : IRestDemoService
    {
        private HttpResponseMessage GetMsg(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(json, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }


        public string Get(string id, string name)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("id : {0}", id);
            sb.AppendLine();
            sb.AppendFormat("name : {0}", name);
            sb.AppendLine();

            var hostname = System.Net.Dns.GetHostName();
            var addrs = System.Net.Dns.GetHostAddresses(hostname);

            foreach (var item in addrs)
            {
                sb.AppendFormat("IP:{0}", item.ToString());
                sb.AppendLine();
            }

            return GetMsg(sb.ToString());
        }
    }
}
