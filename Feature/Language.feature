Feature: Languge

Seller is able to add,update and delete languages to profile page

@mytag
Scenario Outline: 1 Add languages to Profile
	Given I have accessed Skillswap website
	When I enter login details
	When I add '<Language>' and '<LanguageLevel>' to Languages tab
	Then The '<Language>' should be created successfully.

Examples: 
	| Language   | LanguageLevel    |
	| English    | Fluent           |
	| Malayalam  | Native/Bilingual |

@mytag    
Scenario Outline: 2  update language in Language tab
	Given Click on Edit Button near '<Language>'
	When I update '<Language1>' and '<LanguageLevel1>' in Languages tab
	Then The '<Language1>' and '<LanguageLevel1>' should be updated successfully.
	 
Examples: 
	| Language | Language1 | LanguageLevel1 |
	| English  | Hindi     | Basic          |
@mytag
Scenario: 3 delete language in Language tab
	Given Navigate to the Languages tab
	When  I delete a '<Language1>' in Languages tab
    Then The '<language1>' should be deleted successfully

	Examples:
	| Language1 |
	|  Hindi    |