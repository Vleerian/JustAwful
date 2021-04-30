namespace JustAwful.Types
{
    public class tildeFloat : tildeType<float>
    {
        public tildeFloat(float value) : base(value) {}

        public static tildeFloat operator +(tildeFloat ls, tildeFloat rs)
        {
            (float lsv, float rsv) = getTwo(ls, rs);
            return new tildeFloat(lsv + rsv);
        }

        public static tildeFloat operator -(tildeFloat ls, tildeFloat rs)
        {
            (float lsv, float rsv) = getTwo(ls, rs);
            return new tildeFloat(lsv - rsv);
        }

        public static tildeFloat operator /(tildeFloat ls, tildeFloat rs)
        {
            (float lsv, float rsv) = getTwo(ls, rs);
            return new tildeFloat(lsv / rsv);
        }

        public static tildeFloat operator %(tildeFloat ls, tildeFloat rs)
        {
            (float lsv, float rsv) = getTwo(ls, rs);
            return new tildeFloat(lsv % rsv);
        }
    }
}