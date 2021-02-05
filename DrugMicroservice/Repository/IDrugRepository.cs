﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DrugMicroservice.Models;

namespace DrugMicroservice.Repository
{
    public interface IDrugRepository
    {
        List<Drug> GetAllDrugs();
        Drug SearchDrugsByID(int id);
        Drug SearchDrugsByName(string name);
        DrugLocation GetDispatchableDrugStock(int id, string location);
    }
}
