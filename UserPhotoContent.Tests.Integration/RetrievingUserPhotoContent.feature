Feature: Retriving User Photo Content
	In order to view my content
	As a content viewer
	I want to be able to retrieve my photos and albums

@User_Photo_Content
Scenario: No photos or albums found for Nested Content

	Given The user does not have any content
	When the data is requested in "Nested" format
	Then the resulting HTTP Status code should be 404


Scenario Outline: User content exists

	Given The user has <NoPhotos> and <NoAlbums>
	When the data is requested <contentFormat> format
	Then the resulting HTTP Status code should be 200
	And the result should contain <NoPhotos> photos
	And the result should contain <NoAlbums> albums
	And The content should be formatted as <contentFormat> 

Examples:
| NoPhotos | NoAlbums | ContentFormat	|
| 0        | 1        | Nested			|
| 0        | 1        | Flat			|
| 1        | 0        | Nested			| 
| 1        | 0        | Flat			|
| 1        | 1        | Nested			|
| 1        | 1        | Flat			|
| 2        | 1        | Nested			|
| 2        | 1        | Flat			|
| 1        | 2        | Nested			|
| 1        | 2        | Flat			|
| 2        | 2        | Nested			|
| 2        | 2        | Flat			|


# The requirements don't specify how you'd like the data to be available.
# Whilst flat data seems to be both simple and easier to process I felt it 
# might be nice to support both Flat and Nested data.

# Thinking about testing the unhappy pathways. 
# ============================================
# Although the data has no photos without an album in theory it could happen.
# Equally albums could possibly exist without photos

# Thinking about testing the ideal pathways. 
# ============================================
# * a single photo in a single album
# * multiple photos in a single album
# * multiple photos in multiple albums (though not simultaneously i.e. many to many at present).

