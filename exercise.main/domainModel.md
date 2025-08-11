|Classes| Methods/Properties|Scenario|Output|
|-------|-------------------|---------|------|
|Basket.cs|Add(IProduct)|Want to add a specific bagel to basket|Adds the bagel to the basket|
|Basket.cs|Remove(int placeinlist)| id like the ability to remove a bagel from basket| removes the given bagel from basket|
|Basket.cs|IsFull()| want feedback if basket is full| returnes true if full, false otherwise|
|Basket.cs|BasketSize| want the ability to change basket size| basket size changed to wanted size|
|Basket.cs|ItemInBaskett(string type)| want to see if item is in basket so i only remove items present in basket| returns true if item in basket, false otherwise|
|Basket.cs|GetBagelCost(string bagelSKU)| want to see the cost of a bagel| returns the price of given bagel|
|Basket.cs|GetTotalCost()| want to see total cost| returns the total cost of the basket|
|Bagel.cs|AddFilling(IProduct filling)| want to add filling| wanted filling added|
|Inventory.cs|getFillingCost(string fillingSKU)| want to see price of fillings| returns list of fillings with price|
|Inventory.cs|inInventory(string item)|only want to sell items in inventory|returns true if item in inventory, false otherwise|
