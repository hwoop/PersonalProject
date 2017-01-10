using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject.ExternalModuleManager.Database.MySqlImplimentation
{
    class MySqlManager : GeneralQueryBase
    {
        #region GeneralQueryBase Method Explanation
        public override void Open()
        {
            //For Github test;
        }
        public override void Close()
        {
        }
        public override DataTable LoadData(string Query)
        {
            DataTable dt = new DataTable();
            return dt;
        }
        public override int ExecuteQuery(string Query)
        {
            return -1;
        }
        public override string CreateQueryString()
        {
            string str = "";
            return str;
        }

        #endregion
    }
}
