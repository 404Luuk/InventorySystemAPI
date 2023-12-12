# Inventory System API
### Made for Technovium

This api is made for the Technovium InventorySystem. The point of the system is to keep track of all items / school property that gets lended to students or 3rd parties.

### Prerequisites 

Project is build and run in .NET7.0 and uses EF core to seed and migrate database. If you do not have EF core installed run `dotnet tool install --global dotnet-ef`

### How to run

The API currently uses a postgres container as a database. To set this up locally CD into the cloned project and run `docker-compose up`
This will use the docker file to create a local postgres container to spec. Afterwards to initiate the database run `dotnet ef database update --project InventorySystemAPI`
