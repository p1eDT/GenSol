﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core
{
    public class BaseService
    {
        protected BaseApiClient apiClient;

        public BaseService(string url)
        {
            this.apiClient = new BaseApiClient(url);
        }
    }
}