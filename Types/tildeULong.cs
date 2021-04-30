namespace JustAwful.Types
{
    public class tildeULong : tildeType<ulong>
    {
        public tildeULong(ulong value) : base(value) {}

        public static tildeULong operator +(tildeULong ls, tildeULong rs)
        {
            (ulong lsv, ulong rsv) = getTwo(ls, rs);
            return new tildeULong(lsv + rsv);
        }

        public static tildeULong operator -(tildeULong ls, tildeULong rs)
        {
            (ulong lsv, ulong rsv) = getTwo(ls, rs);
            return new tildeULong(lsv - rsv);
        }

        public static tildeULong operator /(tildeULong ls, tildeULong rs)
        {
            (ulong lsv, ulong rsv) = getTwo(ls, rs);
            return new tildeULong(lsv / rsv);
        }

        public static tildeULong operator %(tildeULong ls, tildeULong rs)
        {
            (ulong lsv, ulong rsv) = getTwo(ls, rs);
            return new tildeULong(lsv % rsv);
        }
    }
}