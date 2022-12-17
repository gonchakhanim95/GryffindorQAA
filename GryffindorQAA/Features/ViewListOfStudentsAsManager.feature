Feature: ViewListOfStudentsAsManager

A short summary of the feature

Scenario: View List Students As Manager
	Given Registration as student and Auth as Admin and give the student the role of a manager
	| FirstName | LastName | Patronymic | Email                   | Username | Password | City            | BrithDate  | GitHubAccount | PhoneNumber  |
	| Daniel    | Martin   | Pitt       | asdfgbgjhjjkk@gmail.com | Drep     | daniello | SaintPetersburg | 23.03.2003 | @drep33       | +78884445454 |
	And Open auth page for Manager
	And Fill out form Auth 
	| email                   | password |
	| asdfgbgjhllkk@gmail.com | daniello |
	And Click button Sing in
	When Click botton list Students
