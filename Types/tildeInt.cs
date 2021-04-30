namespace JustAwful.Types
{
    public class tildeInt : tildeType<int>
    {
        public tildeInt(int value) : base(value) {}

        public static tildeInt operator +(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeInt(lsv + rsv);
        }

        public static tildeInt operator -(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeInt(lsv - rsv);
        }

        public static tildeInt operator /(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeInt(lsv / rsv);
        }

        public static tildeInt operator %(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeInt(lsv % rsv);
        }
    }
}