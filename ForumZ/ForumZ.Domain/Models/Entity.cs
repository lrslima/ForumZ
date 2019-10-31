using System;
using System.Collections.Generic;
using System.Text;

namespace ForumZ.Domain.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id
        {
            get; set;
        }
    }
}
