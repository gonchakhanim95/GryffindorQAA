Feature: AddNewLessinAsTeacher


Scenario: Add new lesson as teacher
	Given Registration new User for Tutor
	| LastName | FirstName | Patronymic | BirthDate  | Password   | Email           | PhoneNumber  | Username | City            | GitHubAccount |
	| Rubeus   | Hagrid    | Hagrid     | 06.12.1928 | helloworld | hagrid@mail.eng | +74445554466 | hagrid   | SaintPetersburg | @hagrid       |
	And Registration new User for Teacher
	| LastName | FirstName | Patronymic | BirthDate  | Password   | Email           | PhoneNumber  | Username | City            | GitHubAccount |
	| Severus  | Snape     | Tobias     | 19.01.1960 | helloworld | snape@gmail.eng | +79995554455 | Snake    | SaintPetersburg | @snape        |
	And Registration new Users for Students
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email              | PhoneNumber  | Username   | City            | GitHubAccount |
	| Галкин   | Student1  | Федор      | 23.12.1992 | салам1салам | student1@gmail.com | +71113332255 | sstudentt1 | SaintPetersburg | Student1Git   |
	And Authoraized as admin
	| Email                 | Password         |
	| marina@example.com    | marina123456     |
	And Create course
	| Name  | Description |
	| Magic | Black Magic |
	And Create group
	| Name     | GroupStatusId | StartDate  | EndDate    | Timetable | PaymentPerMonth | PaymentsCount |
	| Slyzerin | Forming       | 28.12.2022 | 28.03.2023 | 60        | 380             | 9             |
	And Give role Tutor to the new user
	And Give role Teacher to the new user
	And Add Tutor in Group
	And Add Teacher in Group
	And Add Students in Group
	And Open auth Web page
	And Fill out form Auth
	| Email           | Password   |
	| snape@gmail.eng | helloworld |
	And Press button sing in
	When Change role on teacher
	Then Add new lesson