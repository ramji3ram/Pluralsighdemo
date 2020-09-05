using System;
using System.Collections.Generic;
using System.Text;
using ArdalisRating.Factory;

namespace ArdalisRating
{
	public class LandPolicyRater : Rater
	{

        public LandPolicyRater(RatingEngine ratingEng) : base(ratingEng)
        {

        }

		public override void Rate(Policy policy)
		{

            Console.WriteLine("Rating LAND policy...");
            Console.WriteLine("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return;
            }
            Rating = policy.BondAmount * 0.05m;
        }
	}
}
