﻿/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCMS.Framework.Core.Network
{
    public class ApiResponse
    {
        public ApiResponse() { }
        public ApiResponse(bool isSuccess, string message, object data = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public string Message{ get; set; }
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
    }
}
