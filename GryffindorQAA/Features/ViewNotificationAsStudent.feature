Feature: ReceiveNotifications



@tag1
Scenario: Receive notifications as student
	Given Open registration page
	And   Fill out form
	| LastName | Firstname | Patronymic | BirthDate  | Password | RepeatPassword | Email       | Phone        |
	| Mamedova | Leyla     | Rufat      | 25.01.2001 | 12345678 | 12345678       | ljr@mail.ru | +78889922222 |
	And Click button registered
    And Must come out inscription "Добро пожаловать!!"
	And Open Auth as student
	And Fill out form for Auth
	| Email       | Password |
	| ljr@mail.ru | 12345678 |
	And Press button sign in
	When Select chapter notification
	Then Get all notifications
