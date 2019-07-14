using SomeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestRazorHTMLTemplate.Model;
using TestRazorHTMLTemplate.Utils;

namespace TestRazorHTMLTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailReport();
            StarWarsReport();
        }

        static void EmailReport()
        {
            try
            {
                // Step 00:  Setup Data
                EmailReport data = new EmailReport();
                data.ReportName = "Some Report";
                data.Version = 2;
                data.Problems.Add("wibble thing needs fixing");
                data.Problems.Add("thingy-ma-bop needs straightening");
                data.Problems.Add("doobery needs inverting");

                // Step 01: Load HTML Template From embedded resource
                var htmlTemplate = EmbeddedResourceUtils.GetAppResource("EmailReport.cshtml");

                // Step 02: Generate HTML Contents
                var htmlReport = new RazorGenerator(htmlTemplate, data).Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} - {MethodBase.GetCurrentMethod().Name}");
            }
        }

        static void StarWarsReport()
        {
            try
            {
                var data = FetchStarWarsCharacters.Get();

                // Step 03: Load HTML Template
                var htmlTemplate = EmbeddedResourceUtils.GetAppResource("StarWars.cshtml");



                // Step 04: Generate HTML Contents
              
                var htmlReport = new RazorGenerator(htmlTemplate, data).Run();

               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} - {MethodBase.GetCurrentMethod().Name}");
            }
        }
    }
}
