using System;

namespace JustAwful
{
    public class AnyException : Exception
    {
        protected object value;
        protected Type type;

        public AnyException(object value)
        {
            type = value.GetType();
            this.value = value;
        }

        public T GetValue<T>()
        {
            if(typeof(T) != type)
                throw new ArgumentException("Type argument does not match stored value");

            var hold = (T)value;
            value = default;
            return hold;
        }
    }
}