﻿/****************************************************************************
*Copyright (c) 2018 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：Microsoft
*命名空间：SAEA.QueueSocket.Net
*文件名： QContext
*版本号： V1.0.0.0
*唯一标识：a2eba85c-13ff-4af2-99a6-ce922847bded
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/3/6 15:51:25
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/3/6 15:51:25
*修改人： yswenli
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using SAEA.Sockets.Interface;
using SAEA.Sockets.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.QueueSocket.Net
{
    class QContext : IContext
    {
        public IUserToken UserToken { get; set; }

        public ICoder Coder { get; set; }

        /// <summary>
        /// 上下文
        /// </summary>
        public QContext()
        {
            this.UserToken = new UserToken();
            this.Coder = new QCoder();
            this.UserToken.Coder = this.Coder;
        }
    }
}
