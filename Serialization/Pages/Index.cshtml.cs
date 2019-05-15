using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serialization.Data;

namespace Serialization.Pages
{
    public class IndexModel : PageModel
    {
        public DataClassA DataObjA { get; set; }
        public string DataObjASerilized { get; private set; }

        public void OnGet()
        {
            DataObjA = new DataClassA
            {
                NameField = "NameField",
                LongNameField = "LongNameField",
                NumericField = 42,
                BooleanField = true
            };

            DataObjASerilized = JsonConvert.SerializeObject(
                DataObjA,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }
                );
        }
    }
}