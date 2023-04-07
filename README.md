<h1 align="center">Борис Уголев 👽</h1>

![](https://otkritkis.com/wp-content/uploads/2022/07/mw7aj.gif)

<h1 align="center"><a href="Practic1/Practic1/Controllers/WeatherForecastController.cs">Practice #1</a></h1>

<img width="371" alt="image" src="https://user-images.githubusercontent.com/64079766/218176321-2915da54-d6da-41f5-b4ba-cb69d533ca72.png">
<img width="317" alt="image" src="https://user-images.githubusercontent.com/64079766/218176479-7d7356ef-33c0-44a5-81d0-2d284b5e747a.png">

<h1 align="center"><a href="Practic2/Practic2/Controllers/WeatherForecastController.cs">Practice #2</a></h1>

<img width="334" alt="image" src="https://user-images.githubusercontent.com/64079766/222698585-9354b108-ec0a-4997-97a4-989b6e9e458a.png">
<img width="315" alt="image" src="https://user-images.githubusercontent.com/64079766/222698688-c688f6b6-39c3-425a-85c2-4bbd213e6794.png">

<h1 align="center">Practice #3 and #4</h1>

<h2><a href="misc/model.jpg">Проектирование ER-модели БД</a></h2>

![диограма](https://user-images.githubusercontent.com/64079766/222713037-ed7a5ef6-5dd1-458a-849e-30270801e187.jpg)

<h2>Sql запрос и диограмма</h2>

```create database InternetShop
go
use InternetShop
go
create table Role
(
ID int not null primary key identity(1,1),
Role nvarchar(50) not null unique,
Description nvarchar(300) not null,
IsDeleted bit not null
)
create table Users
(
ID int not null primary key identity(1,1),
Email nvarchar(50) not null unique,
Name nvarchar(50) not null,
Surname nvarchar(50) not null,
Middle_name nvarchar(50) not null,
Country nvarchar(50) null,
Password nvarchar(50) not null,
Role_id int not null,
IsDeleted bit not null
Constraint FK_Role_Users foreign key (Role_id) references Role(ID)
)
create table Filter
(
ID int not null primary key identity(1,1),
Filter nvarchar(20) not null,
Description nvarchar(50) not null,
IsDeleted bit not null
)
create table Type
(
ID int not null primary key identity(1,1),
Type nvarchar(20) not null,
Description nvarchar(50) not null,
Filter_id int not null,
IsDeleted bit not null
Constraint FK_Type_Product foreign key (Filter_id) references Filter(ID)
)
create table Product
(
ID int not null primary key identity(1,1),
Name nvarchar(50) not null,
Description nvarchar(300) not null,
Avaible bit not null,
Type_id int not null,
IsDeleted bit not null
Constraint FK_Product_Type foreign key (Type_id) references Type(ID)
)
create table Cart
(
Users_id int not null,
Product_id int not null,
Amount int not null,
IsDeleted bit not null
Constraint FK_Cart_Users foreign key (Users_id) references Users(ID),
Constraint FK_Cart_Product foreign key (Product_id) references Product(ID)
)
create table Delivery
(
ID int not null primary key identity(1,1),
Courier_id int not null,
Date date not null,
Address nvarchar(50) not null,
IsDeleted bit not null
Constraint FK_Delivery_Users foreign key (Courier_id) references Users(ID)
)
create table Status
(
ID int not null primary key identity(1,1),
Status nvarchar(20) not null,
Description nvarchar(50) not null,
IsDeleted bit not null
)
create table Orders
(
ID int not null primary key identity(1,1),
Price decimal(30,2) not null,
Status_id int not null,
Date date not null,
Users_id int not null,
Product_id int not null,
Delivery_id int not null,
IsDeleted bit not null
Constraint FK_Orders_Users foreign key (Users_id) references Users(ID),
Constraint FK_Orders_Product foreign key (Product_id) references Product(ID),
Constraint FK_Orders_Delivery foreign key (Delivery_id) references Delivery(ID),
Constraint FK_Orders_Status foreign key (Status_id) references Status(ID)
)

go

```

<img width="727" alt="image" src="https://user-images.githubusercontent.com/64079766/222714327-84c9d0b5-7f85-40c5-ae7b-059baf0cb462.png">

<h2>Создание целей</h2>
  
<img width="875" alt="image" src="https://user-images.githubusercontent.com/64079766/224269602-391753f0-745e-4a15-a1fd-18793bc7efbd.png">

<h1 align="center">Practice #5</h1>

<h2>Логика, подключение к бд</h2>

<img width="1212" alt="image" src="https://user-images.githubusercontent.com/64079766/230577245-d96ae422-1ad1-4af7-9f6f-d73cbb88070e.png">

<h2>User controller</h2>

<img width="294" alt="image" src="https://user-images.githubusercontent.com/64079766/230578716-777a9ee7-3fa1-481c-a578-5285d4cad687.png">



