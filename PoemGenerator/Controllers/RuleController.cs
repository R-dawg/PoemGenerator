using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PoemGenerator.Models;
using System.Collections;
using System.Text;

namespace PoemGenerator.Controllers
{
    public class RuleController : ApiController
    {
        Rule ruleInput = new Rule();
        Poem[] poems = new Poem[] { };
        StringBuilder rules = new StringBuilder();
        int count;
        string entry;
        string ruleFile;


        // GET: api/Rule
        public Rule Get()
        {
            return ruleInput;
        }

        // GET: api/Rule/5
        public IHttpActionResult Get(int rules)
        {

            //if (rules == null)
            //{
            //    return NotFound();
            //}

            return Ok(ruleInput);
        }

        // POST: api/Rule
        public IEnumerable<Poem> Post([FromBody]string value)
        {
            List<Poem> poemList = poems.ToList<Poem>();

            //for (int i = 0; i < ruleInput.Count; i++)
            //{
                // find entry point in RuleFile
                Poem newPoem = new Poem();
            newPoem.PoemText = ruleInput.RuleFile.Substring(ruleInput.RuleFile.IndexOf(":"), 10); // findEntry(ruleInput.Entry, ruleInput.RuleFile).ToString();
                poemList.Add(newPoem);
                poems = poemList.ToArray();
            //}

            return poems;
        }

        // PUT: api/Rule
        public Rule Put([FromBody]Rule newRules)
        {
            

            if (newRules != null)
            {
                count = newRules.Count;
                entry = newRules.Entry;
                ruleFile = newRules.RuleFile;

                ruleInput.Count = count;
                ruleInput.Entry = entry;
                ruleInput.RuleFile = ruleFile;

                
            }


            return ruleInput;
        }

        // DELETE: api/Rule/5
        public void Delete(int id)
        {
        }

        public int findEntry(string entry, string ruleFile)
        {
            return ruleFile.IndexOf(entry + ":");
        }
    }
}
