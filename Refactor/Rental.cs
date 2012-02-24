using System;

namespace StartingPoint
{
	/// <summary>
	/// Rental represents a customer renting a movie.
	/// </summary>
	public class Rental
	{
		/* Fields */

		// Data members
		private Movie m_Movie;
		private int m_DaysRented;

		/* Constructor */

		public Rental(Movie movie, int daysRented)
		{
			m_Movie = movie;
			m_DaysRented = daysRented;
		}

		/* Properties */

		public int DaysRented
		{
			get {return m_DaysRented;}
		}

		public Movie Movie
		{
			get {return m_Movie;}
		}

        public double getCharge()
        {
            double result = 0;
            // Determine amounts for each line
            switch (Movie.PriceCode)
            {
                case PriceCodes.Regular:
                    result += 2;
                    if (DaysRented > 2)
                    {
                        result += (DaysRented - 2) * 1.5;
                    }
                    break;

                case PriceCodes.NewRelease:
                    result += DaysRented * 3;
                    break;

                case PriceCodes.Childrens:
                    result += 1.5;
                    if (DaysRented > 3)
                    {
                        result = (DaysRented - 3) * 1.5;
                    }
                    break;
            }
            return result;




        }

        public int GetFrequentRenterPoints()
        {
            // Add bonus for a two-day new-release rental
            if ((Movie.PriceCode == PriceCodes.NewRelease) && (DaysRented > 1))
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
	}
}
