using System;
using System.Collections.Generic;

namespace EFCoreTestApplication
{
    public class Owner
    {
        public Owner()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Owned> OwnedObjects = new ();
    }
}
