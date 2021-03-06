﻿using System;
using System.Linq;

namespace Stripe.Models
{
	public class StripeToken : StripeBase
	{
		public DateTimeOffset Created { get; set; }
		public string Currency { get; set; }
		public bool Used { get; set; }
		public int Amount { get; set; }
		public bool LiveMode { get; set; }
		public string Id { get; set; }
		public StripeCard Card { get; set; }
	}
}
