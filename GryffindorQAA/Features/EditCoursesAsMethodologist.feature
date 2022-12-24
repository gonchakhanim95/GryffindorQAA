Feature: EditCoursesAsMethodologist

A short summary of the feature

@tag1
Scenario: Edit courses like a methodist and sing out
	Given Created new User
	| LastName   | FirstName | Patronymic | BirthDate  | Password   | Email            | PhoneNumber  | Username | City            | GitHubAccount |
	| McGonagall | Minerva   | Robert     | 28.12.1934 | helloworld | minerrva@mail.ru | +75558889988 | madam    | SaintPetersburg | @minevra34    |
	And Auth as  Admin
	| Email              | Password     |
	| marina@example.com | marina123456 |
	And Give role a methodist
	And Open web auth page
	When Fill form
	| Email            | Password   |
	| minerrva@mail.ru | helloworld |
	And Sing in
	And Change role on methodist
	And Click Edit courses
	And Make changes
	And Add new Topic
	And Click save
	And Sing out
	Then Must log out
