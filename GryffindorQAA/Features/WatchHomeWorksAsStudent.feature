Feature: WatchHomeWorksAsStudent


Scenario: View list of homework as student
	Given open  registration page
	And Fill out form
	| LastName | FirstName | Patronymic | BirthDate  | Password   | RepeatPassword  | Email                 | Phone        |
	| Saidov   | Farid     | Axmed      | 03.08.1999 | salamsalam | salamsalam      | saidllifaridd@mail.ru | +78885551122 |
	And Click  button registered
	And Must  come out inscription "Добро пожаловать!!"
	And Open  Auth as student 
	And fill  form
	| email               | password     |
	| saidlifarid@mail.ru | "salamsalam" |
	And press  button sing in
	And Should  entered into system
	When Select homeworks
	Then View  homeworks