using System;

namespace EFCoreTestApplication
{
    public class Owned
    {
        public Owned()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
