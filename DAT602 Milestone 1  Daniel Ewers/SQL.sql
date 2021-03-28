drop database if exists DAT602_AssessmentDB;
create database DAT602_AssessmentDB;
use DAT602_AssessmentDB;

drop procedure if exists createtbl;  /*Create Tables*/
delimiter //
create procedure createtbl()
begin
DROP TABLE IF EXISTS `tbl_asset`;
CREATE TABLE `tbl_asset` (
	`assetID` INTEGER NOT NULL AUTO_INCREMENT,
	`asset_name` VARCHAR(50) NOT NULL,
	`asset_type` VARCHAR(50) NOT NULL,
	`asset_value` INTEGER DEFAULT 0 NOT NULL,
	PRIMARY KEY (`assetID`)
);

DROP TABLE IF EXISTS `tbl_game`;
CREATE TABLE `tbl_game` (
	`gameID` INTEGER NOT NULL AUTO_INCREMENT,
	`gameNumber` INTEGER DEFAULT 0 NOT NULL,
	`numberOfPlayers` INTEGER DEFAULT 0 NOT NULL,
	`gameMode` VARCHAR(30) NOT NULL,
	PRIMARY KEY (`gameID`)
);

DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE `tbl_user` (
	`userID` INTEGER NOT NULL AUTO_INCREMENT,
	`username` VARCHAR(50) NOT NULL,
	`user_password` VARCHAR(20) NOT NULL,
	`user_email` VARCHAR(20) NOT NULL,
	`user_loginAttempts` INTEGER DEFAULT 0 NOT NULL,
	`user_accountStatus` varchar(30) NOT NULL,
	`user_isAdmin` BOOLEAN NOT NULL,
	PRIMARY KEY (`userID`)
);

DROP TABLE IF EXISTS `tbl_board`;
CREATE TABLE `tbl_board` (
	`boardID` INTEGER NOT NULL AUTO_INCREMENT,
	`gameID` INTEGER NOT NULL,
	PRIMARY KEY (`boardID`),
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`)
);

DROP TABLE IF EXISTS `tbl_gameChat`;
CREATE TABLE `tbl_gameChat` (
	`chatID` INTEGER NOT NULL AUTO_INCREMENT,
	`text` VARCHAR(255),
	`gameID` INTEGER NOT NULL,
	PRIMARY KEY (`chatID`),
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`)
);

DROP TABLE IF EXISTS `tbl_tile`;
CREATE TABLE `tbl_tile` (
	`tileID` INTEGER NOT NULL AUTO_INCREMENT,
	`boardID` INTEGER NOT NULL,
	PRIMARY KEY (`tileID`),
	FOREIGN KEY (`boardID`) REFERENCES `tbl_board`(`boardID`)
);

DROP TABLE IF EXISTS `tbl_assetTile`;
CREATE TABLE `tbl_assetTile` (
	`assetTileID` INTEGER NOT NULL AUTO_INCREMENT,
	`assetID` INTEGER NOT NULL,
	`tileID` INTEGER NOT NULL,
	PRIMARY KEY (`assetTileID`),
	FOREIGN KEY (`tileID`) REFERENCES `tbl_tile`(`tileID`),
	FOREIGN KEY (`assetID`) REFERENCES `tbl_asset`(`assetID`)
);

DROP TABLE IF EXISTS `tbl_player`;
CREATE TABLE `tbl_player` (
	`playerID` INTEGER NOT NULL AUTO_INCREMENT,
	`player_score` INTEGER DEFAULT 0 NOT NULL,
	`colour` VARCHAR(20) NOT NULL,
	`gameID` INTEGER NOT NULL,
	`tileID` INTEGER NOT NULL,
	`userID` INTEGER NOT NULL,
	PRIMARY KEY (`playerID`),
	FOREIGN KEY (`gameID`) REFERENCES `tbl_game`(`gameID`),
	FOREIGN KEY (`tileID`) REFERENCES `tbl_tile`(`tileID`),
	FOREIGN KEY (`userID`) REFERENCES `tbl_user`(`userID`)
);

