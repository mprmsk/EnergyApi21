using EnergyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAPI.DateCalcBusinessObjects
{
    public interface IEnergyCalcBO
    {
        public bool CalculateWeekEnd(DateTime date);
    }
}
