namespace MarysCandyShop
{
    internal static class Helpers
    {
        internal static int GetDaysSinceOpening()
        {
            DateTime openingDate = new DateTime(2024, 1, 1);
            TimeSpan timeDifference = DateTime.Now - openingDate;

            return timeDifference.Days;
        }
    }
}
