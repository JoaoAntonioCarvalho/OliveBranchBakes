# Video Script - Checkpoint 3D (12 to 15 minutes)

Speaking speed is about 140 words per minute. Times are a guide.
Have open before recording: the app, Visual Studio with PricingService.cs, SubtotalDiscountRule.cs, SchedulingService.cs, DailyCapacityRule.cs, and docs/TestCases.md.

---

## 0:00 - Opening and the three rules (1 min)

"Hi, I am Joao Carvalho. This is Olive Branch Bakes, an order system for Olivia, a one-person cottage bakery. Pickup only, no online payment.

The system follows three rules from my variant card:

Rule one: 10 percent off the whole order when the subtotal is 50.00 or more. Exactly 50.00 gets the discount. 49.99 does not.
Rule two: one item can be ordered from 1 to 50 per order.
Rule three: Olivia can take at most 10 orders for the same pickup day.

Money is rounded to 2 decimal places. In the next minutes I will show the app as Olivia and her customers use it, and then the code as a developer."

## 1:00 - Part 1, the owner: requirements and problems solved (4 min)

Show the app. Say each point while clicking.

1. Welcome screen: "A customer can continue as a guest or create an account. Many bakery customers order once, so I did not force an account."
2. Order form: "The menu has categories. Pumpkin Bread is a fall item, so when I pick a pickup date in December it is not shown. Olivia does not get orders for something she does not bake."
3. Add items: add Birthday Cake and Sourdough Bread, change a quantity, remove a line. "Adding the same item again adds to the same line."
4. Try quantity 51: show the message. "That is rule two."
5. Allergy box: "Every order needs allergy information. This was the biggest risk I found in my problem analysis. Olivia marks it as reviewed before baking."
6. Order summary: "The customer sees the subtotal, the discount and the total before confirming. The total is only for Olivia to read, because there is no online payment."
7. Place an order and show the confirmation.
8. Capacity: "If the pickup day already has 10 orders, the next one is refused and the customer is asked to choose another day. That protects Olivia from taking more than she can bake."

Close this part: "The problems from Phase 1 were lost orders on paper, missed allergies, and too many orders in one day. The order record, the allergy box and the daily limit answer each one."

## 5:00 - Part 2, the developer: the pricing code line by line (3 min)

Open PricingService.cs.

"`PricingService` has a field called rule. Its type is `PricingRule`, the base class, but I create a `SubtotalDiscountRule`. The service only knows the base class.

`GetDiscount` takes an order, asks the order for its subtotal, and gives that number to the rule. The service does not know what the rule is.

`GetTotal` takes the subtotal minus the discount, and then rounds to 2 places with `Math.Round` and `MidpointRounding.AwayFromZero`, the way people round by hand."

Open SubtotalDiscountRule.cs.

"This class extends `PricingRule` and overrides `GetDiscount`. Two constants at the top: `MinSubtotal` is 50.00 and `DiscountRate` is 0.10. The numbers are in one place.

The first check in the method: if the subtotal is less than 50, return 0. Less than, not less or equal, so exactly 50.00 gets the discount. Otherwise it returns the subtotal times 0.10, rounded to 2 places. The type is `decimal` because `double` gives small errors with money."

## 8:00 - Part 3, the scheduling code line by line (2 min)

Open SchedulingService.cs.

"`SchedulingService` also has a field typed as the base class, `OperationsRule`, holding a `DailyCapacityRule`.

`CountOrdersOn` starts with count equal to zero and loops over every saved order. It counts an order when its pickup date, using `.Date` so the time does not matter, is the same day and its status is not `Cancelled`. A cancelled order gives the spot back to Olivia.

`CanAcceptOrder` counts the orders on that day and asks the rule."

Open DailyCapacityRule.cs.

"The constant `MaxOrdersPerDay` is 10. `CanAccept` returns true when the orders already on the day plus this new one is 10 or less. With 9 on the day, 9 plus 1 is 10, accepted. With 10 on the day, 10 plus 1 is 11, refused."

## 10:00 - Part 4, tests T1, T3, T7 and T10 (2 min 30 s)

Show docs/TestCases.md, then the app: Project Information, **Run Tests**.

"I wrote these answers by hand in Checkpoint 3A, before the code. Now `TestRunner` runs them on the real code.

T1: Birthday Cake 35.00 plus Blueberry Muffins 14.00 is 49.00. It is under 50, no discount. Expected 49.00.

T3: Birthday Cake 35.00 plus two Sourdough Bread at 8.00 is 51.00. Over 50, so the discount is 51.00 times 0.10, which is 5.10. 51.00 minus 5.10 is 45.90.

T7: 50 Sourdough Bread, the largest allowed quantity. 50 times 8.00 is 400.00. The discount is 40.00. The total is 360.00.

T10: the pickup day is empty. `CountOrdersOn` returns 0, 0 plus 1 is 1, which is 10 or less, so the order is accepted.

Here is the result window: [read the pass count on screen]. Each line shows the expected value and the value the code returned."

## 12:30 - Part 5, object oriented principles and choices (2 min)

Show the class folders in Solution Explorer.

"Abstraction and polymorphism: `PricingRule`, `OperationsRule` and `MenuItem` are abstract. The services call the base class and each child decides. To change the discount I add a new child class and do not touch `PricingService`.

Inheritance: `Customer` has `GuestCustomer` and `AccountCustomer`. `MenuItem` has regular and seasonal items.

Encapsulation: `Order` checks the quantity itself in `CheckQuantity`, so no form can save a quantity of 51.

Interface: `OrderService` uses `IOrderStore`. Today it is a json file. Later it can be a database without changing `OrderService`.

Separation of concerns: forms only show things and call services. That is why I could test the rules without opening a form."

## 14:30 - Closing (30 s)

"What works: guest and account orders, seasonal menu, the discount, the daily limit, the allergy box, saved orders, and the 13 tests. What is not done: the baker sign in and baker screen. The service methods for them exist, but no form calls them yet. This is in the change log. Thank you."
