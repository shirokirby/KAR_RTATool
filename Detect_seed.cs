namespace KAR_RTATool
{
    internal class SeedDetector
    {
        private int ToIndex(char c)
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

        private long NextRng(long seed)
        {
            return (seed * 214013 + 2531011) % 4294967296;
        }

        public long DetectSeed(char[] machine_id, long r0, long calculate, int id_number)
        {
            long r1 = 0;
            long rr0 = r0;
            long rr1 = 0;
            int machine_number = 0;
            for (long i = 0; i < calculate; i++)
            {
                r1 = NextRng(r0);
                rr0 = r0;
                for (int j = 0; j < id_number; j++)
                {
                    rr1 = NextRng(rr0);
                    if ((((rr1 >> 16) * 15) >> 16) == ToIndex(machine_id[machine_number])) machine_number++;
                    else machine_number = 0;
                    rr0 = rr1;
                    if (machine_number == 0) break;
                    if (machine_number == id_number) return rr1;
                }
                r0 = r1;
            }
            return -1;
        }
    }
}
