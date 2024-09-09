# MVC Project: Viewing Customer and Order Information

This project demonstrates the creation of an ASP.NET MVC application to display customer and order details. By following the steps outlined below, you will be able to develop a basic system that models customer and order information and presents it in a user-friendly format.

## Steps to Implement

### Phase 1: Creating the Models

#### Customer Model:
- Create a `Customer` class with the following properties:
  - `Id`: (Unique identifier for the customer, `int` type)
  - `FirstName`: (Customer's first name, `string` type)
  - `LastName`: (Customer's last name, `string` type)
  - `Email`: (Customer's email address, `string` type)

#### Order Model:
- Create an `Order` class with the following properties:
  - `Id`: (Unique identifier for the order, `int` type)
  - `ProductName`: (Name of the product, `string` type)
  - `Price`: (Price of the product, `decimal` type)
  - `Quantity`: (Quantity of the product ordered, `int` type)

---

### Phase 2: Creating the ViewModel

#### CustomerOrderViewModel Class:
- Create a `CustomerOrderViewModel` class that will contain the following:
  - `Customer`: (A `Customer` object)
  - `Orders`: (A list of `Order` objects)

This ViewModel will combine model data and any additional information needed to be displayed in the view.

---

### Phase 3: Creating the Controller

#### CustomerOrdersController:
- Create a `CustomerOrdersController` class.
- Inside this controller, create an action method called `Index`.
  - In the `Index` method:
    - Create a sample `Customer` object.
    - Create a few sample `Order` objects.
    - Use these objects to create a `CustomerOrderViewModel` object.
    - Pass the `CustomerOrderViewModel` object to the view.

---

### Phase 4: Creating the View

#### Index View:
- In the `Views/CustomerOrders` folder, create a view file named `Index.cshtml`.
  - In this view, use the `CustomerOrderViewModel` to display customer and order details.

##### In the view:
- Display the customer information (ID, First Name, Last Name, Email).
- Create a table to list the orders, showing the Order ID, Product Name, Price, and Quantity.

---

## Conclusion

By completing the steps above, you will build an MVC application that models and displays customer and order data using a combination of ASP.NET MVC models, view models, controllers, and views.

![image](https://github.com/user-attachments/assets/8384944c-fffd-4e3c-ba76-cf09fb208c7b)
