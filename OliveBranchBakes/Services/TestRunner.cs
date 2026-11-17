using OliveBranchBakes.Models;
using MenuItem = OliveBranchBakes.Models.MenuItem;

namespace OliveBranchBakes.Services
{
    // one row of the test table (T1 to T13 in docs/TestCases.md)
    public class TestResult
    {
        public string Id { get; set; } = "";
        public string Description { get; set; } = "";
        public string Expected { get; set; } = "";
        public string Actual { get; set; } = "";

        public bool Passed
        {
            get { return Expected == Actual; }
        }
    }

    // runs the hand-calculated test cases against the real pricing and scheduling code
    public class TestRunner
    {
        private List<MenuItem> menu = new DataStore().GetSeedMenu();
        private SchedulingService scheduling = new SchedulingService();

        public List<TestResult> RunAll()
        {
            List<TestResult> results = new List<TestResult>();

            // discount tests (menu item ids: 1 cookies, 2 rolls, 3 sourdough, 4 muffins, 5 cake, 6 pumpkin)
            results.Add(PriceTest("T1", "just below 50.00", new int[] { 5, 4 }, new int[] { 1, 1 }, 49.00m));
            results.Add(PriceTest("T2", "exactly 50.00", new int[] { 5, 2 }, new int[] { 1, 1 }, 45.00m));
            results.Add(PriceTest("T3", "just above 50.00", new int[] { 5, 3 }, new int[] { 1, 2 }, 45.90m));
            results.Add(PriceTest("T4", "normal, no discount", new int[] { 1 }, new int[] { 2 }, 24.00m));
            results.Add(PriceTest("T5", "normal, with discount", new int[] { 2, 6 }, new int[] { 3, 2 }, 56.70m));
            results.Add(PriceTest("T6", "smallest quantity", new int[] { 3 }, new int[] { 1 }, 8.00m));
            results.Add(PriceTest("T7", "largest quantity (50)", new int[] { 3 }, new int[] { 50 }, 360.00m));

            // quantity tests
            results.Add(QuantityTest("T8", "quantity 0", 0));
            results.Add(QuantityTest("T9", "quantity 51", 51));

            // orders per pickup day
            results.Add(DayTest("T10", "day is empty", 0, 0, true));
            results.Add(DayTest("T11", "9 orders already on the day", 9, 0, true));
            results.Add(DayTest("T12", "10 orders already on the day", 10, 0, false));
            results.Add(DayTest("T13", "other day is free", 10, 1, true));

            return results;
        }

        private TestResult PriceTest(string id, string description, int[] itemIds, int[] quantities, decimal expected)
        {
            Order order = new Order();
            for (int i = 0; i < itemIds.Length; i++)
            {
                order.AddItem(FindItem(itemIds[i]), quantities[i]);
            }

            TestResult result = new TestResult();
            result.Id = id;
            result.Description = description;
            result.Expected = expected.ToString("0.00");
            result.Actual = order.GetTotal().ToString("0.00");
            return result;
        }

        private TestResult QuantityTest(string id, string description, int quantity)
        {
            string actual = "accepted";
            try
            {
                Order order = new Order();
                order.AddItem(FindItem(3), quantity);
            }
            catch (ArgumentException)
            {
                actual = "rejected";
            }

            TestResult result = new TestResult();
            result.Id = id;
            result.Description = description;
            result.Expected = "rejected";
            result.Actual = actual;
            return result;
        }

        // ordersOnDayA orders are booked on day A. The new order is for day A (dayOffset 0) or day B (dayOffset 1).
        private TestResult DayTest(string id, string description, int ordersOnDayA, int dayOffset, bool expectedAccepted)
        {
            DateTime dayA = new DateTime(2026, 11, 20);
            List<Order> booked = new List<Order>();
            for (int i = 0; i < ordersOnDayA; i++)
            {
                Order existing = new Order();
                existing.OrderId = i + 1;
                existing.PickupDate = dayA;
                booked.Add(existing);
            }

            bool accepted = scheduling.CanAcceptOrder(dayA.AddDays(dayOffset), booked);

            TestResult result = new TestResult();
            result.Id = id;
            result.Description = description;
            result.Expected = expectedAccepted ? "accepted" : "rejected";
            result.Actual = accepted ? "accepted" : "rejected";
            return result;
        }

        private MenuItem FindItem(int menuItemId)
        {
            foreach (MenuItem item in menu)
            {
                if (item.MenuItemId == menuItemId)
                {
                    return item;
                }
            }
            throw new InvalidOperationException("Menu item " + menuItemId + " is not in the seed menu.");
        }
    }
}
