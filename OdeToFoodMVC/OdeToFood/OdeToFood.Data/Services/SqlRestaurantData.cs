using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        
        void IRestaurantData.Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        Restaurant IRestaurantData.Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return db.Restaurants.OrderBy(r => r.Name);
        }

        void IRestaurantData.Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
