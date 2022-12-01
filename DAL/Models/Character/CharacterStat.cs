﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CharacterStat
    {
        public int IdChar { get; set; }
        public int TimestampSimul { get; set; }
        public int PtMove { get; set; }
        public int PtMoveMax { get; set; }
        public int Xp { get; set; }
        public int Gold { get; set; }
        public int Pv{ get; set; }
        public int PvMax { get; set; }
        public int Pw{ get; set; }
        public int PwMax{ get; set; }
    }
}