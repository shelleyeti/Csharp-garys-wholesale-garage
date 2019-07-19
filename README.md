# Practice: Refueling Stations for Gary's Wholesale Garage

## Instructions
1. Create a GasStation type for gas-powered vehicles.
1. Create a BatteryStation type for electric-powered vehicles.
1. Create an interface that both types of stations must implement that ensures that they both have the following properties and methods.
    - int Capacity: The number of vehicles that they can refuel at any one time.
    - void Refuel(List<T> vehicles): A method to print a message to the terminal that the vehicle has been refueled. (e.g. "The Cessna has been refueled with 200 gallons of gas") Each refueling station's Refuel() method should accept a list of vehicles that only it can process. GasStation.Refuel() should only accept a list of gas-powered vehicles. BatteryStation.Refuel() should only accept a list of electric-powered vehicles.
1. In your main method, make sure you have a list of electric vehicles, and a list of gas vehicles.
1. Create an instance of BatteryStation and GasStation.
1. Refuel all the vehicles by sending them to the correct refueling station.

# Advanced Challenge: Station Inheritance
## Note: Advanced challenges should only be attempted once you complete the practice exercise and feel comfortable with the concept.

Can you create a Station class from which both BatteryStation and GasStation inherit the Refuel() method?

### Results will appear in the console