using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// Alias Dictionary Items
using ResourceName = System.String;
using ResourceContents = System.String;

namespace TestRazorHTMLTemplate.Utils
{
    public static class EmbeddedResourceUtils
    {
        private static Dictionary<ResourceName, ResourceContents> ResourceDictionary = new Dictionary<ResourceName, ResourceContents>();

        public static string GetAppResource(string resourceName)
        {
            string resourceContents = "";

            try
            {
                if (ResourceDictionary.ContainsKey(resourceName))
                {
                    resourceContents = ResourceDictionary[resourceName];
                    return resourceContents;
                }

                string[] names = Assembly.GetEntryAssembly().GetManifestResourceNames();

                string resource = "";
                foreach (string str in names)
                {
                    if (str.ToLower().Contains(resourceName.ToLower()) == true)
                    {
                        resource = str;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(resource) == false)
                {
                    using (StreamReader sreader = new StreamReader(Assembly.GetEntryAssembly().GetManifestResourceStream(resource), Encoding.Default))
                    {
                        resourceContents = sreader.ReadToEnd();
                    }

                    ResourceDictionary.Add(resourceName, resourceContents);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resourceContents;
        }
    }
}
