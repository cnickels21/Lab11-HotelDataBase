# Lab11-HotelDataBase

## Summary

Entity relationships database model.  A basic web application in .NET, written in C# that models what a simple database structure and entity relationships would look like in code.  The app is to simulate what a hotel string's database would look like to manage a few different hotels around the country with their rooms that are available, types of rooms, and amenities that are offered for each room.  Below you will see an entity relationship diagram to model what is happening behind the scenes, and a short description of each table and its relationships in the database.

## API

There are route handlers for all five of the database tables, each of which includes get, post, put, and delete methods.  These are used to display, update, create, and delete items from each individual table.  Their functionality is still very base right now, but they will be built out over the next few days.  I have been using postman to verify usability and functionality for each type of route method for each table controller.

![Async Inn ERD](assets/AsyncInnERD.png)

## Relations In Detail

1. Hotels Table
   This is the parent table of the entire database.  It consists of columns that define each location's name, city, state, and so on.  It has a one:* relationship with the HotelRooms table.
   **Keys**
   - ID - PK

2. HotelRooms Table
   This is a direct child of the Hotels table which holds information about each room; room number, rate, pet friendly, etc.  It also has a *:1 relationship with the Rooms table.
   **Keys**
   - HotelID - FK\CK
   - RoomNumber - CK
   - RoomID - FK

3. Rooms Table
   This table has columns for the name and layout of each room.  There isn't much else happening in this table, except that it has a 1:* relationship with the RoomAmenities table.
   **Keys**
   - Id - PK

4. RoomAmenities Table
   This is a pure join table that only holds to ID values in it to make a connection between the Amenities and Rooms tables.  It has a *:1 relationship with both of those tables.
   **Keys**
   - RoomID - FK\CK
   - AmenitiesID - FK\CK

[Check the code if you made it this far!](Lab12-HotelDatabase/Data/HotelDBContext.cs)