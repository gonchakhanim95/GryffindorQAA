Feature: ViewHomeworkAsStudent

A short summary of the feature

Scenario: View list of homework as student
	Given Open Auth as student 
	And fill form
	| email         | password     |
	| "said@mail.ru"| "salamsalam" |
	And press button sing in
	When Select homeworks
	When select date
	Then View homeworks