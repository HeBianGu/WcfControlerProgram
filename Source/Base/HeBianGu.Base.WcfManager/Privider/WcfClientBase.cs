﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) 长虹智慧健康有限公司, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[李海军]   时间：2018/5/22 16:43:00 
 * 文件名：Class1 
 * 说明：
 * 
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Base.WcfManager
{
    public class WcfClientBase
    {
        private string _ip;
        /// <summary> 说明 </summary>
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private string _port;
        /// <summary> 说明 </summary>
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }
    }
}
