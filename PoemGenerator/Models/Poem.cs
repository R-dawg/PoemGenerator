using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoemGenerator.Models
{
    public class Poem
    {
        public string PoemText { get; set; }
        public DateTime Time { get; set; }

        public Poem()
        {
            PoemText = string.Empty;
            Time = DateTime.Now;
        }
    }
}