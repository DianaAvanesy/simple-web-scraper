using SimpleWebScraper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Workers
{
    class Scraper
    {
        public List<string> Scrape(ScrapeCriteria scrapeCritiria)
        {
            List<string> scrapedElements = new List<string>();

            MatchCollection matches = Regex.Matches(scrapeCritiria.Data, scrapeCritiria.Regex, scrapeCritiria.RegexOption);

            foreach(Match match in matches)
            {
                if (!scrapeCritiria.Parts.Any())
                {
                    scrapedElements.Add(match.Groups[0].Value);
                }
                else
                {
                    foreach (var part in scrapeCritiria.Parts)
                    {
                        Match matchedPart = Regex.Match(match.Groups[0].Value, part.Regex, part.RegexOption);
                        if (matchedPart.Success) scrapedElements.Add(matchedPart.Groups[1].Value);
                    }
                }
            }

            return scrapedElements;
        }
    }
}
