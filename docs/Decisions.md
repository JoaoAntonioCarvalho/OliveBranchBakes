# Decisions - Olive Branch Bakes

Each decision has the reason I chose it.

## For the owner (what Olivia needs)

| Decision | Why |
|----------|-----|
| Pickup only, no delivery and no online payment | Olivia is one baker. Totals are for her to read when the customer comes. |
| Customers can order as a guest or with an account | Many customers order once. Forcing an account would make them leave. |
| Allergy information on every order, and Olivia marks it reviewed | A missed allergy is the worst thing that can go wrong in a bakery. |
| At most 10 orders for the same pickup day | This is how much Olivia can bake alone. The 11th order is refused with a message to pick another day. |
| 10% off when the subtotal is 50.00 or more | Variant card rule. It rewards bigger orders such as cakes for parties. |
| Seasonal items (Pumpkin Bread) hide outside their dates | Olivia should not get orders for something she does not bake that month. |
| Cancelled orders free the baking capacity | If a customer cancels, someone else can take that spot. |

## For the developer (how the code is built)

| Decision | Why |
|----------|-----|
| `PricingRule` and `OperationsRule` are abstract classes | The discount or the daily limit can change (new variant) by adding a new child class. `PricingService` and `SchedulingService` do not change. This is polymorphism and the open/closed idea. |
| The numbers are `const` in the rule classes (`MinSubtotal`, `DiscountRate`, `MaxOrdersPerDay`) | One place to change. No magic numbers inside the logic. |
| `MenuItem` is abstract with `RegularMenuItem` and `SeasonalMenuItem` | Each kind decides `IsInSeason`. The menu code never asks "is it seasonal?" with an if. |
| `Customer` is a base class with `GuestCustomer` and `AccountCustomer` | Both place orders. Only the account one has history and reorder. |
| Services (`PricingService`, `SchedulingService`, `OrderService`, `MenuService`) hold the logic. Forms only call them | The rules can be tested without opening a form. This is why `TestRunner` is possible. |
| `IOrderStore` interface with `OrderStore` (json) | `OrderService` depends on the interface, so the json file could be replaced by a database later. |
| Properties with private helper methods (`CheckQuantity`, `FindLine`) inside `Order` | The order protects its own rules (quantity 1 to 50). No form can put a wrong quantity in. |
| `UnitPrice` is copied to the order line when the item is added | Old orders keep the price the customer saw. |
| Money is `decimal` and rounded to 2 places with `MidpointRounding.AwayFromZero` | `double` gives small errors with money. Away from zero is how people round by hand. |
| Order status is an `enum` | The status can only be one of the six valid values. |
| json file in the AppData folder | Simple, no database to install, and enough for one bakery. |
