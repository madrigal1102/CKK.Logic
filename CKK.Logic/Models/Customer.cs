using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _address;


        // GetId anad SetId method for _id field
        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }

        // GetName and SetName Method for _name field
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        // GetAddress and SetAddress Method for _address field
        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
    }
}
