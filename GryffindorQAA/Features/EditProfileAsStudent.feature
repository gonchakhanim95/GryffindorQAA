Feature: EditProfileAsStudent

A short summary of the feature

@tag1
Scenario: Edit
	Given Open registration page
	And Fill out form
	| LastName   | FirtsName  | Patronymic | BirthDate  | Password    | RepeatPassword     | Email                 | Phone           |
	| Axmedova   |	  Sevinc  |   Arif     | 01.04.1996  | 123456789  | 123456789          | mina1234@mail.ru      | +79991234567    |
	And Click to button Registration
	And You have message "Добро пожаловать!"
	And Open autorization page
	And Fill out form
	| Email                | Password    |
	| mina1234@mail.ru     | 123456789   |
	And Click to button Войти
	When Click to button Настройки
	And Fill out forms
	| LastName | FirstName | Patronymic | BirthDate  | OldPassword | NewPassword | RepeatPassword  |  Email         | GitHub                     | Phone        |     
	| Axmedova | Mina      | Arif       | 01.04.1996 | 123456789   | mina1234    | mina1234        | mina@mail.ru   | https://github.com/Mina123 | +79991234567 |
	And Click to change password
	And Click to old password
	And Click new password
	And Click repeat new password
	And Click to button Сохранить Password
	And Click to button Back
	And Click to button Сохранить
	Then Must to change
