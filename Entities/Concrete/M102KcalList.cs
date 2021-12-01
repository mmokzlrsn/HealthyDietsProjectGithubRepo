using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class M102KcalList:IEntity
    {
        public int KcalListId { get; set; }
        public String Nutrient { get; set; }
        public String Piece { get; set; }
        public String PieceType { get; set; }
        public String Kcal { get; set; }
        public String Category { get; set; }
        public int IsDelete { get; set; }
        public int IsActive { get; set; }
        public DateTime IUDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String Guid { get; set; }
    }
}
