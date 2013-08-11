using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        IList<Location> Hometowns { get; }
    }

    public class CsvFileLoader : ICsvFileLoader
    {
        private const string FirstNamesFileName = "fn.csv";
        private const string LastNamesFileName = "ln.csv";
        private const string CollegesFileName = "colleges.csv";

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

        public IList<Location> Hometowns
        {
            get
            {
                throw new NotImplementedException();
                //return File.ReadAllLines(HttpContext.Current.Server.MapPath("~/Content/csv/{0}"));
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