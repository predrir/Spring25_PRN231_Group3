using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Response
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string RefreshToken { get; set; }
        public int ExpiredTime { get; set; }
        public string AccessToken { get; set; }
    }
}
