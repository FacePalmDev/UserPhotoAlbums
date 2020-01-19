Feature: Retriving User Photo Content
	In order to view my content
	As a content viewer
	I want to be able to retrieve my photos and albums

@User_Photo_Content
Scenario: No photos or albums found for Nested Content

	Given The user does not have any content
	When the data is requested
	Then the resulting HTTP Status code should be "404"

Scenario Outline: User content exists

	Given The user has <NoPhotos> and <NoAlbums>
	When the data is requested
	Then the resulting HTTP Status code should be <ExpectedStatus>
	And the result should contain <NoPhotos> photos
	And the result should contain <NoAlbums> albums

Examples:
| NoPhotos | NoAlbums | ExpectedStatus
| 0        | 1        | 200
| 1        | 1        | 200
| 2        | 1        | 200

# I should probably put more cases here...Testing the unhappy path is important too.
# what happens if there are photos that aren't in albums? In the real world I'd go further to test this.

# I initially decided to get a bit adventureous and try some of Bob Martin's suggestions about project structure. 
# Then I spent ages trying to refactor it back to something sensible. 

# I probably shouldn't have experimented with that but I believe that if you don't try you never learn.
# It cost me a lot of time though.

