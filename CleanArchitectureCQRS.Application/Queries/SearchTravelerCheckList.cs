using CleanArchitectureCQRS.Application.DTOs;
using CleanArchitectureCQRS.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Queries
{
    public class SearchTravelerCheckList : IQuery<IEnumerable<TravelerCheckListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
