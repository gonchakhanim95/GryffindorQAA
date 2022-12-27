Feature: AddProfilePhoto

A short summary of the feature

@tag1
Scenario: Add profile photo as student
	Given Open  registration page
	And Fill out form
	| LastName | FirstName | Patronymic | BirthDate  | Password   | RepeatPassword | Email          | Phone        |
	| Potter   | Harry     | James      | 11.06.1980 | helloworld | helloworld     | harry@mail.com | +78882211233 |
	And Click  button registered
	And Must  come out inscription "Добро пожаловать!!"
	And Open  Auth as student 
	And Fill out form for Auth
	| Email          | Password   |
	| harry@mail.com | helloworld |
	And Press button sing in
	When Open setting 
	And Click on profile photo
	And Select photo
	And Change profile photo
	Then Photo profile should change
