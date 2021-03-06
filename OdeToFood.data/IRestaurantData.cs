﻿using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Seven Spices", Location="Florida", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 3, Name = "Moes", Location="Florida", Cuisine = CuisineType.Mexican }
                };
            }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
