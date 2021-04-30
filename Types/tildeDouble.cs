namespace JustAwful.Types
{
    public class tildeDouble : tildeType<double>
    {
        public tildeDouble(double value) : base(value) {}

        public static tildeDouble operator +(tildeDouble ls, tildeDouble rs)
        {
            (double lsv, double rsv) = getTwo(ls, rs);
            return new tildeDouble(lsv + rsv);
        }

        public static tildeDouble operator -(tildeDouble ls, tildeDouble rs)
        {
            (double lsv, double rsv) = getTwo(ls, rs);
            return new tildeDouble(lsv - rsv);
        }

        public static tildeDouble operator /(tildeDouble ls, tildeDouble rs)
        {
            (double lsv, double rsv) = getTwo(ls, rs);
            return new tildeDouble(lsv / rsv);
        }

        public static tildeDouble operator %(tildeDouble ls, tildeDouble rs)
        {
            (double lsv, double rsv) = getTwo(ls, rs);
            return new tildeDouble(lsv % rsv);
        }
    }
}