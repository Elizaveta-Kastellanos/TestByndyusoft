Feature: Contact_Information_Verification

1.) Contact information verification

@MainWindow
Scenario: As a user, I want to click on the button "Order a presentation"
	Given Open google chrome browser with <Length> and <Width>
	And   I go to the right url
	And   I enter "Byndyusoft" in the search box and follow the first link
	When  I find and click on the button Order a presentation
	Then  I check the correctness of the phone number and mailbox, expected phone number "8 800 775-15-21" and e-mail "sales@byndyusoft.com"
	Examples: 
	| Length | Width |
	| 1920   | 1080  |
