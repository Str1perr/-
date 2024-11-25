using System.Configuration;

namespace Курсовой_проект
{
    internal class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Курсовой_проект.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}