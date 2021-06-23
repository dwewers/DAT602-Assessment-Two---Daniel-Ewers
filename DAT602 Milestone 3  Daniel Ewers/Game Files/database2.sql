DROP DATABASE IF EXISTS dat602_assessmentdb_m2;
CREATE DATABASE dat602_assessmentdb_m2;
USE dat602_assessmentdb_m2;
SET SQL_SAFE_UPDATES=0;   

DROP PROCEDURE IF EXISTS `createtbl`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `createtbl`()
BEGIN

DROP TABLE IF EXISTS `tbl_game`;
CREATE TABLE `tbl_game` (
	`gameID` INTEGER NOT NULL AUTO_INCREMENT ,
	`gameNumber` INTEGER DEFAULT 0 NOT NULL ,
	`numberOfPlayers` INTEGER DEFAULT 0 NOT NULL,
	`gameMode` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`gameID`) 
);
DROP TABLE IF EXISTS `tbl_asset`;
CREATE TABLE `tbl_asset` (
	`assetID` INTEGER NOT NULL AUTO_INCREMENT,
	`asset_name` VARCHAR(50) NOT NULL,
	`asset_type` VARCHAR(50) NOT NULL,
	`asset_value` INTEGER DEFAULT 0 NOT NULL,
    `gameID` INTEGER DEFAULT 0 NOT NULL,
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`) ON DELETE CASCADE,
	PRIMARY KEY (`assetID`)
);

DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE `tbl_user` (
	`userID` INTEGER NOT NULL AUTO_INCREMENT,
	`username` VARCHAR(50) NOT NULL UNIQUE,
	`user_password` VARCHAR(20) NOT NULL,
	`user_email` VARCHAR(20) NOT NULL,
    `user_loginStatus` TINYINT(1) DEFAULT FALSE NOT NULL,
	`user_loginAttempts` INTEGER DEFAULT 0 NOT NULL,
	`user_accountStatus` TINYINT(1) NOT NULL,
	`user_isAdmin` TINYINT(1) DEFAULT FALSE NOT NULL,
	PRIMARY KEY (`userID`) 
);

DROP TABLE IF EXISTS `tbl_board`;
CREATE TABLE `tbl_board` (
	`boardID` INTEGER NOT NULL AUTO_INCREMENT,
	`gameID` INTEGER NOT NULL,
	PRIMARY KEY (`boardID`),
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`) ON DELETE CASCADE 
);

DROP TABLE IF EXISTS `tbl_gameChat`;
CREATE TABLE `tbl_gameChat` (
	`chatID` INTEGER NOT NULL AUTO_INCREMENT,
	`text` VARCHAR(255),
	`gameID` INTEGER NOT NULL,
	PRIMARY KEY (`chatID`),
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`) ON DELETE CASCADE  
);

DROP TABLE IF EXISTS `tbl_tile`;
CREATE TABLE `tbl_tile` (
	`tileID` INTEGER NOT NULL AUTO_INCREMENT,
	`boardID` INTEGER NOT NULL,
	`tileNumber` INTEGER DEFAULT NULL,
	`tilePlayer` VARCHAR(100) DEFAULT NULL,
	PRIMARY KEY (`tileID`),
	FOREIGN KEY (`boardID`) REFERENCES `tbl_board`(`boardID`) ON DELETE CASCADE 
);

DROP TABLE IF EXISTS `tbl_assettile`;
CREATE TABLE `tbl_assettile` (
	`assetTileID` INTEGER NOT NULL AUTO_INCREMENT,
	`assetID` INTEGER NOT NULL UNIQUE,
	`tileID` INTEGER NOT NULL UNIQUE,
	PRIMARY KEY (`assetTileID`),
	FOREIGN KEY (`tileID`) REFERENCES `tbl_tile`(`tileID`) ON DELETE CASCADE,  
	FOREIGN KEY (`assetID`) REFERENCES `tbl_asset`(`assetID`) ON DELETE CASCADE  
);

DROP TABLE IF EXISTS `tbl_player`;
CREATE TABLE `tbl_player` (
	`playerID` INTEGER NOT NULL AUTO_INCREMENT,
	`player_score` INTEGER DEFAULT 0 NOT NULL,
	`Character` VARCHAR(20) DEFAULT NULL,
	`gameID` INTEGER DEFAULT NULL,
	`tileNumber` INTEGER DEFAULT NULL,
	`userID` INTEGER NOT NULL,
	PRIMARY KEY (`playerID`) ,
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`),
	FOREIGN KEY (`userID`) REFERENCES `tbl_user`(`userID`) ON DELETE CASCADE   
);

