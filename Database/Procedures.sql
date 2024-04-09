USE BidingSystem

Select * from Bid
Select * from Users
Select * from Auction


CREATE PROCEDURE getUsersFromAuction
    @auctionID INT
AS
BEGIN
    SELECT U.*
    FROM Users U
    INNER JOIN Auction A ON U.UserID = A.UserID
    WHERE A.AuctionID = @auctionID;
END;

EXEC getUsersFromAuction @auctionID = 1


CREATE PROCEDURE GetBidsFromAuction
    @AuctionID INT
AS
BEGIN
    SELECT B.*
    FROM Bid B
    INNER JOIN AuctionBid AB ON B.BidID = AB.BidID
    WHERE AB.AuctionID = @AuctionID;
END;

exec GetBidsFromAuction @AuctionID = 1;

CREATE PROCEDURE GetUniqueUsersFromAuctionBids
    @AuctionID INT
AS
BEGIN
    SELECT DISTINCT U.*
    FROM Users U
    INNER JOIN Bid B ON U.UserID = B.UserID
    INNER JOIN AuctionBid AB ON B.BidID = AB.BidID
    WHERE AB.AuctionID = @AuctionID;
END;

EXEC GetUniqueUsersFromAuctionBids @AuctionID = 1;

