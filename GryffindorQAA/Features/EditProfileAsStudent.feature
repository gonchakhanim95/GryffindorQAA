Feature: EditProfileAsStudent

A short summary of the feature

@tag1
Scenario: Edit
	Given Open registration page
	And Fill out form
	| LastName   | FirtsName | Patronymic | Birth date  | Password   | Repeat password | Email           | Phone number   |
	| Haciyeva   | Qonce     |   Zakir    | 31.03.1996  | qnmz1234   | qnmz1234        | mika@gmail.com  | +79991234567   |
	And Click to button Registration
	And You have message Добро пожаловать!
	And Open autorization page
	And Fill out form
	| Email            | Password   |
	| mika@gmail.com   | qnmz1234   |
	And Click to button Войти
	When Click to button Настройки
	And Fill out form
	| LastName | FirstName | Patronymic | Birthdate  | Password | Email          | Phone       |  
	| Axmedova | Mina      |  Arif      | 01.04.1996 | mina1234 | mika@gmail.com | +7123456789 |
	And Click to password
	And Click to old password
	And Click new password
	And Click repeat new password
	And Click to button Сохранить
	Then Must to change
