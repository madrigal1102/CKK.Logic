﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int id;

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                if (value >= 0)
                {
                    Id = value;
                }
                else
                {
                    throw new InvalidIdException("InvalidException");
                }
            }
        }
        public string Name { get; set; }

    }
    
}
