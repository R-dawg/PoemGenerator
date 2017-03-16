using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoemGenerator.Models
{
    public class Rule
    {
        public int Count { get; set; }
        public string Entry { get; set; }
        public string RuleFile { get; set; }

        public Rule()
        {
            Count = 0;
            Entry = "POEM";
            RuleFile = "No rules defined";
        }
    }
}