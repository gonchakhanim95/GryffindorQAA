Feature: GetAllUsers

A short summary of the feature

@tag1
Scenario: Get all user as Manager
	Given Open auth Web page
	And Fill out form Auth 
	| Email              | Password     |
	| marina@example.com | marina123456 |
	And Click button Sing in
	When Click button all users
	Then Get all users