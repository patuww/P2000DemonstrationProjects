using System;
using System.Collections;

namespace StartingPoint
{
	/// <summary>
	/// Customer represents a customer of the store.
	/// </summary>
	public class Customer
	{
		/* Fields */
		
		private string m_Name;
		private ArrayList  m_Rentals = new ArrayList();

		/* Constructor */
		public Customer(string name)
		{
			m_Name = name;
		}

		/* Properties */

		public string Name
		{
			get {return m_Name;}
		}

		/* Methods */

		public void AddRental(Rental arg)
		{
			m_Rentals.Add(arg);
		}

		public string Statement()
		{
			double totalAmount = 0;
			int frequentRenterPoints = 0;
			IEnumerator rentals = m_Rentals.GetEnumerator();
			string result = "Rental record for " + m_Name + "\n";
			while ( rentals.MoveNext() )
			{
				double thisAmount = 0;
				Rental each = (Rental)rentals.Current;

                thisAmount = each.getCharge();



				// Show figures for this rental
				result += "\t" + each.Movie.Title + "\t" + each.getCharge().ToString() + "\n";
				totalAmount += each.getCharge();
			}

			// Add footer lines
			result += "Amount owed is " + totalAmount.ToString() + "\n";
			result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points.";
			return result;
		}
        private double amountFor(Rental aRental)
        {
            return aRental.getCharge();


        }


	}
}
