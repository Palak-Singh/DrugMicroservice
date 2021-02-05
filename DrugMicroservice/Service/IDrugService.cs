using DrugMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugMicroservice.Service
{
    public interface IDrugService
    {
        List<Drug> GetAllDrugs();
        Drug SearchDrugsByID(int id);
        Drug SearchDrugsByName(string name);
        DrugLocation GetDispatchableDrugStock(int id, string location);
    }
}
