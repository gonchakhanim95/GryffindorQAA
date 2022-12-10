Feature: ViewListOfStudentsAsManager

A short summary of the feature

Scenario: Auth as Manager
	Given Open auth page
	When Add email "marina@example.com"
	And Add password "marinamarina"
	And Click button sing in
	Then is included in the system



Scenario: View a list of students as Manager
	Given Auth as Manage
	When Click to spisok studentov
	And Filter by vice versa
	Then View a list of students
