Feature: RegistrationStudent

@tag1
Scenario: Registration
	Given Open registration page
	When Fill out forms
	| FirstName | LastName | Patronymic | BirthDate  | Password | RepeatPassword | Email          | PhoneNumber  |
	| Axmedova  | Mina     | Arif       | 01.04.1996 | mina0104 | mina0104       | mina@gmail.com | +79991234567 |
	And Click to button Registration
	Then You have successfully registreted
