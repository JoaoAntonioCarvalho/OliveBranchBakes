# Final Test Results - Checkpoint 3D

These are the same 13 test cases I wrote by hand in Checkpoint 3A (see TestCases.md).
Now they run on the real code. The class `TestRunner` (Services/TestRunner.cs) builds each order,
calls the real `Order`, `PricingService` and `SchedulingService`, and compares the answer with my hand-calculated one.

To run them: open the app, choose Project Information, and click **Run Tests**.

## Results

| ID | Case | Expected | Code trace (what the code does) |
|----|------|----------|---------------------------------|
| T1 | 49.00 subtotal | 49.00 | 49.00 is less than 50.00, discount is 0, total 49.00 |
| T2 | 50.00 subtotal | 45.00 | 50.00 is not less than 50.00, discount 5.00, total 45.00 |
| T3 | 51.00 subtotal | 45.90 | discount Round(5.100, 2) = 5.10, total 45.90 |
| T4 | 24.00 subtotal | 24.00 | under 50.00, no discount |
| T5 | 63.00 subtotal | 56.70 | discount 6.30, total 56.70 |
| T6 | 1 Sourdough Bread | 8.00 | under 50.00, no discount |
| T7 | 50 Sourdough Bread | 360.00 | subtotal 400.00, discount 40.00, total 360.00 |
| T8 | quantity 0 | rejected | `CheckQuantity` throws because 0 < 1 |
| T9 | quantity 51 | rejected | `CheckQuantity` throws because 51 > 50 |
| T10 | 0 orders on the day | accepted | 0 + 1 <= 10 is true |
| T11 | 9 orders on the day | accepted | 9 + 1 <= 10 is true |
| T12 | 10 orders on the day | rejected | 10 + 1 <= 10 is false |
| T13 | 10 orders on day A, new order on day B | accepted | `CountOrdersOn` only counts day B, so 0 + 1 <= 10 is true |

Result of the **Run Tests** button on my computer: ____ of 13 passed.

## Other behavior that comes from the code

- A cancelled order does not count toward the 10 orders of a pickup day (`CountOrdersOn` skips `Cancelled`).
- The price saved on the order line (`UnitPrice`) does not change if Olivia changes the menu price later.
- Pumpkin Bread is only offered when the pickup date is between September 1 and November 30 (`GetVisibleItems`).

## What is not tested

The forms have no automatic tests. The rules are in the service and model classes so the 13 cases
can run without opening a form.
