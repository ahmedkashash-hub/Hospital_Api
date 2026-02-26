using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Disase:BaseAuditableEntity
    {public string Name { get;private set; }=string.Empty;
        public string Description { get;private set; }=string.Empty;
       public string[] Image { get; private set; }
        public Disase(string name, string description, string[] image)
        {
            Name = name;
            Description = description;
            Image = image;
        }

        public Disase Add(string name, string description, string[] image)
        {
            return new Disase(name, description, image);
          
        }
        public void Update(string name, string description, string[] image)
        {
            Name = name;
            Description = description;
            Image = image;
        }
    }
}
