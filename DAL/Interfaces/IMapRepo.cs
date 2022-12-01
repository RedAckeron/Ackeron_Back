﻿using BLL.Models;
using DAL.Models;
using DAL.Models.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMapRepo
    {
        bool ChkTargetWalking(CharacterLoc CLoc);
        List<Area> GetMap(int IdPlanet);
    }
}
