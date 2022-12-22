Feature: CreateTeacher


@admistrator
Scenario: Create Teacher
	Given Registration new User
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email                | PhoneNumber  | Username | City            | GitHubAccount |
	| Галкин   | Максим    | Федор      | 23.12.1992 | салам1салам | maksimuska@gmail.com | +75553332255 | mmaksimm | SaintPetersburg | MaksGit       |
    And Authoraized as admin 
	| Email                 | Password         |
	| marina@example.com    | marina123456     |
	And Give role teacher to the new User
	When Open auuthorization page
	And Skip bezopasnost
	And Fill sign in form as teacher
	| Email               | Password    |
	| maksimuska@gmail.com | салам1салам |
	And Click sign button 
	Then Login as a teacher
	
