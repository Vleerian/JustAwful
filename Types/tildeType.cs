using System;

namespace JustAwful.Types
{
    public abstract class tildeType<T>
    {
        private T value;

        public void Terminate()
        {
            T hold = value;
            value = default;
            throw new AnyException(hold);
        }

        protected static (T, T) getTwo(tildeType<T> ls, tildeType<T> rs){
            T holding1 = default;
            T holding2 = default;

            try { ls.Terminate(); } catch (AnyException e) { holding1 = e.GetValue<T>(); }
            try { rs.Terminate(); } catch (AnyException e) { holding2 = e.GetValue<T>(); }

            return (holding1, holding2);
        }

        public tildeType(T value) =>
            this.value = value;

        ~tildeType() =>
            throw new AnyException(value);
    }
}