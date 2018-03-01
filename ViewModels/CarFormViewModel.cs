using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental.Models;

namespace CarRental.ViewModels
{
    public class CarFormViewModel
    {
        public IEnumerable<CarRental.Models.carType> carTypes { get; set; }
        public Car car { get; set; }

    }
}