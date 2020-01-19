Feature: Retriving User Photo Content
	In order to view my content
	As a content viewer
	I want to be able to retrieve my photos and albums

@User_Photo_Content
Scenario: No photos or albums found for Nested Content

	Given The user does not have any content
	When the data is requested
	Then the resulting HTTP Status code should be 404


Scenario Outline: User content exists

	Given The user has <NoPhotos> and <NoAlbums>
	When the data is requested
	Then the resulting HTTP Status code should be 200
	And the result should contain <NoPhotos> photos
	And the result should contain <NoAlbums> albums
	And The content should be formatted as <contentFormat> 

Examples:
| NoPhotos | NoAlbums |
| 0        | 1        |
| 1        | 0        | 
| 1        | 1        |
| 2        | 1        |
| 1        | 2        |
| 2        | 2        |

# Thinking about testing the unhappy pathways. 
# ============================================
# Although the data has no photos without an album in theory it could happen.
# Equally albums could possibly exist without photos

# Thinking about testing the ideal pathways. 
# ============================================
# * a single photo in a single album
# * multiple photos in a single album
# * multiple photos in multiple albums (though not simultaneously i.e. many to many at present).

