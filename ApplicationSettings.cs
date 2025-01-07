using System.Configuration;

namespace shayyan
{
    internal  class ApplicationSettings
    {
        public static String ConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}