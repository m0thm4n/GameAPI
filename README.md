Video Game API for .Net Blue Badge Project 
Created by Team Purple (Nathan Moritz, Kyle Johnson, and Blake Kendall)

This API allows you access information about video games. There are different endpoints for the four major video game platforms: Xbox One, Playstation 4, PC, and Nintendo Switch. The foreign keys relate back to the Developer and Publisher for each video game.

Information needed when creating new videos games includes a Name or Title, a rating (expressed as a double), a price, a Maturity Rating (ex. E, 10+, T, M, etc), a genre, a developer id (a Foreign Key), and a publisher id (a second Foreign Key).

The database has been pre-seeded with the top ten best-selling video games for each platform (according to Wikipedia, see links below for those lists), along with their corresponding developers and publishers. 
NOTE: after downloading/cloning this repository, you will need to add a migration and Update-Database to bring in the seeded content! 
Since a developer and publisher will be needed when creating a new video game, here are the existing pre-seeded Foreign Keys for reference (more can be added through the CRUD enpoints for Developer and Publisher respectively):

Developers: 
    1. Naughty Dog 
    2. Insomniac Games 
    3. CD Projekt Red 
    4. Santa Monica Studio 
    5. Guerrilla Games 
    6. Polyphony Digital 
    7. Capcom 
    8. Square Enix 
    9. P-Studio 
    10. Nintendo EPD 
    11. Bandai Namco Studios 
    12. Game Freak
    13. ND Cube
    14. Rockstar North 
    15. Treyarch
    16. Sledgehammer Games
    17. Rockstar Studios
    18. Mojang Studios
    19. EA DICE 
    20. Bethesda Game Studios
    21. 343 Industries 
    22. Infinity Ward 
    23. PUBG Corporation
    24. Blizzard Entertainment
    25. Re-Logic
    26. Maxis
    27. Facepunch Studios
    28. Frontier Developments
    29. Valve Software

Publishers:
    1. Sony Interactive Entertainment
    2. CD Project S.A. 
    3. Capcom 
    4. Atlus 
    5. Nintendo
    6. The Pokemon Company
    7. Rockstar Games 
    8. Activision 
    9. Microsoft Studios 
    10. Electronic Arts 
    11. Bethesda Softworks 
    12. Square Enix
    13. PUBG Corporation
    14. Blizzard Entertainment
    15. Re-logic
    16. Facepunch Studios
    17. Atari, Inc.
    18. Valve Software

You can do CRUD for each type of video game platform, with the Read method for each containing a Get by Id and a Get All endpoint. 

Websites used for reference in pre-seeding the database include:
https://en.wikipedia.org/wiki/List_of_best-selling_Xbox_One_video_games
https://en.wikipedia.org/wiki/List_of_best-selling_Nintendo_Switch_video_games
https://en.wikipedia.org/wiki/List_of_best-selling_PlayStation_4_video_games
https://en.wikipedia.org/wiki/List_of_best-selling_PC_games
https://www.metacritic.com/ (for misc game information not found through Wikipedia such as game ratings)

Enjoy!
