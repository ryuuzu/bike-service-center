using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BikeServiceCenter.Data;
using BikeServiceCenter.Data.Model;

namespace BikeServiceCenter.Data
{
    public class AdminService
    {
        public AdminService() {
            
        }

        private void SetupAdmins()
        {
            try
            {
                string adminsJSON = File.ReadAllText(FileHelperService.GetAdminFilePath());
                List<Admin> AdminsList = JsonSerializer.Deserialize<List<Admin>>(adminsJSON);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
