# Project Journal - Olive Branch Bakes

## Week of October 27 (Checkpoint 3A)
- Built the Phase 2 structure and the first forms.
- Wrote the variant card and then wrote 13 test cases by hand before any pricing code. I did the math twice.
- Saved the menu in a json file with `DataStore` and showed it in a menu data form.
- Problem: the project had build errors, the menu data form showed an error, and the project info layout was cut off. I fixed them in separate commits.
- Lesson: small commits made it easy to see which change broke the build.

## Week of November 3 (Checkpoint 3B)
- Changed `MenuItem` to an abstract class with regular and seasonal children, so Pumpkin Bread hides itself outside the fall.
- Added the order logic: add, change quantity, remove and subtotal.
- Connected the order form to the menu, the categories and the cart.
- Problem: adding the same item twice should not make two lines. I fixed it with `FindLine` so the quantity is added to the existing line.

## Week of November 10 (Checkpoint 3C)
- Added the pricing rule (10% when the subtotal is 50.00 or more) and the operations rule (10 orders per pickup day) as small rule classes.
- Added `IOrderStore` so orders are saved in a json file without `OrderService` knowing how.
- Added account creation, sign in, the order summary and the confirmation.
- Problem: saving an account customer together with its order history would make a loop in the json file. I fixed it with `[JsonIgnore]` on `OrderHistory`.
- Problem: a cancelled order should not use the baking capacity. `CountOrdersOn` skips cancelled orders.

## Week of November 17 (Checkpoint 3D)
- Built `TestRunner` so T1 to T13 run on the real code with one button.
- Finished the `OrderService` methods that were still waiting (status, cancel, allergy review) and `Reorder`.
- Wrote the change log, the decisions, the final test results and the video script.
- Not done: the baker sign in and a baker screen. They are listed in the change log as known limits.

## What I would do next
1. Build `AdminAuthService.Login` with a hashed password and a baker screen that calls the `OrderService` methods.
2. Add a second pricing rule class (for example a holiday discount) to show the rule classes can be swapped.
3. Replace the json file with a database if Olivia's volume grows.
