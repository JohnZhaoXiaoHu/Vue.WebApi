using System;
using System.Collections.Generic;
using System.Text;

namespace Vue.Entity.Commen
{
    public class EntityBase : EntityBase<string>
    {
    }

    public class EntityBase<TKey> where TKey : IEquatable<TKey>
    {
        public TKey Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
