Feature: WatchHomeWorksAsStudent


Scenario: View list of homework as student
	Given open  registration page
	And Fill  out form
	| LastName  | Patronymic | Birth date   | Password     | Repeat password | Email           | Phone          |
	| "Saidli"  | "Farid"    | "03.08.1999" | "salamsalam" | "salamsalam"    | "saidli@mail.ru | "+78885551122" |
	And Click  button registered
	And Must  come out inscription wellcome
	And Open  Auth as student 
	And fill  form
	| email         | password     |
	| "said@mail.ru"| "salamsalam" |
	And press  button sing in
	And Should  entered into system
	When Select  homeworks
	And select  date
	Then View  homeworks