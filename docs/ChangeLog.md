# Change Log - Olive Branch Bakes

## Checkpoint 3D - final release (phase3-final) - November 17, 2026
- Added `TestRunner` and a **Run Tests** button on Project Information. It runs T1 to T13 on the real code.
- `OrderService.UpdateStatus`, `CancelOrder` and `MarkAllergyReviewed` now work and save to the json file.
- `AccountCustomer.Reorder` copies the items from a past order that are still on the menu today.
- Added FinalTestResults, Journal, Decisions and VideoScript to docs.

## Checkpoint 3C - November 10, 2026
- Added `PricingRule` and `SubtotalDiscountRule` (10% off when the subtotal is 50.00 or more).
- Added `OperationsRule` and `DailyCapacityRule` (at most 10 orders for the same pickup day).
- Added `IOrderStore` and `OrderStore`. Placed orders are saved in a json file.
- Added account creation and sign in, and connected them to the welcome screen.
- Added the order summary and confirmation to the order form.

## Checkpoint 3B - November 3, 2026
- `MenuItem` is now abstract with `RegularMenuItem` and `SeasonalMenuItem`.
- Added `MenuCategory`, `MenuService` (items visible by date and category).
- Order add, change quantity, remove and subtotal logic.
- Order form connected to the menu, categories, seasonal items and the cart.

## Checkpoint 3A - October 27, 2026
- Phase 2 project structure, `DataStore` (menu saved in json), menu data form.
- Added VariantCard.md and the hand-calculated test cases.
- Moved the Phase 1 documents and the narrative into docs.

## Known limits of this release
- Olivia's sign in (`AdminAuthService.Login`) is not built, so there is no baker screen yet.
  The order methods she needs (status, cancel, allergy review) are done in `OrderService` but no form calls them.
- There is no online payment. Totals are only for the baker to read (see the variant card).
