Feature: FilterPaymentTableAsManager

A short summary of the feature

@tag1
Scenario: FilterPaymentTableAsManager
	And Authoraized as admin
	| Email                 | Password         |
	| marina@example.com    | marina123456     |
	And Create course
	| Name | Description   |
	| dev  | Budet polezno |
	And Create group
	| Name | GroupStatusId | StartDate  | EndDate    | Timetable | PaymentPerMonth | PaymentsCount |
	| qaa  | Forming       | 01.01.2023 | 05.05.2023 | 60        | 100             | 4             |
	Given  Registration new Users for Students 
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email           | PhoneNumber  | Username | City            | GitHubAccount |
	| Абаев    | Student   | Fedor      | 23.12.1992 | салам1салам | messi@gmail.com | +71113332255 | sstudent | SaintPetersburg | StudentGit    |
	And Add New Students in Group
	And Registration new Users for Students
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email             | PhoneNumber  | Username | City            | GitHubAccount |
	| Бабиров  | Student   | Fedor      | 23.12.1993 | салам1салам | ronaldo@gmail.com | +71113332256 | studentt | SaintPetersburg | StudentGit    |
	And Add New Students in Group
	And Registration new Users for Students
	| LastName  | FirstName | Patronymic | BirthDate  | Password    | Email             | PhoneNumber  | Username  | City            | GitHubAccount |
	| Велиханов | Student   | Fedor      | 23.12.1994 | салам1салам | mbapppe@gmail.com | +71113332257 | sstudentt | SaintPetersburg | StudentGit    |
	And Add New Students in Group
	And Registration new Users for Students
	| LastName  | FirstName | Patronymic | BirthDate  | Password    | Email              | PhoneNumber  | Username | City            | GitHubAccount |
	| Джаббаров | Student   | Fedor      | 23.12.1995 | салам1салам | leletepe@gmail.com | +71113332258 | student  | SaintPetersburg | StudentGit    |
	And Add New Students in Group
	And Registration new User for Manager
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email              | PhoneNumber  | Username  | City            | GitHubAccount |
	| Гаджиев  | Manager   | Федор      | 23.12.1992 | салам1салам | managger@gmail.com | +71113332255 | mmanagerr | SaintPetersburg | ManagerGit    |
	And Give role manager
	And Add Manager in Group
	And Open auth Web page
	When Authorized  as Manager
	| Email              | Password    |
	| managger@gmail.com | салам1салам |
	And Open Payment table page
	Then Must be added Group in Payment page


