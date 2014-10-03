using FISCA.UDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCampusManager
{

    [TableName("icampusmanager.sqlrecord.run")]
    public class SQLRecord : ActiveRecord
    {
        /// <summary>
        /// 建立使用者
        /// </summary>
        [Field(Field = "admin", Indexed = true)]
        public string Admin { get; set; }

        /// <summary>
        /// 類型(新增,修改,刪除)
        /// </summary>
        [Field(Field = "type", Indexed = false)]
        public string Type { get; set; }

        /// <summary>
        /// 執行內容
        /// </summary>
        [Field(Field = "sqlquery", Indexed = false)]
        public string SQLQuery { get; set; }

        /// <summary>
        /// 本SQL的內容說明
        /// </summary>
        [Field(Field = "comment", Indexed = false)]
        public string Comment { get; set; }
    }
}
