using DrugMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrugMicroservice;
namespace DrugMicroservice.Repository
{
    public class DrugRepository : IDrugRepository
    {
        public List<Drug> GetAllDrugs()
        {
            return DrugHelper.drugList;
        }
        public Drug SearchDrugsByID(int drugId)
        {
            Drug drug = DrugHelper.drugList.FirstOrDefault(d => d.Id == drugId);
            if (drug == null)
                return null;
            return drug;
        }

        public Drug SearchDrugsByName(string drugName)
        {
            Drug drug = DrugHelper.drugList.FirstOrDefault(d => d.Name == drugName);
            if (drug == null)
                return null;
            return drug;
        }

        public DrugLocation GetDispatchableDrugStock(int drugId, string location)
        {
            Drug drug = DrugHelper.drugList.SingleOrDefault(d => d.Id == drugId && d.DrugLocation.Location == location);
            
            if(drug != null)
            {
                return drug.DrugLocation;
            }

            return null;
        }
    }
}



