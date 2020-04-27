using System;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Data
{
    internal class RagexOptions
    {
        public static implicit operator RegexOptions(RagexOptions v)
        {
            throw new NotImplementedException();
        }
    }
}