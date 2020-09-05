using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ArdalisRating.Factory
{
	public class RaterFactory
	{

		public Rater Create(Policy policy, RatingEngine ratingeng)
		{
			switch (policy.Type)
			{
				case PolicyType.Life:
					return new LIfeRaterpolicy(ratingeng );
					
				case PolicyType.Land:
					return new LandPolicyRater(ratingeng);
					
				case PolicyType.Auto:
					return new AutoPolicyRatter(ratingeng);
				default:
					return new unknonwn();
				
			}
		}
	}

}
