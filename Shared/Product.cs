using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm_API.Shared
{
    [Serializable]
    public class Product
    {
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; } 
        public int ProductPrice { get; set; }  
    }
}