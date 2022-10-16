using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaptopSell.Models
{
    public class ordermodel
    {
        [Required()]
        public int orderid
        {
            get;
            set;
        }
        public int custid
        {
            get;
            set;
        }
        public int lapid
        {
            get;
            set;
        }
        [DataType(DataType.DateTime)]
        public DateTime orderdate
        {
            get;
            set;
        }
        [DataType(DataType.DateTime)]
        public DateTime? receivedate
        {
            get;
            set;
        }
        public string comments
        {
            get;
            set;
        }
    }
}