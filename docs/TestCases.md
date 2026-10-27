# Hand-Calculated Test Cases - Checkpoint 3A

I wrote these before writing any pricing code. I worked out every answer by hand.
Prices come from the seed menu. Money is rounded to 2 decimal places.
The discount is 10% of the subtotal, only when the subtotal is 50.00 or more (see VariantCard.md).

Seed prices: Chocolate Chip Cookies 12.00, Cinnamon Rolls 15.00, Sourdough Bread 8.00, Blueberry Muffins 14.00, Birthday Cake 35.00, Pumpkin Bread 9.00.

## Discount tests

| ID | Case | Input | Calculation | Expected total |
|----|------|-------|-------------|----------------|
| T1 | just below 50.00 | 1 Birthday Cake, 1 Blueberry Muffins | 35.00 + 14.00 = 49.00. Under 50.00, no discount | 49.00 |
| T2 | exactly 50.00 | 1 Birthday Cake, 1 Cinnamon Rolls | 35.00 + 15.00 = 50.00. Discount 50.00 x 0.10 = 5.00. 50.00 - 5.00 = 45.00 | 45.00 |
| T3 | just above 50.00 | 1 Birthday Cake, 2 Sourdough Bread | 35.00 + 2 x 8.00 = 51.00. Discount 51.00 x 0.10 = 5.10. 51.00 - 5.10 = 45.90 | 45.90 |
| T4 | normal, no discount | 2 Chocolate Chip Cookies | 2 x 12.00 = 24.00. Under 50.00, no discount | 24.00 |
| T5 | normal, with discount | 3 Cinnamon Rolls, 2 Pumpkin Bread | 3 x 15.00 = 45.00. 2 x 9.00 = 18.00. Subtotal 63.00. Discount 6.30. 63.00 - 6.30 = 56.70 | 56.70 |
| T6 | smallest quantity | 1 Sourdough Bread | 1 x 8.00 = 8.00. No discount | 8.00 |
| T7 | largest quantity (50) | 50 Sourdough Bread | 50 x 8.00 = 400.00. Discount 40.00. 400.00 - 40.00 = 360.00 | 360.00 |

## Quantity tests (VR-4, 1 to 50)

| ID | Case | Input | Calculation | Expected |
|----|------|-------|-------------|----------|
| T8 | one below the limit | 0 Sourdough Bread | 0 is less than 1 | rejected |
| T9 | one past the limit | 51 Sourdough Bread | 51 is more than 50 | rejected |

Quantity 1 is T6 and quantity 50 is T7. Both are accepted.

## Orders per pickup day (limit is 10)

| ID | Case | Input | Calculation | Expected |
|----|------|-------|-------------|----------|
| T10 | day is empty | 0 orders already on the pickup day | 0 + 1 = 1, which is 10 or less | accepted |
| T11 | just below the limit | 9 orders already on the pickup day | 9 + 1 = 10, which is 10 or less | accepted (10th order) |
| T12 | one past the limit | 10 orders already on the pickup day | 10 + 1 = 11, which is more than 10 | rejected (11th order) |
| T13 | other day is free | 10 orders on day A, new order for day B with 0 orders | 0 + 1 = 1, which is 10 or less | accepted |

## Check

I did all the math twice. For example T3: 35 + 16 = 51, 51 / 10 = 5.1, 51 - 5.1 = 45.9. For T7: 50 x 8 = 400, 400 / 10 = 40, 400 - 40 = 360.
