using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class VehicleSearch
    {   public int? Id { get; set; }
        public string Regnr { get; set; }
        public string Color { get; set; }
    }
    public class VehicleBusinessLogic
    {
        private Garage2Context db;
        public VehicleBusinessLogic()
        {
            db = new Garage2Context();
        }

        public IQueryable<Vehicle> GetProducts(VehicleSearch searchModel)
        {
            var result = db.Vehicles.AsQueryable();
            if (searchModel != null)
            {
                //if (searchModel.Id.HasValue)
                //    result = result.Where(x => x.Id == searchModel.Id);
                if (!string.IsNullOrEmpty(searchModel.Regnr))
                    result = result.Where(x => x.Regnr.Contains(searchModel.Regnr));
                if (!string.IsNullOrEmpty(searchModel.Color))
                    result = result.Where(x => x.Color.Contains(searchModel.Color));
            }
            return result;
        }
    }
}