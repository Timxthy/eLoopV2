using System.Collections.Generic;

namespace eLoopV2.Models
{
    public interface IElectricCarRepository
    {
        Task<List<ElectricCar>> GetAllElectricCarsAsync();
        IEnumerable<ElectricCar> GetAllElectricCars();
        ElectricCar GetElectricCarById(int id);
        void AddElectricCar(ElectricCar car);
        void UpdateElectricCar(ElectricCar car);
        void DeleteElectricCar(int id);
    }
}
