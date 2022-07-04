Feature: Login
	As a seller I want to login to the skillswap website

@mytag
Scenario Outline: I Login to the Skillswap website with valid credentials
	Given I have accessed Skillswap website
	When I enter login details
	Examples: 
	| Email                    | Password        |
	| joseph_jjo35@hotmail.com | Midhuj          |