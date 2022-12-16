Feature: ViewListOfStudentsAsManager

A short summary of the feature

Scenario: View List Students As Manager
	Given Registration as student
	| FirstName | LastName | Patronymic | Email                   | Username | Password | City            | BrithDate  | GitHubAccount | PhoneNumber  |
	| Daniel    | Martin   | Pitt       | asdfgbgjhjjkk@gmail.com | Drep     | daniello | SaintPetersburg | 23.03.2003 | @drep33       | +78884445454 |
	And Auth as Admin,Get all list students,Give the student the role of a manager
	And Open auth page
	And Fill out form
	| Email                   | Password |
	| asdfgbgjhllkk@gmail.com | daniello |
	And Click sing in
	When Click 
