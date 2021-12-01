using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100ExceptionLogs : IEntity
    {
        public int ExceptionLogsId {get;set;}
        public int Ip { get; set; } //??? like 127.0.0.0
        public int WhoAuthId { get; set; }
        public String Page { get; set; }
        public String MethodName { get; set; }
        public String Title { get; set; }
        public String Action { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
