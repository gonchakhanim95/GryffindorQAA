Feature: AddNewGroup

A short summary of the feature

@tag1
Scenario: Add new Group as Admin
	Given Created new user
	| FirstName | LastName   | Patronymic | Email            | Username  | Password   | City    | BirthDate  | GitHubAccount | PhoneNumber  |
	| Albus     | Dumbledore | Rowling    | hogwarts@mail.ru | Professor | helloworld | Alnwick | 30.06.1881 | @albus        | +78885555555 |
	| Severus   | Snape      | Basilisk   | severus@mail.ru  | Snake     | helloworld | Alnwick | 00.01.1960 | @snape        | +79995554455 |
	And Auth as admin
	| Email          | Password     |
	| marina@example | marina123456 |
	And Give role Teacher to the new user 
	And Give role Tutor to the new user
	And Create new group Slyzerin
	And Open auth Web page
	When Fill out form for Admin
	| Email              | Password     |
	| marina@example.com | marina123456 |
	And Change mine role on Admin
	And Click button group
	And Select Slyzerin 
	Then View group "Slyzerin"
