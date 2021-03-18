using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models.ViewModels
{
    public class TourViewModel
    {
        public IQueryable<AvailableTime> AvailableTimes { get; set; }
        public IQueryable<GroupInfo> GroupInfos { get; set; }

    }
}