DROP TABLE IF EXISTS `tbl_inventory`;
CREATE TABLE `tbl_inventory` (
	`inventoryID` INTEGER NOT NULL AUTO_INCREMENT,
	`quantity` INTEGER DEFAULT 0 NOT NULL,
	`assetID` INTEGER DEFAULT NULL,
	`playerID` INTEGER NOT NULL,
	PRIMARY KEY (`inventoryID`),
	FOREIGN KEY (`assetID`) REFERENCES `tbl_asset`(`assetID`)   ,
	FOREIGN KEY (`playerID`) REFERENCES `tbl_player`(`playerID`)  ON DELETE CASCADE   
);

DROP TABLE IF EXISTS `tbl_leaderboard`;
CREATE TABLE `tbl_leaderboard` (
	`leaderboardID` INTEGER NOT NULL AUTO_INCREMENT,
	`totalScore` INTEGER DEFAULT 0 NOT NULL,
	`gamesPlayed` INTEGER DEFAULT 0 NOT NULL,
    `averageScore` INTEGER AS (totalscore /gamesPlayed),
	`player_score` INTEGER DEFAULT 0 NOT NULL,
	`userID` INTEGER NOT NULL,
	`playerID` INTEGER NOT NULL,
	PRIMARY KEY (`leaderboardID`),
	FOREIGN KEY (`userID`) REFERENCES `tbl_user`(`userID`)  ON DELETE CASCADE,
	FOREIGN KEY (`playerID`) REFERENCES `tbl_player`(`playerID`) ON DELETE CASCADE
);
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `TestData`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `TestData`()
BEGIN
	-- Admin
	INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) 
		VALUES('daniel', '123', 'email@email', 0, FALSE, TRUE);
    
	INSERT INTO `tbl_player` (`player_score`, `Character`, `gameID`, `tileNumber`, `userID`) 
		VALUES(0, NULL, NULL, NULL, 1);
    
	INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) 
		VALUES(0, NULL, 1);
    
	INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `player_score`,`playerID`, `userID`) 
		VALUES(0, 0, 0, 1,1);

	-- Extra Test Data
	INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) 
		VALUES('steven', 'abc', 'email123@email', 0, FALSE, TRUE);
    
	INSERT INTO `tbl_player` (`player_score`, `Character`, `gameID`, `tileNumber`, `userID`) 
		VALUES(0, NULL, NULL, NULL, 2);
    
	INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) 
		VALUES(0, NULL, 2);
    
	INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `player_score`,`playerID`, `userID`) 
		VALUES(52000, 30, 0, 2,2);

	INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) 
		VALUES('billy', '321', 'emailabc@email', 0, FALSE, FALSE);
    
	INSERT INTO `tbl_player` (`player_score`, `Character`, `gameID`, `tileNumber`, `userID`) 
		VALUES(0, NULL, NULL, NULL, 3);
    
	INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) 
		VALUES(0, NULL, 1);
    
	INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `player_score`,`playerID`, `userID`) 
		VALUES(1500, 2, 0, 3,3);

	INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) 
		VALUES('richard', 'cba', 'emailxyz@email', 0, FALSE, FALSE);
    
	INSERT INTO `tbl_player` (`player_score`, `Character`, `gameID`, `tileNumber`, `userID`) 
		VALUES(0, NULL, NULL, NULL, 4);
    
	INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) 
		VALUES(0, NULL, 1);
    
	INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `player_score`,`playerID`, `userID`) 
		VALUES(100240, 150, 0, 4,4);
END$$
DELIMITER ;

CALL createtbl();
CALL TestData();

