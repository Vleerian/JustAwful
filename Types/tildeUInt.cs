namespace JustAwful.Types
{
    public class tildeUInt : tildeType<uint>
    {
        public tildeUInt(uint value) : base(value) {}

        public static tildeUInt operator +(tildeUInt ls, tildeUInt rs)
        {
            (uint lsv, uint rsv) = getTwo(ls, rs);
            return new tildeUInt(lsv + rsv);
        }

        public static tildeUInt operator -(tildeUInt ls, tildeUInt rs)
        {
            (uint lsv, uint rsv) = getTwo(ls, rs);
            return new tildeUInt(lsv - rsv);
        }

        public static tildeUInt operator /(tildeUInt ls, tildeUInt rs)
        {
            (uint lsv, uint rsv) = getTwo(ls, rs);
            return new tildeUInt(lsv / rsv);
        }

        public static tildeUInt operator %(tildeUInt ls, tildeUInt rs)
        {
            (uint lsv, uint rsv) = getTwo(ls, rs);
            return new tildeUInt(lsv % rsv);
        }
    }
}