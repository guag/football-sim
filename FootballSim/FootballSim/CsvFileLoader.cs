using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace FootballSim.Models
{
    public class CsvFileLoader : ICsvFileLoader
    {
        private const string FirstNamesFileName = "fn.csv";
        private const string LastNamesFileName = "ln.csv";
        private const string CollegesFileName = "col.csv";
        private const string CitiesFileName = "loc.csv";

        #region ICsvFileLoader Members

        public IList<string> FirstNames
        {
            get { return ReadFile(FirstNamesFileName); }
        }

        public IList<string> LastNames
        {
            get { return ReadFile(LastNamesFileName); }
        }

        public IList<string> Colleges
        {
            get { return ReadFile(CollegesFileName, '|'); }
        }

        public IList<string[]> Hometowns
        {
            get
            {
                string[] raw = ReadFile(CitiesFileName, ';');
                return raw.Select(r => r.Split(',')).ToList();
            }
        }

        #endregion

        private static string[] ReadFile(string fileName, char separator = ',')
        {
            string path = string.Format("~/Content/csv/{0}", fileName);
            try
            {
                return File.ReadAllText(
                    HttpContext.Current.Server.MapPath(path)).Split(separator);
            }
            catch
            {
                string msg = string.Format("ERROR: File '{0}' could not be read", path);
                Debug.WriteLine(msg);
                return new[] {msg};
            }
        }
    }
}