using System;


namespace StartingPoint
{
	/// <summary>
	/// Price codes
	/// </summary>
	public enum PriceCodes
	{
		Regular,
		NewRelease,
		Childrens
	}
	/// <summary>
	/// Movie is just a simple data class.
	/// </summary>
	public class Movie
	{
		/* Fields */

		// Price code constants changed to enum

		// Data members
		private string m_Title;
		//private PriceCodes m_PriceCode;
	    private Price _price;
		/* Constructor */

		public Movie(string title, PriceCodes priceCode)
		{
			m_Title = title;
			PriceCode = priceCode;
		}

		/* Properties */

		public PriceCodes PriceCode
		{
			get {return _price.GetPriceCode();}
			set
			{
			    //m_PriceCode = value;
                switch (value)
                {
                    case PriceCodes.Regular:
                        _price = new RegularPrice();
                        break;

                    case PriceCodes.NewRelease:
                        _price = new NewReleasePrice();
                        break;

                    case PriceCodes.Childrens:
                        _price = new ChildrensPrice();
                        break;
                }
			}
		}

		public string Title
		{
			get {return m_Title;}
		}

        public double getCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            // Add bonus for a two-day new-release rental
            if ((PriceCode == PriceCodes.NewRelease) && (daysRented > 1))
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
