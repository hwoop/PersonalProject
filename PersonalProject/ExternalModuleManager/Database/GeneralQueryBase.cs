using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PersonalProject
{
    public abstract class GeneralQueryBase
    {
        public enum QueryType
        {
            Select,
            Insert,
            Update,
            Delete
        }
        /// <summary>
        /// Open DB File
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// Close DB File
        /// </summary>
        public abstract void Close();

        /// <summary>
        /// DB파일에서 Query문에 맞게 DataTable을 가져옴.
        /// </summary>
        /// <param name="Query">Query문, Select문 이어야 함.</param>
        /// <returns>Query문에 알맞는 DB 상의 값</returns>
        public abstract DataTable LoadData(string Query);

        /// <summary>
        /// Query를 Execute해주는 Method
        /// </summary>
        /// <param name="Query">실제 수행될 Query 문</param>
        /// <returns>실패 시 -1, 수행 된 Table의 최종 Row ID value return</returns>
        public abstract int ExecuteQuery(string Query);

        /// <summary>
        /// Create Query String 
        /// </summary>
        /// <returns>Return maked Query Command</returns>
        public abstract string CreateQueryString();

    }
}
