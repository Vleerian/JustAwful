namespace JustAwful.Types
{
    public class tildeLong : tildeType<long>
    {
        public tildeLong(long value) : base(value) {}

        public static tildeLong operator +(tildeLong ls, tildeLong rs)
        {
            (long lsv, long rsv) = getTwo(ls, rs);
            return new tildeLong(lsv + rsv);
        }

        public static tildeLong operator -(tildeLong ls, tildeLong rs)
        {
            (long lsv, long rsv) = getTwo(ls, rs);
            return new tildeLong(lsv - rsv);
        }

        public static tildeLong operator /(tildeLong ls, tildeLong rs)
        {
            (long lsv, long rsv) = getTwo(ls, rs);
            return new tildeLong(lsv / rsv);
        }

        public static tildeLong operator %(tildeLong ls, tildeLong rs)
        {
            (long lsv, long rsv) = getTwo(ls, rs);
            return new tildeLong(lsv % rsv);
        }
    }
}