DROP TABLE IF EXISTS `tbl_inventory`;
CREATE TABLE `tbl_inventory` (
	`inventoryID` INTEGER NOT NULL AUTO_INCREMENT,
	`quantity` INTEGER DEFAULT 0 NOT NULL,
	`assetID` INTEGER NOT NULL,
	`playerID` INTEGER NOT NULL,
	PRIMARY KEY (`inventoryID`),
	FOREIGN KEY (`assetID`) REFERENCES `tbl_asset`(`assetID`),
	FOREIGN KEY (`playerID`) REFERENCES `tbl_player`(`playerID`)
);

DROP TABLE IF EXISTS `tbl_leaderboard`;
CREATE TABLE `tbl_leaderboard` (
	`leaderboardID` INTEGER NOT NULL AUTO_INCREMENT,
	`totalScore` INTEGER DEFAULT 0 NOT NULL,
	`gamesPlayed` INTEGER DEFAULT 0 NOT NULL,
	`averageScore` INTEGER DEFAULT 0 NOT NULL,
	`player_score` INTEGER NOT NULL,
	`userID` INTEGER NOT NULL,
	`playerID` INTEGER NOT NULL,
	PRIMARY KEY (`leaderboardID`),
	FOREIGN KEY (`userID`) REFERENCES `tbl_user`(`userID`),
	FOREIGN KEY (`playerID`) REFERENCES `tbl_player`(`playerID`)
);
end //
delimiter ;

drop procedure if exists testData; /*testData Statements*/
delimiter //
create procedure testData()
begin
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('Sword', 'Weapon', 999);
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('Pistol', 'Weapon', 250);
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('Gold Pouch', 'Currency', 43);
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('Beacon', 'Upgrade', 2500);
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('Chicken Wing', 'Edible', 10);
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('rat', 'pet', 99);
INSERT INTO `tbl_asset` (`asset_name`, `asset_type`, `asset_value`) VALUES('Chicken', 'pet', 10);

INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(1, 1, 'Classic');
INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(2, 5, 'FFA');
INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(3, 2, 'Classic');
INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(4, 2, 'Imposter');
INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(5, 4, 'Timed');
INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(6, 2, 'Imposter');
INSERT INTO `tbl_game` (`gameNumber`, `numberOfPlayers`, `gameMode`) VALUES(7, 4, 'Timed');

INSERT INTO `tbl_board` (`gameID`) VALUES(1);
INSERT INTO `tbl_board` (`gameID`) VALUES(2);
INSERT INTO `tbl_board` (`gameID`) VALUES(3);
INSERT INTO `tbl_board` (`gameID`) VALUES(4);
INSERT INTO `tbl_board` (`gameID`) VALUES(5);
INSERT INTO `tbl_board` (`gameID`) VALUES(6);
INSERT INTO `tbl_board` (`gameID`) VALUES(7);

INSERT INTO `tbl_tile` (`boardID`) VALUES(1);
INSERT INTO `tbl_tile` (`boardID`) VALUES(1);
INSERT INTO `tbl_tile` (`boardID`) VALUES(1);
INSERT INTO `tbl_tile` (`boardID`) VALUES(1);
INSERT INTO `tbl_tile` (`boardID`) VALUES(1);
INSERT INTO `tbl_tile` (`boardID`) VALUES(1);
INSERT INTO `tbl_tile` (`boardID`) VALUES(1);

INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(1, 1);
INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(2, 2);
INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(3, 3);
INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(4, 4);
INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(5, 5);
INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(6, 6);
INSERT INTO `tbl_assetTile` (`assetID`, `tileID`) VALUES(7, 7);

INSERT INTO `tbl_gameChat` (`text`, `gameID`) VALUES('You are noob', 1);
INSERT INTO `tbl_gameChat` (`text`, `gameID`) VALUES('nooooooooooo', 1);
INSERT INTO `tbl_gameChat` (`text`, `gameID`) VALUES('yes hahaha noob', 1);
INSERT INTO `tbl_gameChat` (`text`, `gameID`) VALUES('ez win hahaha', 1);
INSERT INTO `tbl_gameChat` (`text`, `gameID`) VALUES('*cries*', 1);

INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Daniel', 'password123', 'Daniel@email', 1, 'unlocked', true);
INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Travis', 'abc123', 'Travis@email', 5, 'locked', false);
INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Phil', '12345', 'Phil@email', 3, 'unlocked', false);
INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Jordan', 'jordan123', 'Jordan@email', 1, 'unlocked', true);
INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Mitchel', 'qwerty123', 'Mitchel@email', 2, 'unlocked', false);
INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Jordan2', 'jordan123', 'Jordan@email', 1, 'unlocked', true);
INSERT INTO `tbl_user` (`username`, `user_password`, `user_email`, `user_loginAttempts`, `user_accountStatus`, `user_isAdmin`) VALUES('Mitchel2', 'qwerty123', 'Mitchel@email', 2, 'unlocked', false);

INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(500, 'Red', 1, 1, 1);
INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(1500, 'Green', 1, 2, 2);
INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(10, 'Blue', 1, 3, 3);
INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(30000, 'Purple', 1, 4, 4);
INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(30, 'Yellow', 1, 5, 5);
INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(30000, 'Purple', 1, 6, 6);
INSERT INTO `tbl_player` (`player_score`, `colour`, `gameID`, `tileID`, `userID`) VALUES(30, 'Yellow', 1, 7, 7);

INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) VALUES(1, 1, 1);
INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) VALUES(1, 2, 2);
INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) VALUES(1, 2, 3);
INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) VALUES(1, 1, 4);
INSERT INTO `tbl_inventory` (`quantity`, `assetID`, `playerID`) VALUES(1, 5, 5);

INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `averageScore`, `player_score`,`playerID`, `userID`) VALUES(2000, 4, 500, 500, 1,1);
INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `averageScore`, `player_score`,`playerID`, `userID`) VALUES(4500, 9, 500, 1500, 2,2);
INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `averageScore`, `player_score`,`playerID`, `userID`) VALUES(100, 10, 10, 10, 3,3);
INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `averageScore`, `player_score`,`playerID`, `userID`) VALUES(150000, 100, 1500, 30000, 4,4);
INSERT INTO `tbl_leaderboard` (`totalScore`, `gamesPlayed`, `averageScore`, `player_score`,`playerID`, `userID`) VALUES(1000, 5, 200, 30, 5,5);

UPDATE `tbl_asset` SET `asset_name`='Boat', `asset_type`='Vehicle', `asset_value`=1499 WHERE `assetID`=1;
UPDATE `tbl_asset` SET `asset_name`='Cheese', `asset_type`='Edible', `asset_value`=3 WHERE `assetID`=4;

UPDATE `tbl_assetTile` SET `assetID`=4, `tileID`=4 WHERE `assetTileID`=1;
UPDATE `tbl_assetTile` SET `assetID`=1, `tileID`=1 WHERE `assetTileID`=3;

UPDATE `tbl_board` SET `gameID`=4 WHERE `boardID`=1;
UPDATE `tbl_board` SET `gameID`=2 WHERE `boardID`=3;

UPDATE `tbl_game` SET `gameNumber`=22, `numberOfPlayers`=5, `gameMode`='Death Swap' WHERE `gameID`=1;
UPDATE `tbl_game` SET `gameNumber`=123, `numberOfPlayers`=8, `gameMode`='Classic' WHERE `gameID`=4;

UPDATE `tbl_gameChat` SET `text`='Here is some random text to confuse you', `gameID`=1 WHERE `chatID`=2;
UPDATE `tbl_gameChat` SET `text`='Bing boom pow', `gameID`=1 WHERE `chatID`=4;

UPDATE `tbl_inventory` SET `quantity`=5, `assetID`=2, `playerID`=1 WHERE `inventoryID`=1;
UPDATE `tbl_inventory` SET `quantity`=12, `assetID`=5, `playerID`=2 WHERE `inventoryID`=2;

UPDATE `tbl_leaderboard` SET `totalScore`=600, `gamesPlayed`=5, `averageScore`=120, `player_score`=60, `userID`=1 WHERE `leaderboardID`=2;
UPDATE `tbl_leaderboard` SET `totalScore`=1200, `gamesPlayed`=2, `averageScore`=600, `player_score`=600, `userID`=3 WHERE `leaderboardID`=5;

