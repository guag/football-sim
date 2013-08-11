using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web;

namespace FootballSim.Models
{
    /// <summary>
    /// Ugly, untestable code.
    /// </summary>
    public interface INameFilesLoader
    {
        IList<string> FirstNames { get; }
        IList<string> LastNames { get; }
    }

    public class NameFilesLoader : INameFilesLoader
    {
        private const string FirstNamesFileName = "fn.csv";
        private const string LastNamesFileName = "ln.csv";

        #region INameFilesLoader Members

        public IList<string> FirstNames
        {
            get { return ReadFile(FirstNamesFileName); }
        }

        public IList<string> LastNames
        {
            get { return ReadFile(LastNamesFileName); }
        }

        #endregion

        private static string[] ReadFile(string fileName)
        {
            var path = string.Format("~/Content/csv/{0}", fileName);
            try
            {
                return File.ReadAllText(HttpContext.Current.Server.MapPath(path)).Split(',');
            }
            catch
            {
                var msg = string.Format("ERROR: File '{0}' could not be read", path);
                Debug.WriteLine(msg);
                return new[] { msg };
            }
        }
    }
}