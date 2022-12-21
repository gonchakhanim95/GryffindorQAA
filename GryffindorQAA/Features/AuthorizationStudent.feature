Feature: AuthorizationStudent

A short summary of the feature

Scenario: Authorization As student
	Given Open web registration page 
	When Fill out form
	| LastName | FirstName | Patronymic | BirthDate  | Password  | RepeatPassword  | Email           | Phone        |
	| Jafarova | Leyla     | Rufat      | 25.01.2001 | 12345678n | 12345678n       | nika4@gmail.com | +79995584567 |
	And Click button registration
	And Registration complete "Добро пожаловать!!"
	And Open auth page
	And Fill auth form 
	| Email            | Password    |
	| "nika4@gmail.com | "12345678n" |
	And Click button sign in 
	Then Authorization completed