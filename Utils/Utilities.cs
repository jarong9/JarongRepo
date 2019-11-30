using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.IO;
using System.Data.OleDb;
using System.Xml.Linq;

namespace WSECU
{
    class Utilities
    {
        public IEnumerable<string> LoadXMLdata()
        {
            var filename = "XMLFile1.xml";
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory + @"..\..\Utils\";
            var Filepath = Path.Combine(currentDirectory, filename);
            
            XElement doc = XElement.Load(Filepath);
            IEnumerable<string> query = from login in doc.Descendants("login")
                                        select (string)login.Element("username");
            return query;
        }
    }
}