DROP PROCEDURE IF EXISTS `AdminAccountStatus`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdminAccountStatus`(IN uname VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	IF EXISTS(
		SELECT username 
		FROM tbl_user 
		WHERE username = uname) 
			THEN
				IF (
					SELECT user_accountStatus 
					FROM tbl_user 
					WHERE username = uname) IS FALSE 
						THEN
							UPDATE tbl_user 
							SET user_accountStatus = TRUE 
							WHERE username = uname;
				ELSE 
					UPDATE tbl_user 
					SET user_accountStatus = FALSE 
					WHERE username = uname;
				END IF;
		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `AdminCreateUser`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdminCreateUser`(IN `uname` VARCHAR(100), `pwd` VARCHAR(100), `email` VARCHAR(100), `priv` TINYINT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	INSERT INTO tbl_user (username, user_email, user_password, user_loginAttempts, user_accountStatus, user_isAdmin) 
        VALUES (uname,email,pwd, 0, 0, priv);
        
	INSERT INTO tbl_player (`player_score`, `Character`, `gameID`, `tileNumber`, `userID`) 
		VALUES(0, NULL, NULL, NULL, LAST_INSERT_ID());
        
	INSERT INTO tbl_leaderboard (totalScore, gamesPlayed, player_score, userID, playerID) 
		VALUES (0,0,0,LAST_INSERT_ID(),LAST_INSERT_ID());
        
	INSERT INTO tbl_inventory (quantity, assetID, playerID) 
		VALUES (0,NULL,LAST_INSERT_ID());

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `AdminDeleteGame`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdminDeleteGame`(IN `game` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	UPDATE tbl_tile 
	SET tilePlayer = NULL 
	WHERE tilePlayer = "daniel" 
	AND boardID = game;
         
	UPDATE tbl_player 
	SET tileNumber = NULL, gameID = NULL 
	WHERE gameID = game;
         
	DELETE FROM `tbl_game` 
	WHERE `gameNumber` = game; 

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `AdminDeleteUser`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdminDeleteUser`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
    IF EXISTS(
		SELECT username 
        FROM tbl_user 
        WHERE username = uname) 
			THEN
				DELETE FROM `tbl_user` 
                WHERE `username` = (uname);	
	END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `LoadChatData`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoadChatData`(IN `gID` int)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
			SELECT `text` 
            FROM tbl_gameChat 
            WHERE gameID = gID;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `AdminResetUser`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdminResetUser`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
    IF EXISTS(
		SELECT username 
        FROM tbl_user 
        WHERE username = uname) 
			THEN
				UPDATE tbl_leaderboard l
                INNER JOIN tbl_user u
                ON l.userID = u.userID
                SET l.totalScore = 0, l.gamesPlayed = 0, l.player_score =0
                WHERE u.username = uname;
	END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `CheckGameNum`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CheckGameNum`(IN gameNum INT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT `gameNumber` 
        FROM `tbl_game` 
        WHERE gameNumber = gameNum;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `CheckIfAdmin`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CheckIfAdmin`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT user_isAdmin 
        FROM tbl_user 
        WHERE username = uname;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `CheckInfo`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CheckInfo`(IN uname VARCHAR(100), pwd VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT username, user_password
        FROM tbl_user 
		WHERE `username` = uname 
		AND `user_password` = pwd;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `checkUsernameSignUp`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `checkUsernameSignUp`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT username 
        FROM `tbl_user` 
        WHERE `username` = uname;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `CheckValid`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CheckValid`(IN tileVal INT, num INT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT tilePlayer
		FROM tbl_tile 
        WHERE tileNumber = tileVal 
        AND boardID = num;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `CreateUserAccount`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateUserAccount`(IN `uname` VARCHAR(100), `pwd` VARCHAR(100), `email` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	INSERT INTO tbl_user (username, user_email, user_password, user_loginAttempts, user_accountStatus, user_isAdmin)
		VALUES(uname, email, pwd,0,0,0);
          
	INSERT INTO tbl_player (`player_score`, `Character`, `gameID`, `tileNumber`, `userID`) 
		VALUES(0, NULL, NULL, NULL, LAST_INSERT_ID());
          
	INSERT INTO tbl_leaderboard (totalScore, gamesPlayed, player_score, userID, playerID) 
		VALUES (0,0,0,LAST_INSERT_ID(),LAST_INSERT_ID());
          
	INSERT INTO tbl_inventory (quantity, assetID, playerID) 
		VALUES (0,NULL,LAST_INSERT_ID());

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `ExitGame`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ExitGame`(IN uname VARCHAR(100), currentTile INT, num INT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		UPDATE tbl_player p
		JOIN tbl_user u
		ON p.userID = u.userID
		SET p.gameID = NULL, p.tileNumber = currentTile
		WHERE u.username = uname;
                
		UPDATE tbl_tile 
		SET tilePlayer = NULL 
		WHERE tilePlayer = uname;
        
		UPDATE tbl_game 
		SET numberOfPlayers = numberOfPlayers -1 
		WHERE gameID = num;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `FailedAttempt`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `FailedAttempt`(IN uname VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
    IF EXISTS(
		SELECT username 
        FROM tbl_user 
        WHERE username = uname) 
			THEN
				UPDATE tbl_user 
                SET user_loginAttempts = user_loginAttempts + 1 
                WHERE(username = uname);
	END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `LoginLock`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoginLock`(IN uname VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		IF (
			SELECT user_loginAttempts 
			FROM tbl_user 
			WHERE username = uname) = 5 
				THEN
					UPDATE tbl_user 
					SET user_accountStatus = 1, user_loginAttempts=0 
					WHERE username = uname;
		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `GetDataLeaderboard`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDataLeaderboard`()
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	SELECT tbl_user.username AS Username, tbl_leaderboard.totalScore AS `Total Score`, tbl_leaderboard.gamesPlayed AS `Games Played`, tbl_leaderboard.averageScore AS `Average Score`
	FROM tbl_leaderboard 
    INNER JOIN tbl_user 
	ON tbl_leaderboard.userID = tbl_user.userID;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `GetGameNumber`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetGameNumber`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT gameID
        FROM tbl_player p 
        INNER JOIN tbl_user u 
        ON p.userID = u.userID 
        WHERE u.username = uname;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;

    END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `GetGameNumbers`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetGameNumbers`()
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	SELECT `gameNumber` FROM `tbl_game`;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `LoadLobbyData`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoadLobbyData`()
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	SELECT tbl_user.username AS Username, tbl_player.gameID AS Game 
	FROM tbl_player 
    INNER JOIN tbl_user 
    ON tbl_player.userID = tbl_user.userID
    WHERE tbl_user.user_loginStatus = 1;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `GetPlayerUsernames`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPlayerUsernames`()
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	SELECT `username` FROM `tbl_user`;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `JoinUser`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `JoinUser`(IN `uname` VARCHAR(100), gameNum INT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	IF EXISTS (
		SELECT username 
		FROM tbl_player p 
		INNER JOIN tbl_user u 
		ON u.userID = p.userID 
		WHERE u.username = uname
		) THEN
        
                UPDATE tbl_player p  
                JOIN tbl_user u  
                ON p.userID = u.userID  
                SET p.gameID = gameNum, p.tileNumber = 1, player_score = 0
                WHERE u.username = uname;
                
                UPDATE tbl_game 
				SET numberOfPlayers = numberOfPlayers + 1 
				WHERE gameID = gameNum;
                            
				UPDATE tbl_tile 
				SET tilePlayer = uname 
				WHERE tileID = 1 
                AND boardID = gameNum;
		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `LoadData`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoadData`(IN uname VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		SELECT user_password, user_email, user_isAdmin, user_accountStatus 
        FROM tbl_user 
        WHERE username = uname;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `Logout`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Logout`(IN uname VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		IF EXISTS(
				SELECT username 
				FROM tbl_user 
				WHERE username = uname
				) 
				THEN
					UPDATE tbl_user 
					SET user_loginStatus = 0 
					WHERE(username = uname);
		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `ResetGame`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ResetGame`(IN num VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	UPDATE tbl_player 
    SET player_score = 0, tileNumber = 1 
    WHERE gameID = num;
    
    UPDATE tbl_tile 
    SET tilePlayer = NULL 
    WHERE tilePlayer IS NOT NULL 
    AND gameID = num;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `setCharacterType`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `setCharacterType`(IN `uname` VARCHAR(100), `charType` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		IF EXISTS(
				SELECT username 
				FROM tbl_user 
				WHERE username = uname
				) 
				THEN
					UPDATE tbl_player p
					JOIN tbl_user u
					ON p.userID = u.userID
					SET p.`Character` = charType
					WHERE u.username = uname;
		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `setGameNumber`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `setGameNumber`(IN `num` INT, `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		IF EXISTS(
				SELECT username 
                FROM tbl_user 
                WHERE username = uname
                ) 
                THEN
					UPDATE tbl_player p 
                    JOIN tbl_user u 
                    ON p.userID = u.userID  
                    SET p.gameID = num 
                    WHERE username = uname;

		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `SetLoggedIn`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SetLoggedIn`(IN uname VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		UPDATE tbl_user 
        SET user_loginStatus = 1, user_loginAttempts=0 
        WHERE(username = uname);

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `UpdatePlayerTile`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePlayerTile`(IN `uname` VARCHAR(100), `tileVal` INT, `lastValue` INT, score INT, num INT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
		IF (
			SELECT tileNumber 
			FROM tbl_player p 
			INNER JOIN tbl_user u 
			ON p.userID = u.userID 
			WHERE username = uname
			)IS NULL 
			THEN
				UPDATE tbl_player p
				JOIN tbl_user u
				ON p.userID = u.userID
				SET p.tileNumber = 1
				WHERE u.username = uname;
		END IF;
		IF(
			SELECT tilePlayer 
			FROM tbl_tile 
			WHERE tileID = tileVal
			) IS NULL
			THEN
				UPDATE tbl_tile 
				SET tilePlayer = NULL 
				WHERE tilePlayer = uname;
				
				UPDATE `tbl_player` p
				INNER JOIN `tbl_user` u
				ON p.playerID = u.userID
				SET
				p.tileNumber = tileVal
				WHERE u.`username` = uname;
				
				UPDATE  tbl_tile t 
				INNER JOIN tbl_player p 
				ON t.tileNumber = p.tileNumber 
				INNER JOIN 
				tbl_User u
				ON u.userID = p.userID
				SET t.tilePlayer = uname
				WHERE u.username = uname 
				AND p.gameID = t.boardID;
				
				UPDATE  tbl_tile 
				SET tilePlayer = NULL 
				WHERE tileID = lastValue 
				AND tilePlayer = uname;
				
				IF EXISTS (
							SELECT username 
							FROM tbl_player p 
							INNER JOIN tbl_user u 
							ON u.userID = p.userID 
							WHERE u.username = uname
							)
							THEN
								IF (
									SELECT @tnum := tileNumber 
									FROM tbl_player p 
									INNER JOIN tbl_user u 
									ON u.userID = p.userID 
									WHERE u.username = uname) = 
									(
									SELECT @tID := tileID 
									FROM tbl_assettile 
									WHERE tileID = @tnum
									) IS TRUE
										THEN
											SELECT @aID := assetID 
											FROM tbl_assettile 
											WHERE tileID = @tnum;
                                            
											SELECT @asset := assetID, @assetVal := asset_value 
											FROM tbl_asset 
											WHERE assetID = @aID;
											
											UPDATE tbl_inventory i
											INNER JOIN tbl_player p
											ON i.playerID = p.playerID
											INNER JOIN tbl_user u
											ON p.userID = u.userID
											SET i.quantity = i.quantity+1, assetID =  @asset
											WHERE u.username = uname;
											
											UPDATE tbl_leaderboard l
											INNER JOIN tbl_player p
											ON l.playerID = p.playerID
											INNER JOIN tbl_user u
											ON p.userID = u.userID
											SET l.totalScore = l.totalScore + @assetVal
											WHERE u.username = uname;
										
											DELETE FROM tbl_assetTile 
											WHERE assetID =  @asset;
								END IF;
				END IF;
				IF (
					SELECT tileNumber 
					FROM tbl_player p 
					JOIN tbl_user u 
					ON p.userID = u.userID 
					WHERE u.username = uname
					) = 100 
						THEN
							UPDATE tbl_player p 
							JOIN tbl_user u
							ON p.userID = u.userID
							SET p.gameID = NULL, p.player_score = score, p.tileNumber = NULL
							WHERE u.username = uname;
							
							UPDATE tbl_tile 
							SET tilePlayer = NULL 
							WHERE tilePlayer = uname;
							
							UPDATE tbl_leaderboard l 
							JOIN tbl_player p 
							JOIN tbl_user u 
							ON p.userID = u.userID 
							AND l.userID = u.userID 
							SET l.player_score = score, l.totalScore = l.totalscore + score, l.gamesPlayed = l.gamesPlayed + 1 
							WHERE u.username = uname; 
							
							UPDATE tbl_game 
							SET numberOfPlayers = numberOfPlayers -1 
							WHERE gameID = num;
				END IF;
		END IF;

    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `UpdateUser`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateUser`(IN `uname` VARCHAR(100), `email` VARCHAR(100), `pwd` VARCHAR(100), `acc` TINYINT, `priv` TINYINT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
        IF EXISTS(
				SELECT username 
                FROM tbl_user 
                WHERE username = uname) 
					THEN
						UPDATE tbl_user 
						SET user_password = pwd, user_email = email, user_accountStatus = acc, user_isAdmin = priv
						WHERE username = uname;
        END IF;
        
    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `AccountStatus`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AccountStatus`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;
    
	SELECT user_accountStatus 
    FROM tbl_user 
    WHERE username = uname;
        
    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `SendMessage`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SendMessage`(IN `message` VARCHAR(100), gID INT)
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;

	INSERT INTO tbl_gameChat(`text`, gameID) 
    VALUES(message, gID);
    
    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `InsertGameData`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertGameData`(IN `gameMode` VARCHAR(255), uname VARCHAR(100))
BEGIN
    DECLARE i INT DEFAULT 0;
    DECLARE brdID VARCHAR(100) DEFAULT NULL;
    
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    
    START TRANSACTION;

	INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) 
		VALUES(gameID+1, numberOfPlayers+1, gameMode); 
            
	INSERT INTO `tbl_board` (`gameID`) 
		VALUES(LAST_INSERT_ID()); 
            
	INSERT INTO `tbl_gamechat` (`gameID`) 
		VALUES(LAST_INSERT_ID());
			
    UPDATE tbl_player p
	JOIN tbl_user u 
    ON p.userID = u.userID 
	SET p.gameID = LAST_INSERT_ID(), p.tileNumber = 1
	WHERE u.username = uname; 
    
	SET brdID = LAST_INSERT_ID(); 
            
	WHILE i <= 99 DO
		INSERT INTO tbl_tile (boardID, tileNumber) 
		VALUES(brdID, i+1);
		SET i = i + 1;
	END WHILE;
		
	UPDATE tbl_game 
	SET gameNumber = gameID;
    
	UPDATE tbl_tile t
	INNER JOIN tbl_player p 
    ON t.boardID = p.gameID
	INNER JOIN tbl_user u 
    ON p.userID = u.userID 
    SET t.tilePlayer = uname
	WHERE t.tileNumber = 1
	AND t.boardID = p.gameID;
            
	IF(brdID = 1) 
		THEN
			INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`, `gameID`) 
				VALUES('Sword', 'WeapON', 600, brdID);
            
			INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) 
				VALUES(LAST_INSERT_ID(), FLOOR(RAND()*(32-2+1))+2);
                        
			INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`, `gameID`) 
				VALUES('BeacON', 'Updgrade', FLOOR(1500 + RAND() * 500), brdID);
            
            INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) 
				VALUES(LAST_INSERT_ID(), FLOOR(RAND()*(65-33+1))+33);
            
			INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`, `gameID`) 
				VALUES('Gold Pouch', 'Currency', FLOOR(1 + RAND() * 500), brdID);
			
            INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) 
				VALUES(LAST_INSERT_ID(), FLOOR(RAND()*(98-66+1))+66);
                  
		ELSE 
            INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`, `gameID`) 
				VALUES('Sword', 'WeapON', 600, brdID);
            
           INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) 
			VALUES(LAST_INSERT_ID(), FLOOR((RAND()*(32-2+1))+2)+((brdID-1)*100)); -- ==============
                        
			INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`, `gameID`) 
				VALUES('BeacON', 'Updgrade', floor(1500 + RAND() * 500), brdID);
            
            INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) 
				VALUES(LAST_INSERT_ID(), FLOOR((RAND()*(65-33+1))+33)+((brdID-1)*100)); -- ==============
            
			INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`, `gameID`) 
				VALUES('Gold Pouch', 'Currency', FLOOR(1 + RAND() * 500), brdID);
			
            INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) 
				VALUES(LAST_INSERT_ID(), FLOOR((RAND()*(98-66+1))+66)+((brdID-1)*100)); -- ==============
	END IF;
    
    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
    
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `GetItemCount`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetItemCount`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;

	SELECT tbl_inventory.quantity
	FROM tbl_inventory 
    INNER JOIN tbl_player 
    ON tbl_inventory.playerID = tbl_player.playerID 
    INNER JOIN tbl_user 
    ON tbl_player.userID = tbl_user.userID
    WHERE  tbl_user.username = uname;
    
    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `GetPlayerScore`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPlayerScore`(IN `uname` VARCHAR(100))
BEGIN
    DECLARE `_rollback` BOOL DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET `_rollback` = 1;
    START TRANSACTION;

	SELECT tbl_leaderboard.totalScore
    FROM tbl_leaderboard 
    INNER JOIN tbl_user 
    ON tbl_leaderboard.userID = tbl_user.userID
    WHERE  tbl_user.username = uname;
    
    IF `_rollback` THEN
        ROLLBACK;
    ELSE
        COMMIT;
    END IF;
END$$
DELIMITER ;
