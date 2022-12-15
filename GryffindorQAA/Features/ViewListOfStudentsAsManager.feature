Feature: ViewListOfStudentsAsManager

A short summary of the feature

Scenario: View List Students As Manager
	Given Registration as student
	| FirstName | LastName | Patronymic | Email          | Username | Password | City     | BrithDate  | GithHUbAccount | PhoneNumber  |
	| Daniel    | Martin   | Pitt       | drep@gmail.com | Drep     | daniello | Kurdemir | 23.03.2003 | drep33         | +78884445454 |
	And Auth as Admin
	And Get all list students
	And Give the student the role of a manager
	And Open auth page
	And Fill out form
	| Email          | Password |
	| drep@gmail.com | daniello |
	And Click sing in
	When Click 
