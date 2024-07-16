//Author: kirby_sone

using System;
using System.Collections.Generic;

    public class AreaSeedDetector
    {
        public long multi = 214013;
        public long machineDiv = 286326784;
        // 65536*4369 -> 286326784;
        public long shift = 0x10000;

        public long nextSeed(long seed)
        {
            return (seed * 214013 + 2531011) & 0xFFFFFFFF;
        }
        public int toIndex(char c)
        {
            switch (c)
            {
                case '1': return 0;
                case '2': return 1;
                case '3': return 2;
                case '4': return 3;
                case '5': return 4;
                case '6': return 5;
                case '7': return 6;
                case '8': return 7;
                case 'A': return 8;
                case 'B': return 9;
                case 'C': return 10;
                case 'D': return 11;
                case 'E': return 12;
                case 'F': return 13;
                case 'G': return 14;
                default: break;
            }
            return -1;
        }

        public long[] machineArea(int t)
        {
            long v = t * machineDiv + shift;
            if (t == 0) return new long[] { 0, v + machineDiv - 1 };
            return new long[] { v, v + machineDiv - 1 };
        }

        public List<long[]> firstRanges(int first, int secondInt)
        {
            long l = machineArea(first)[0];
            long[] second = machineArea(secondInt);
            l = nextSeed(l);
            long remains = machineDiv;
            List<long[]> ans = new List<long[]>(14268);
            long r;
            while (remains > 0)
            {
                r = 0xFFFFFFFF - (0xFFFFFFFF - l) % multi;
                if (1 + (r - l) / multi > remains) r = l + multi * (remains - 1);
                remains -= 1 + (r - l) / multi;

                if (r < second[0] || second[1] < l)
                { l = (r + multi) & 0xFFFFFFFF; continue; }
                long l2 = l, r2 = r;
                if (l < second[0]) l2 = second[0] - (second[0] - l) % multi + multi;
                if (second[1] < r) r2 = second[1] + (r - second[1]) % multi - multi;

                ans.Add(new long[] { l2, r2 });
                l = (r + multi) & 0xFFFFFFFF;
            }
            return ans;
        }

        public List<long> secondValues(List<long[]> ranges, int third)
        {
            List<long> ans = new List<long>(1 << 21);
            long[] thirdRange = machineArea(third);
            long tLeft = thirdRange[0], tRight = thirdRange[1];
            long m2 = (multi * multi) & (long)0xFFFFFFFF;
            long x = (m2 - 0x100000000 % m2) % m2;
            for (int i = 0; i < ranges.Count; i++)
            {
                long l = ranges[i][0], r = ranges[i][1];
                long remains = 1 + (r - l) / multi;
                l = nextSeed(l);
                r = 0xFFFFFFFF - (0xFFFFFFFF - l) % m2;

                if (tRight < l)
                {
                    remains -= 1 + (r - l) / m2;
                    if (remains <= 0) continue;
                    l = (r + m2) & 0xFFFFFFFF;
                    r = 0xFFFFFFFF - (0xFFFFFFFF - l) % m2;
                }
                long counts = 1 + (r - l) / m2;
                if (counts > remains) r = l + m2 * (remains - 1);

                long value = tLeft + ((l - tLeft) + m2) % m2;
                long v = value;
                while (v <= Math.Min(tRight, r))
                {
                    ans.Add(v);
                    v += m2;
                }

                remains -= counts;
                if (remains <= 0) continue;

                long l3 = tLeft + m2;

                while (remains > counts)
                {
                    l += x;
                    if (l >= m2)
                    { l -= m2; counts++; }
                    r += x;
                    if (r > 0xFFFFFFFF)
                    { r -= m2; counts--; }
                    remains -= counts;

                    value += x;
                    if (value >= l3) value -= m2;

                    v = value;
                    while (v <= tRight)
                    {
                        ans.Add(v);
                        v += m2;
                    }
                }
                while (remains > 0)
                {
                    l += x;
                    if (l >= m2)
                    { l -= m2; counts++; }
                    r += x;
                    if (r > 0xFFFFFFFF)
                    { r -= m2; counts--; }

                    long r2 = l + m2 * remains;
                    remains -= counts;

                    value += x;
                    if (value >= l3) value -= m2;

                    v = value;
                    while (v <= Math.Min(tRight, r2))
                    {
                        ans.Add(v);
                        v += m2;
                    }
                }
            }
            return ans;
        }

        public List<long> filterValues(List<long> values, long[] area)
        {
            List<long> ans = new List<long>();
            long l = area[0], r = area[1];
            foreach (long i in values)
            {
                long j = nextSeed(i);
                if (l <= j && j <= r) ans.Add(j);
            }
            return ans;
        }

        public long solve(char[] pattern)
        {
            if (pattern.Length < 9) return -1;
            int[] p = new int[pattern.Length];
            for (int i = 0; i < pattern.Length; i++) p[i] = toIndex(pattern[i]);
            List<long[]> ranges = firstRanges(p[0], p[1]);
            List<long> values = secondValues(ranges, p[2]);
            for (int i = 3; i < p.Length; i++)
            {
                values = filterValues(values, machineArea(p[i]));
            }
            if (values.Count == 0) return -1;
            if (values.Count == 1) return values[0];
            return -1;
        }
    }

