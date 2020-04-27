using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Data
{
    class ScrapeCriteriaPart
    {
        public string Regex { get; set; }
        public RagexOptions RagexOption { get; set;}
        public RegexOptions RegexOption { get; internal set; }
    }
}
