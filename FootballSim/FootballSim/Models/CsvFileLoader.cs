using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace FootballSim.Models
{
    /// <summary>
    /// Ugly, untestable code.
    /// </summary>
    public interface ICsvFileLoader
    {
        IList<string> FirstNames { get; }
        IList<string> LastNames { get; }
        IList<string> Colleges { get; }
        IList<string[]> Hometowns { get; }
    }

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
                //return ReadFile(CitiesFileName, ';') // Get raw city/state string[]
                //    .Select(l => l.Split(',')) // string[] { string[], string[], etc... }
                //    .Select(l => new Location {City = l[0], State = l[1]})
                //    .ToList();
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