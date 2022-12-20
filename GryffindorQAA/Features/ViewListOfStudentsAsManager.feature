Feature: ViewListOfStudentsAsManager

A short summary of the feature

Scenario: View List Students As Manager
	Given Registration as student 
	| FirstName | LastName | Patronymic | Email                 | Username | Password | City            | BirthDate  | GitHubAccount | PhoneNumber  |
	| Daniel    | Martin   | Pitt       | daniemartin@gmail.com | Drep     | daniello | SaintPetersburg | 23.03.2003 | @drep33       | +78884445454 |
	And Auth as Admin 
	| Email              | Password     |
	| marina@example.com | marina123456 |
	And Give the student the role of a manager
	And Open auth page for Manager
	And Fill out form Auth 
	| Email                | Password |
	| danimartin@gmail.com | daniello |
	And Click button Sing in
	When Click botton list Students
	And Filter the list
	Then View Studets List
