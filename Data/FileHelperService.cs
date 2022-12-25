using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeServiceCenter.Data
{
    public static class FileHelperService
    {

        private static readonly string RootFilePath = "./data/";

        public static string GetAdminFilePath()
        {
            return $"{RootFilePath}admins.json";
        }
    }
}
