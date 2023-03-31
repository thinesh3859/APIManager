﻿using System.Collections;
using System.Net;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIManager.Models
{
    public class FunctionTrigger
    {
        public Outputenum TestMethod() {

            Outputenum oe = new Outputenum();
            List<Hashtable> lht = new List<Hashtable>();   
            Hashtable   ht = new Hashtable();

            ht.Add("Test", "method 1");
            lht.Add(ht);

            oe.STATUS = "S";
            oe.StatusMessage = "SUCCESS";
            oe.output = lht;

            return oe;
        }

        public Outputenum TestMethod1()
        {

            Outputenum oe = new Outputenum();
            List<Hashtable> lht = new List<Hashtable>();
            Hashtable ht = new Hashtable();

            ht.Add("Test", "Method 2");
            lht.Add(ht);

            oe.STATUS = "S";
            oe.StatusMessage = "SUCCESS";
            oe.output = lht;

            return oe;
        }

    }
}
