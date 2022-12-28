Feature: EditProfileAsStudent

A short summary of the feature

@tag1
Scenario: Edit
	Given Open  registration page
	And Fill out form
	| LastName | FirstName | Patronymic | BirthDate  | Password  | RepeatPassword | Email              | Phone        |
	| Axmedova | Sevinc    | Arif       | 01.04.1996 | 123456789 | 123456789      | mina123456@mail.ru | +79991234567 |
	And Click  button registered
	And Must  come out inscription "Добро пожаловать!!"
	And Open  Auth as student 
	And Fill out form for Auth
	| Email            | Password  |
	| mina123456@mail.ru | 123456789 |
	And Press button sing in
	When Click to button Настройки
	And Fill out form for edit
	| LastName | FirstName | Patronymic | BirthDate  | OldPassword | NewPassword | RepeatPassword | Email            | GitHub                     | Phone        |
	| Aliyeva  | Mina      | Arif       | 01.04.1996 | 123456789   | mina1234    | mina1234       | mina1234@mail.ru | https://github.com/Mina123 | 79991234567 |
	And Click to button Сохранить
	Then Must to change
