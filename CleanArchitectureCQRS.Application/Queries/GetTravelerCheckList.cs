using CleanArchitectureCQRS.Application.DTOs;
using CleanArchitectureCQRS.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Queries
{
    public class GetTravelerCheckList : IQuery<TravelerCheckListDto>
    {
        public Guid Id { get; set; }
    }
}
