using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100NewsletterControls:IEntity
    {
        public int NewsletterControlsId { get; set; }
        public String Email { get; set; }
        public short IsMember { get; set; } //its bit in db
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }

    }
}
