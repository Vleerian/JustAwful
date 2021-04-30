using System.Collections.Generic;

namespace JustAwful.Types
{
    public class tildeInt : tildeType<int>
    {
        //public static tildeInt one = new tildeInt(1);
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

        public static tildeInt operator ++(tildeInt s)
        {
            tildeInt one = new tildeInt(1);
            return s + one;
        }

        public static tildeInt operator --(tildeInt s)
        {
            tildeInt one = new tildeInt(1);
            return s - one;
        }

        public static tildeBool operator >(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeBool(lsv > rsv);
        }

        public static tildeBool operator <(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeBool(lsv < rsv);
        }

        public static tildeBool operator >=(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeBool(lsv >= rsv);
        }

        public static tildeBool operator <=(tildeInt ls, tildeInt rs)
        {
            (int lsv, int rsv) = getTwo(ls, rs);
            return new tildeBool(lsv <= rsv);
        }

        protected static List<tildeInt> sort(List<tildeInt> list)
        {
            // further improvement: implement for tildeType<T>
            while (tildeBool.getOne(!isSorted(list))) shuffle(ref list);
            return list;
        }

        protected static tildeBool isSorted(List<tildeInt> list)
        {
            tildeInt count = new tildeInt(list.Count);
            while (tildeBool.getOne(--count >= new tildeInt(1)))
            {
                // further improvement: implement T[] override
                if (tildeBool.getOne(list[getOne(count)] < list[getOne(count - new tildeInt(1))])) return new tildeBool(false);
            }
            return new tildeBool(true);
        }

        protected static void shuffle(ref List<tildeInt> list)
        {
            // further improvement: remove ref
            System.Random random = new System.Random();
            tildeInt count = new tildeInt(list.Count);

            for (tildeInt i = new tildeInt(0); tildeBool.getOne(i < count); ++i)
            {
                tildeInt rnd = new tildeInt(random.Next(list.Count));
                tildeInt temp = list[getOne(i)];
                list[getOne(i)] = list[getOne(rnd)];
                list[getOne(rnd)] = temp;
            }
        }
    }
}