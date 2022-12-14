Feature: Feature1

A short summary of the feature

@tag1
Scenario: Receive notifications as student
	Given Open registration page
	And   Fill out form
	| LastName | Firstname | Patronymic | Birth Date | Password | Email         |   Phone      |
	| Mamedova | Leyla     | Rufat      | 25.01.2001 | 12345678   | ljr@mail.ru | +78889922222 |
	And Click the registration button
    And Registration complete "Добро пожаловать!"
	And Open autorization page
	And Fill out form
	| Email            | Password    |
	| "ljr@mail.com    | 12345678    |
	And Click the sign in
	When Select chapter notification
	Then Get all notifications
