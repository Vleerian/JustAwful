using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustAwful.Types
{
    public class tildeBool : tildeType<bool>
    {
        public tildeBool(bool value) : base(value) { }

        public static tildeBool operator !(tildeBool s)
        {
            bool sv = getOne(s);
            return new tildeBool(!sv);
        }
    }
}
