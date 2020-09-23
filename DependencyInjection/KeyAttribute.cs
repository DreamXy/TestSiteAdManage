using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class KeyAttribute : Attribute
    {
        private readonly Type _type;

        public KeyAttribute(Type type)
        {
            _type = type;
        }

        public Type Type
        {
            get { return _type; }
        }

    }
}
