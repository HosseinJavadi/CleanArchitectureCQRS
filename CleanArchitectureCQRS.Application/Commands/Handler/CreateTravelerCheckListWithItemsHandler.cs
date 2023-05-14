using CleanArchitectureCQRS.Application.Exceptions;
using CleanArchitectureCQRS.Application.Services;
using CleanArchitectureCQRS.Domain.Factories;
using CleanArchitectureCQRS.Domain.Repositories;
using CleanArchitectureCQRS.Domain.ValueObjects;
using CleanArchitectureCQRS.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Commands.Handler
{
    public class CreateTravelerCheckListWithItemsHandler : ICommandHandler<CreateTravelerCheckListWithItems>
    {
        private readonly ITravelerCheckListRepository _repository;
        private readonly ITravelerCheckListFactory _factory;
        private readonly IWeatherService _weather;

        public CreateTravelerCheckListWithItemsHandler(ITravelerCheckListRepository repository , 
            ITravelerCheckListFactory factory,
            IWeatherService weather)
        {
            _repository = repository;
            _factory = factory;
            _weather = weather;
        }

        public async Task HandleAsync(CreateTravelerCheckListWithItems command)
        {
            var (id,name,days,gender,destinationModel) = command;

            var destination = new Destination(destinationModel.City, destinationModel.Country);
            var weather = await _weather.GetWheatherAsync(destination);

            if (weather == null)
                throw new MissingDestinationWeatherException(destination);

            var travelerCheckList = _factory.CreateWithDefaultItems(id, name, destination, days,
                weather.Temperature, gender);

            await _repository.AddAsync(travelerCheckList);
        }
    }
}
