# Simple Shop Documentation

## Requirements

.NET Core 3.1

## Design

At the application level this project is architected following the clean architecture pattern; that is, at it's simplest, all dependencies point (mostly) towards the core (or domain) layer. 

The component pieces are as follows:

* **Simple_Shop.Domain**
  * This project contains the Domain entities, data models, domain event interfaces and base classes, and repository interfaces.
* **Simple_Shop.Web**
  * This project is a web application that allows for orders to be placed; it follows a CQRS(ish) approach at the class level.
* **Simple_Shop.Data**
  * This project is our data access layer - it contains concrete implementations of our repository interfaces, as well as implementation details of our data layer.
* **Simple_Shop.Events**
  * This projects contains concrete implementations of domain events handlers and domain event dispatcher.
* **Simple_Shop.Tests**
  * A test project containing unit tests relating to core business logic.

## Assumptions

* Assume a product is valid if Price is > $0.00, ProductTypeId is set, and Title is not empty

## Using the application

* **Shop** - Allows the user to add items to a cart and create an order from those items
* **Saved Orders** - Preconfigured carts to represent test inputs
* **Invalid Products** - Demonstrates handling invalid products being added to a shopping cart



