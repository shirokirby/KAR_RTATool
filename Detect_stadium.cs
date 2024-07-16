using System;

namespace KAR_RTATool
{
    internal class StadiumDetector
    {
        private long NextRng(long seed)
        {
            return (seed * 214013 + 2531011) % 4294967296;
        }

        public uint[] DetectStadium(long r, uint[] stadium_rate)
        {
            uint rate = 0;
            for (int i = 0; i < 24; i++) rate += stadium_rate[i]; //スタジアムの出現比率の合計
            uint min_stadium_number;
            uint[] stadium_number = new uint[100]; //出現するスタジアムのIDを格納する変数

            for (int i = 0; i < 100; i++)
            {
                r = NextRng(r);
                min_stadium_number = (uint)(((r >> 16) * rate) >> 16);
                uint stadium_threshold = 0;
                for (int j = 0; j < 24; j++)
                {
                    stadium_threshold += stadium_rate[j];
                    if (stadium_threshold == 0) continue;
                    if (min_stadium_number < stadium_threshold)
                    {
                        stadium_number[i] = (uint)j;
                        break;
                    }
                }
            }
            return stadium_number;
        }

        public String ToString(uint u, bool b)
        {
            if (b)
            {
                switch (u)
                {
                    case 0: return "ゼロヨンアタック1";
                    case 1: return "ゼロヨンアタック2";
                    case 2: return "ゼロヨンアタック3";
                    case 3: return "ゼロヨンアタック4";
                    case 4: return "エアグライダー";
                    case 5: return "ポイントストライク";
                    case 6: return "ハイジャンプ";
                    case 7: return "バトルロイヤル1";
                    case 8: return "バトルロイヤル2";
                    case 9: return "デスマッチ1";
                    case 10: return "デスマッチ2";
                    case 11: return "デスマッチ3";
                    case 12: return "デスマッチ4";
                    case 13: return "デスマッチ5";
                    case 14: return "プランテス";
                    case 15: return "マグヒート";
                    case 16: return "サンドーラ";
                    case 17: return "コルダ";
                    case 18: return "アイルーン";
                    case 19: return "ヴァレリオン";
                    case 20: return "スチールオーガン";
                    case 21: return "チェックナイト";
                    case 22: return "ギャラックス";
                    case 23: return "VSデデデ";
                    default: break;
                }
            }
            else
            {
                switch (u)
                {
                    case 0: return "Drag Race 1";
                    case 1: return "Drag Race 2";
                    case 2: return "Drag Race 3";
                    case 3: return "Drag Race 4";
                    case 4: return "Air Glider";
                    case 5: return "Target Flight";
                    case 6: return "High Jump";
                    case 7: return "Kirby Malee 1";
                    case 8: return "Kirby Malee 2";
                    case 9: return "Destruction Derby 1";
                    case 10: return "Destruction Derby 2";
                    case 11: return "Destruction Derby 3";
                    case 12: return "Destruction Derby 4";
                    case 13: return "Destruction Derby 5";
                    case 14: return "Fantasy Meadows";
                    case 15: return "Magma Flows";
                    case 16: return "Sky Sands";
                    case 17: return "Frozen Hillside";
                    case 18: return "Beanstalk Park";
                    case 19: return "Celestial Valley";
                    case 20: return "Machine Passage";
                    case 21: return "Checker Knights";
                    case 22: return "Nebula Belt";
                    case 23: return "VS. King Dedede";
                    default: break;
                }
            }
            return "";
        }
    }
}
