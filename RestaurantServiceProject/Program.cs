// See https://aka.ms/new-console-template for more information
using RestaurantServiceProject.Classes;
using RestaurantServiceProject.Data;

Tables tables = new Tables();
Drinks drinks = new Drinks();
Food food = new Food();
//GUIMenuHandler.Init(tables);
//GUI.DrawGUI("select_taken_table", tables);
Order order = new Order(2);
order.AddFoodOrDrink(1, food.FoodList[0]);
order.AddFoodOrDrink(1, food.FoodList[1]);
order.AddFoodOrDrink(1, food.FoodList[0]);
Console.ReadLine();