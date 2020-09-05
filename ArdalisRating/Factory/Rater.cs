namespace ArdalisRating.Factory
{
	public abstract class Rater
	{

		public readonly RatingEngine _ratingEngine;
		public decimal Rating { get; set; }

		public Rater(RatingEngine engine)
		{
			_ratingEngine = engine;
			
		}

		public abstract void Rate(Policy policy);
	}
}