﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {

        }
        public BaseEntity(int Id)
        {
            this.Id = Id;
        }
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BaseEntity entity &&
                   Id == entity.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
