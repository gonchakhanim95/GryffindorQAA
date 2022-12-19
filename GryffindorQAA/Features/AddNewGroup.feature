Feature: AddNewGroup

A short summary of the feature

@tag1
Scenario: Add new Group as Admin
	Given Created new user
	| FirstName | LastName   | Patronymic | Email            | Username  | Password   | City    | BirthDate  | GitHubAccount | PhoneNumber  |
	| Albus     | Dumbledore | Rowling    | hogwarts@mail.ru | Professor | helloworld | Alnwick | 30.06.1881 | @albus        | +78885555555 |
	And Auth as admin
	| Email          | Password     |
	| marina@example | marina123456 |
	And Give role Admin to the new user
	And Auth as new Admin
	| Email            | Password   |
	| hogwarts@mail.ru | helloworld |
	And Create new group Slyzerin
	When Open auth Web page
	And Auth as our admin
	| Email            | Password   |
	| hogwarts@mail.ru | helloworld |
	And Change mine role on Admin
	And Click button group
	And Select new Slyzerin 
	Then View group Slyzerin
