using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId=1, ColorId=1, DailyPrice= 200000,  ModelYear = 2021, Description ="Mercedes A180" },
                new Car {Id = 2, BrandId=1, ColorId=1, DailyPrice= 400000,  ModelYear = 2021, Description ="Mercedes E200" },
                new Car {Id = 3, BrandId=2, ColorId=2, DailyPrice= 300000,  ModelYear = 2018, Description ="Kia Sportage" },
                new Car {Id = 4, BrandId=2, ColorId=2, DailyPrice= 100000,  ModelYear = 2011, Description ="Kia Cerato" },
                new Car {Id = 5, BrandId=3, ColorId=3, DailyPrice= 50000,  ModelYear = 2007, Description ="Fiat Punto Evo" },
                new Car {Id = 6, BrandId=4, ColorId=4, DailyPrice= 75000,  ModelYear = 2010, Description ="Chevrolet Cruze LS" },
                new Car {Id = 7, BrandId=4, ColorId=1, DailyPrice= 110000,  ModelYear = 2016, Description ="Chevrolet Cruze LS Plus" },
                new Car {Id = 8, BrandId=5, ColorId=4, DailyPrice= 700000,  ModelYear = 2021, Description ="Ferrari" },
                new Car {Id = 9, BrandId=1, ColorId=1, DailyPrice= 150000,  ModelYear = 2012, Description ="Mercedes Kompressor" },
                new Car {Id = 10, BrandId=3, ColorId=5, DailyPrice= 30000,  ModelYear = 2002, Description ="Fiat Palio" },

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;

            
        }

        public List<Car> GetById(int Id)
        {
           return  _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            

        }
    }
}
