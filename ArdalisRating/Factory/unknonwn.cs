namespace ArdalisRating.Factory
{
	internal class unknonwn : Rater
	{
		public unknonwn(RatingEngine eng) : base(eng)
		{
		}

		public override void Rate(Policy policy)
		{
			throw new System.NotImplementedException();
		}
	}
}