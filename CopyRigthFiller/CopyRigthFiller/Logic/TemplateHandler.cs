using Interfaces.Exceptions;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CopyRigthFiller.Logic
{
    public class TemplateHandler
    {
        public static string[] GetTemplate()
        {
            string file = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Template.txt");
            if (!File.Exists(file))
            {
                throw new UserException("Template not found, please add it to the exe folder.");
            }
            return File.ReadLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Template.txt")).ToArray();
        }
    }
}
