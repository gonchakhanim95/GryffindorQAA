Feature: EditLinkToHomeworkAsStudent

A short summary of the feature

@tag1
Scenario: EditLinkToHomeworkAsStudent
	Given Registration new User for Tutor
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email           | PhoneNumber  | Username | City            | GitHubAccount |
	| Галкин   | Tutor1    | Федор      | 23.12.1992 | салам1салам | tutor@gmail.com | +75553332255 | ttutorr  | SaintPetersburg | TutorGit      |
	And Registration new User for Teacher
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email             | PhoneNumber  | Username  | City            | GitHubAccount |
	| Галкин   | Teacher1  | Федор      | 23.12.1992 | салам1салам | teacher@gmail.com | +76663332255 | tteacherr | SaintPetersburg | TeacherGit    |
	And Registration new Users for Students
	| LastName | FirstName | Patronymic | BirthDate  | Password    | Email              | PhoneNumber  | Username   | City            | GitHubAccount |
	| Галкин   | Student1  | Федор      | 23.12.1992 | салам1салам | student1@gmail.com | +71113332255 | sstudentt1 | SaintPetersburg | Student1Git   |
	And Authoraized as admin
	| Email                 | Password         |
	| marina@example.com    | marina123456     |
	And Create course
	| Name    | Description   |
	| Course1 | Budet polezno |
	And Create group
	| Name   | GroupStatusId | StartDate  | EndDate    | Timetable | PaymentPerMonth | PaymentsCount |
	| Group1 | Forming       | 01.01.2023 | 03.03.2023 | 60        | 100             | 9             |
	And Give role Tutor to the new user
	And Give role Teacher to the new user
	And Add Tutor in Group
	And Add Teacher in Group
	And Add Students in Group 
	And Create task as Teacher
	| Name  | Description   | Links      | IsRequired |
	| Task1 | taskliviy den | github.com | true       |
	When Open auuthorization page
	And Skip bezopasnost
	And Fill sign in form as teacher
	| Email             | Password    |
	| teacher@gmail.com | салам1салам |
	And Click sign button 
	And Open NewHomeworkPage 
	And Fill form for give  out Homework 
	| StartDate  | EndDate    | HomeworkName | HomeworkDescription   | HomeworkLinks                        |
	| 01.01.2023 | 01.05.2023 | 50 Примеров  | До среды заканчивайте | http://github.com, http://google.com |
	And Click create button
	And Authorized as Student
	And Go to Homework
	And Add link
	And Edit Link
	Then Must be Edited Link
