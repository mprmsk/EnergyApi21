using EnergyAPI.DateCalcBusinessObjects;
using EnergyAPI.Energy.BO.DataSerialize;
using EnergyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EnergyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnergyController : ControllerBase
    {
        private readonly IEnergyCalcBO energy;
        private readonly IDataSerialize dataSerialize;
        private readonly string path = @"C:\TempEnergy\Temp.json";

        public EnergyController(IEnergyCalcBO _energy, IDataSerialize _dataSerialize)
        {
            this.energy = _energy;
            this.dataSerialize = _dataSerialize;
        }
        [HttpGet]
        public IList<EnergyModel> Get()
        {
            return this.dataSerialize.DataSerializeFromJson(path);
        }

        [HttpPost]
        public IList<EnergyModel> Post(EnergyModel model)
        {
            List<EnergyModel> listDetails = null;
            if (this.energy.CalculateWeekEnd(model.EnteredDate))
            {
                model.Cost = model.Cost / 10;
            }

            this.dataSerialize.DataSerializetoJson(path, model);
            listDetails = this.dataSerialize.DataSerializeFromJson(path);

            return listDetails;
        }

    }

}
