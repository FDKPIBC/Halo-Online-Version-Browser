using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloOnlineVersionBrowser
{
    public class Build
    {
        /// <summary>
        /// Build信息ID
        /// </summary>
        string _id { get; set; }
        /// <summary>
        /// 编译版本
        /// </summary>
        public string BuildVersion { get; set; }

        public string Branch
        {
            get;

            set;
        }

        public string CommitId
        {
            get;

            set;
        }

        public string CommitAuthor
        {
            get;

            set;
        }

        public DateTime CommitDate
        {
            get;

            set;
        }

        public string CommitMessage
        {
            get;

            set;
        }
        public string size
        {
            get;

            set;
        }

        public string url
        {
            get;

            set;
        }
        /// <summary>
        /// 下载地址
        /// </summary>
        public string downloadUrl
        {
            get;

            set;
        }
    }
}
