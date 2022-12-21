Feature: AddNewGroup

A short summary of the feature

@tag1
Scenario: Add new Group as Admin
	Given Created new user
	| FirstName | LastName   | Patronymic | Email             | Username  | Password   | City            | BirthDate  | GitHubAccount | PhoneNumber  |
	| Albus     | Dumbledore | Rowling    | alnwick@gmail.com | Professor | helloworld | SaintPetersburg | 30.06.1881 | @albus        | +78885555555 |
	| Severus   | Snape      | Basilisk   | snape@gmail.com   | Snake     | helloworld | SaintPetersburg | 19.01.1960 | @snape        | +79995554455 |
	And Auth as admin
	| Email              | Password     |
	| marina@example.com | marina123456 |
	And Give role Teacher to the new user 
	And Give role Tutor to the new user
	And Open auth Web page
	When Fill out form for Admin
	| Email              | Password     |
	| marina@example.com | marina123456 |
	And Click sing in
	And Click button create group
	And Enter group name "Slyzerin"
	And Select Tutor and Teacher
	And Click Save
	And Click Groups
	Then View group Slyzerin
