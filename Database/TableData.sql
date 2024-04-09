USE BidingSystem


INSERT INTO Users (Username, Nickname, UserType) VALUES
('john_doe', 'John', 'Basic'),
('alice_smith', 'Alice', 'Basic'),
('admin1', NULL, 'Admin');


INSERT INTO Bid (BidSum, TimeOfBid, UserID) VALUES
(250.17, '2024-04-08 10:30:00', 1),
(300.30, '2024-04-08 11:15:00', 2),
(400.99, '2024-04-08 12:00:00', 1);


INSERT INTO Auction (AuctionDescription, AuctionName, CurrentMaxSum, UserID, BidID, DateOfStart) VALUES
('Delete a Trump post Auction', 'Delete Trumps post', 250.17, 3, 1, '2024-04-10 09:00:00'),
('Delete a Trump post Auction', 'Delete Trumps post', 300.30, 3, 2, '2024-04-10 09:00:00'),
('The Kings Personal Conversations', 'Artwork Collection', 400.99, 3, 1,'2024-04-12 10:00:00');


