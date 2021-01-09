using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoliaIntegration.Model
{
    public class BaseSearch
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string KeyWord { get; set; }
    }
}
