using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoliaIntegration.Model
{
    public class Departement
    {
        public int Id { get; set; }
        [JsonPropertyAttribute("objectID")]
        public string ObjectId { get; set; }
        public string Name { get; set; }
        public string NewOne { get; set; }
    }
}
