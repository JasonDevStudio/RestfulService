/*----------------------------------------------------------------
* 项目名称 ：RestfulConsoleService
* 项目描述 ：
* 类 名 称 ：IRestDemoService
* 类 描 述 ：
* 所在的域 ：JASONPC
* 命名空间 ：RestfulConsoleService
* 机器名称 ：JASONPC 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：jiedev
* 创建时间 ：2018-02-11 14:51:12
* 更新时间 ：2018-02-11 14:51:12
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ jiedev 2018. All rights reserved.
*******************************************************************
-----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestfulConsoleService
{
    /// <summary>
    /// IRestDemoService
    /// </summary>
    [ServiceContract(Name = "RestDemoServices")]
    public interface IRestDemoService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/LDS/{id}/{name}", BodyStyle = WebMessageBodyStyle.Bare)]
        string Get(string id, string name);
    }
}
