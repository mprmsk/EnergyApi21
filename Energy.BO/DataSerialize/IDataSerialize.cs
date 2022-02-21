using EnergyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAPI.Energy.BO.DataSerialize
{
    public interface IDataSerialize
    {
        public void DataSerializetoJson(string path, EnergyModel model);
        public List<EnergyModel> DataSerializeFromJson(string path);
    }
}
