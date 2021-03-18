using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models.ViewModels
{
    public class TourViewModel
    {
        public IEnumerable<AvailableTime> AvailableTimes { get; set; }
        public IEnumerable<GroupInfo> GroupInfos { get; set; }

    }
}
