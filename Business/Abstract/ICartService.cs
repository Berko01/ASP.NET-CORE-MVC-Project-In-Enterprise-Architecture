﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Abstract
{
	public interface ICartService
	{
		void AddToCart(Cart cart, Product product);
		void RemoveFromCart(Cart cart, int product);
		List<CartLine> List(Cart cart);	
	}
}
