﻿using System;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface ICarDal
	{
		List<Car> GetAll();
		List<Car> GetById(int CarId);
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
	}
}

