using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102ClientDocuments:IEntity 
    {
        public int ClientDocumentsId { get; set; }
        public int ClientId { get; set; }
        public String DocumentsName { get; set; }
        public String DocumentsType { get; set; }
        public String DocumentsImageUrl { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
