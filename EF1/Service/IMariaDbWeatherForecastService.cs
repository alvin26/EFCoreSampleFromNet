using EF1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF1.Service
{
    public interface IMariaDbWeatherForecastService
    {
        public Task<int> Delete(int id);

        public Task<IEnumerable<WeatherForecastDataModel>> FindAll();

        public Task<WeatherForecastDataModel> FindOne(int id);

        public Task<int> Insert(WeatherForecastDataModel forecast);

        public Task<int> Update(WeatherForecastDataModel forecast);

    }
}
