Feature: Education

Seller is to add Education to the profile

@mytag
Scenario Outline: Add Education to Profile
	Given Navigate to Education tab
	When I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education tab
	Then The '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' should be created successfully.

Examples: 
	| Country | University           | Title  | Degree                         | Year |
	| India   | Mahatma Gandhi       | B.Tech | Computer Science Engineering   | 2013 |
	
