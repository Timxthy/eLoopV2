using eLoopV2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eLoopV2.Data
{
    public class ElectricCarRepository : IElectricCarRepository
    {
        private readonly ElectricCarLeaseContext _context;

        public ElectricCarRepository(ElectricCarLeaseContext context)
        {
            _context = context;
        }

        public IEnumerable<ElectricCar> GetAllElectricCars()
        {
            return _context.ElectricCars.ToList();
        }

        public ElectricCar GetElectricCarById(int id)
        {
            return _context.ElectricCars.FirstOrDefault(c => c.ID == id);
        }

        public void AddElectricCar(ElectricCar car)
        {
            _context.ElectricCars.Add(car);
            _context.SaveChanges();
        }

        public void UpdateElectricCar(ElectricCar car)
        {
            _context.ElectricCars.Update(car);
            _context.SaveChanges();
        }

        public void DeleteElectricCar(int id)
        {
            var car = _context.ElectricCars.FirstOrDefault(c => c.ID == id);
            _context.ElectricCars.Remove(car);
            _context.SaveChanges();
        }
        public async Task<List<ElectricCar>> GetAllElectricCarsAsync( )
        {
            return await _context.ElectricCars.ToListAsync();
        }

       


    }
}
