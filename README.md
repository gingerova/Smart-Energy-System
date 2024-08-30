# Smart-Energy-System
Smart Energy System with C#
This code iterates through a nested structure of regions, connection points, devices, and device models to display real-time data parameters for each device within each region. Here's a breakdown of what the code does:

Regions Loop: It first iterates over all regions in the data.regions collection.

Connection Points Filtered by Region: For each region, it finds all connection points that belong to that region (using Where(cp => cp.RegionID == region.ID)).

Devices Filtered by Connection Point: For each connection point, it then finds all devices connected to that point (using Where(d => d.ConnectionPointID == connectionPoint.ID)).

Device Model Lookup: For each device, it retrieves the associated device model from the data.deviceModels collection by matching the DeviceModelID of the device.

Output Device Information: It prints out a message containing the region name, connection point name, device name, and device model name.

Parameters Loop: Finally, for each device, it iterates through all the parameters in the data.parameters collection.

Random Value Generation and Display: For each parameter, a random value between 1 and 1000 is generated and printed out alongside the parameter name and unit.

In summary, this code is used to simulate and display real-time data readings for devices located in specific regions and connected via certain connection points. It organizes the information hierarchically and prints it out in a readable format.