UPDATE `tbl_player` SET `player_score`=5500, `colour`='Pink', `gameID`=1, `tileID`=4, `userID`=1 WHERE `playerID`=1;
UPDATE `tbl_player` SET `player_score`=20, `colour`='Violet', `gameID`=1, `tileID`=5, `userID`=3 WHERE `playerID`=2;

UPDATE `tbl_tile` SET `boardID`=4 WHERE `tileID`=2;
UPDATE `tbl_tile` SET `boardID`=2 WHERE `tileID`=1;

UPDATE `tbl_user` SET `username`= 'johnny', `user_password`='mypwd', `user_email`='fakeEmail@email', `user_loginAttempts`=3, `user_accountStatus`='unlocked', `user_isAdmin`=false WHERE `userID`='2';
UPDATE `tbl_user` SET `username`= 'bobert', `user_password`='password51', `user_email`='randomEmail@email', `user_loginAttempts`=1, `user_accountStatus`='unlocked', `user_isAdmin`=true WHERE `userID`='1';


SELECT tbl_leaderboard.*, tbl_user.* FROM `tbl_leaderboard` tbl_leaderboard, `tbl_user` tbl_user WHERE  	tbl_leaderboard.`userID` = tbl_user.`userID`;
SELECT tbl_inventory.*, tbl_player.* FROM `tbl_inventory` tbl_inventory, `tbl_player` tbl_player WHERE  	tbl_inventory.`playerID` = tbl_player.`playerID`;
SELECT tbl_player.*, tbl_user.* FROM `tbl_player` tbl_player, `tbl_user` tbl_user WHERE  	tbl_player.`userID` = tbl_user.`userID`;
SELECT tbl_game.*, tbl_player.* FROM `tbl_game` tbl_game, `tbl_player` tbl_player WHERE  	tbl_player.`gameID` = tbl_game.`gameID`;
SELECT tbl_player.*, tbl_tile.* FROM `tbl_player` tbl_player, `tbl_tile` tbl_tile WHERE  	tbl_player.`tileID` = tbl_tile.`tileID`;
SELECT tbl_assetTile.*, tbl_tile.* FROM `tbl_assetTile` tbl_assetTile, `tbl_tile` tbl_tile WHERE  	tbl_assetTile.`tileID` = tbl_tile.`tileID`;
SELECT tbl_board.*, tbl_tile.* FROM `tbl_board` tbl_board, `tbl_tile` tbl_tile WHERE  	tbl_tile.`boardID` = tbl_board.`boardID`;
SELECT tbl_board.*, tbl_game.* FROM `tbl_board` tbl_board, `tbl_game` tbl_game WHERE  	tbl_board.`gameID` = tbl_game.`gameID`;
SELECT tbl_game.*, tbl_gameChat.* FROM `tbl_game` tbl_game, `tbl_gameChat` tbl_gameChat WHERE  	tbl_gameChat.`gameID` = tbl_game.`gameID`;
SELECT tbl_asset.*, tbl_assetTile.* FROM `tbl_asset` tbl_asset, `tbl_assetTile` tbl_assetTile WHERE  	tbl_assetTile.`assetID` = tbl_asset.`assetID`;
SELECT tbl_asset.*, tbl_inventory.* FROM `tbl_asset` tbl_asset, `tbl_inventory` tbl_inventory WHERE  	tbl_inventory.`assetID` = tbl_asset.`assetID`;

DELETE FROM `tbl_asset` WHERE `assetID`> 7;
DELETE FROM `tbl_assetTile` WHERE `assetTileID` > 5;
DELETE FROM `tbl_board` WHERE `boardID` > 5;
DELETE FROM `tbl_game` WHERE `gameID` > 5;
DELETE FROM `tbl_gameChat` WHERE `chatID` > 5;
DELETE FROM `tbl_inventory` WHERE `inventoryID` > 5;
DELETE FROM `tbl_leaderboard` WHERE `leaderboardID`> 5;
DELETE FROM `tbl_player` WHERE `playerID` > 5;
DELETE FROM `tbl_tile` WHERE `tileID` > 5;
DELETE FROM `tbl_user` WHERE `userID` > 5;
end //
delimiter ;

call createtbl();
call testData();







