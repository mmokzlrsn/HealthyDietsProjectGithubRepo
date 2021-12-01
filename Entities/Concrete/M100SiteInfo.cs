using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M100SiteInfo:IEntity
    {
        public int SiteInfoId { get; set; }
        public String Description { get; set; }
        public String Keywords { get; set; }
        public String Author { get; set; }
        public String Favicon { get; set; }
        public String FaviconSize { get; set; }
        public String DesktopLogo { get; set; }
        public String DesktopLogoSize { get; set; }
        public String MobileLogo { get; set; }
        public String MobileLogoSize { get; set; }
        public String TextLogo { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
