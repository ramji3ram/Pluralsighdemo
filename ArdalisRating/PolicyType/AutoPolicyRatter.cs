using System;
using ArdalisRating.Factory;

namespace ArdalisRating
{
	public class AutoPolicyRatter : Rater
	{
	

		public AutoPolicyRatter(RatingEngine ratingEngine) : base(ratingEngine)
		{
		}


		public override void Rate(Policy policy)
		{
            Console.WriteLine("Rating AUTO policy...");
            Console.WriteLine("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _ratingEngine.Rating = 1000m;
                }
                _ratingEngine.Rating = 900m;
            }
        }
	}
}
